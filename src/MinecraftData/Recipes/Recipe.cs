using System.Text.Json.Serialization;

namespace MinecraftData;

/// <summary>
/// Base class for Minecraft recipes.
/// </summary>
public abstract class Recipe
{
    /// <summary>
    /// The result of the recipe.
    /// </summary>
    [JsonPropertyName("result")]
    public RecipeItem? Result { get; set; }
}

/// <summary>
/// Represents a shaped Minecraft recipe.
/// </summary>
public class ShapedRecipe : Recipe
{
    /// <summary>
    /// The input shape of the recipe.
    /// </summary>
    [JsonPropertyName("inShape")]
    public RecipeItem[][]? InShape { get; set; }
    
    /// <summary>
    /// The output shape of the recipe.
    /// </summary>
    [JsonPropertyName("outShape")]
    public RecipeItem[][]? OutShape { get; set; }
}

/// <summary>
/// Represents a shapeless Minecraft recipe.
/// </summary>
public class ShapelessRecipe : Recipe
{
    /// <summary>
    /// The ingredients for the recipe.
    /// </summary>
    [JsonPropertyName("ingredients")]
    public RecipeItem[]? Ingredients { get; set; }
}

/// <summary>
/// Represents a Bedrock edition recipe.
/// </summary>
public class BedrockRecipe
{
    /// <summary>
    /// A unique identifier for this recipe.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    
    /// <summary>
    /// What type of recipe and block this recipe relates to.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
    
    /// <summary>
    /// The ingredients for the recipe.
    /// </summary>
    [JsonPropertyName("ingredients")]
    public object[]? Ingredients { get; set; }
    
    /// <summary>
    /// The input for the recipe (for some recipe types).
    /// </summary>
    [JsonPropertyName("input")]
    public object[]? Input { get; set; }
    
    /// <summary>
    /// The output of the recipe.
    /// </summary>
    [JsonPropertyName("output")]
    public object[]? Output { get; set; }
    
    /// <summary>
    /// Specific to bedrock edition.
    /// </summary>
    [JsonPropertyName("priority")]
    public float? Priority { get; set; }
}
