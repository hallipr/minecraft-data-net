using System.Text.Json;
using System.Text.Json.Serialization;

namespace MinecraftData;

/// <summary>
/// A collection of Minecraft recipes.
/// </summary>
public class RecipeCollection
{
    private readonly Dictionary<int, List<Recipe>> _recipesByResultId = new();
    private readonly List<BedrockRecipe> _bedrockRecipes = new();
    
    /// <summary>
    /// Initializes a new instance of the RecipeCollection class.
    /// </summary>
    /// <param name="recipeData">The JSON document containing recipe data.</param>
    public RecipeCollection(JsonDocument recipeData)
    {
        foreach (var resultIdProp in recipeData.RootElement.EnumerateObject())
        {
            if (int.TryParse(resultIdProp.Name, out int resultId))
            {
                // Check if it's a Java recipe array or Bedrock recipe
                if (resultIdProp.Value.ValueKind == JsonValueKind.Array)
                {
                    var recipes = new List<Recipe>();
                    
                    foreach (var recipeElement in resultIdProp.Value.EnumerateArray())
                    {
                        Recipe? recipe = null;
                        
                        if (recipeElement.TryGetProperty("inShape", out _))
                        {
                            recipe = JsonSerializer.Deserialize<ShapedRecipe>(recipeElement.GetRawText());
                        }
                        else if (recipeElement.TryGetProperty("ingredients", out _))
                        {
                            recipe = JsonSerializer.Deserialize<ShapelessRecipe>(recipeElement.GetRawText());
                        }
                        
                        if (recipe != null)
                        {
                            recipes.Add(recipe);
                        }
                    }
                    
                    if (recipes.Count > 0)
                    {
                        _recipesByResultId[resultId] = recipes;
                    }
                }
                else if (resultIdProp.Value.ValueKind == JsonValueKind.Object)
                {
                    // This is a Bedrock recipe
                    var bedrockRecipe = JsonSerializer.Deserialize<BedrockRecipe>(resultIdProp.Value.GetRawText());
                    if (bedrockRecipe != null)
                    {
                        _bedrockRecipes.Add(bedrockRecipe);
                    }
                }
            }
        }
    }
    
    /// <summary>
    /// Gets the recipes for a specific result item ID.
    /// </summary>
    /// <param name="resultId">The ID of the result item.</param>
    /// <returns>A list of recipes that produce the specified item, or an empty list if none found.</returns>
    public IReadOnlyList<Recipe> GetRecipesByResultId(int resultId)
    {
        if (_recipesByResultId.TryGetValue(resultId, out var recipes))
        {
            return recipes;
        }
        
        return Array.Empty<Recipe>();
    }
    
    /// <summary>
    /// Gets all recipes in the collection.
    /// </summary>
    /// <returns>An enumerable of all recipes.</returns>
    public IEnumerable<Recipe> GetAllRecipes()
    {
        return _recipesByResultId.Values.SelectMany(recipes => recipes);
    }
    
    /// <summary>
    /// Gets all Bedrock recipes in the collection.
    /// </summary>
    /// <returns>An enumerable of all Bedrock recipes.</returns>
    public IReadOnlyList<BedrockRecipe> GetBedrockRecipes()
    {
        return _bedrockRecipes;
    }
    
    /// <summary>
    /// Gets a count of all recipes in the collection.
    /// </summary>
    public int Count => _recipesByResultId.Values.Sum(recipes => recipes.Count);
    
    /// <summary>
    /// Gets a count of all Bedrock recipes in the collection.
    /// </summary>
    public int BedrockRecipeCount => _bedrockRecipes.Count;
    
    /// <summary>
    /// Indexer to access recipes by result ID.
    /// </summary>
    /// <param name="resultId">The result item ID.</param>
    /// <returns>A list of recipes that produce the specified item.</returns>
    public IReadOnlyList<Recipe> this[int resultId] => GetRecipesByResultId(resultId);
}
