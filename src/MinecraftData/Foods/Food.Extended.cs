using System.Text.Json.Serialization;

namespace MinecraftData;

/// <summary>
/// Extended functionality for the Food class.
/// </summary>
public partial class Food
{
    /// <summary>
    /// Returns the display name of the food item.
    /// </summary>
    public override string ToString() => DisplayName;
}

/// <summary>
/// Extended functionality for the FoodVariation class.
/// </summary>
public partial class FoodVariation
{
    /// <summary>
    /// Returns the display name of the food variation.
    /// </summary>
    public override string ToString() => DisplayName;
}
