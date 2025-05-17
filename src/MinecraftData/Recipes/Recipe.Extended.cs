using System.Text.Json.Serialization;

namespace MinecraftData;

/// <summary>
/// Extended functionality for the Recipe class.
/// </summary>
public abstract partial class Recipe
{
    /// <summary>
    /// Returns a string representation of the recipe result.
    /// </summary>
    public override string ToString() => Result?.ToString() ?? "No Result";
}

/// <summary>
/// Extended functionality for the ShapedRecipe class.
/// </summary>
public partial class ShapedRecipe
{
    /// <summary>
    /// Gets whether the recipe has an input shape defined.
    /// </summary>
    [JsonIgnore]
    public bool HasInShape => InShape != null && InShape.Length > 0;
    
    /// <summary>
    /// Gets whether the recipe has an output shape defined.
    /// </summary>
    [JsonIgnore]
    public bool HasOutShape => OutShape != null && OutShape.Length > 0;
}

/// <summary>
/// Extended functionality for the ShapelessRecipe class.
/// </summary>
public partial class ShapelessRecipe
{
    /// <summary>
    /// Gets whether the recipe has ingredients defined.
    /// </summary>
    [JsonIgnore]
    public bool HasIngredients => Ingredients != null && Ingredients.Length > 0;
}

/// <summary>
/// Extended functionality for the BedrockRecipe class.
/// </summary>
public partial class BedrockRecipe
{
    /// <summary>
    /// Returns the name of the recipe.
    /// </summary>
    public override string ToString() => Name ?? "Unnamed Recipe";
}
