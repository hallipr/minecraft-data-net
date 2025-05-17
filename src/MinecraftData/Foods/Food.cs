using System.Text.Json.Serialization;

namespace MinecraftData;

/// <summary>
/// Represents a Minecraft food item.
/// </summary>
public class Food
{
    /// <summary>
    /// The associated item ID for this food item.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    /// <summary>
    /// The display name of the food item.
    /// </summary>
    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; } = string.Empty;
    
    /// <summary>
    /// Stack size for the food item.
    /// </summary>
    [JsonPropertyName("stackSize")]
    public int StackSize { get; set; }
    
    /// <summary>
    /// The internal name of the food item.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
    
    /// <summary>
    /// The amount of food points the food item replenishes.
    /// </summary>
    [JsonPropertyName("foodPoints")]
    public float FoodPoints { get; set; }
    
    /// <summary>
    /// The amount of saturation points the food restores (foodPoints * saturationRatio).
    /// </summary>
    [JsonPropertyName("saturation")]
    public float Saturation { get; set; }
    
    /// <summary>
    /// foodPoints + saturation.
    /// </summary>
    [JsonPropertyName("effectiveQuality")]
    public float EffectiveQuality { get; set; }
    
    /// <summary>
    /// The 'saturation modifier' in Minecraft code, used to determine how much saturation an item has.
    /// </summary>
    [JsonPropertyName("saturationRatio")]
    public float SaturationRatio { get; set; }
    
    /// <summary>
    /// Variations of the food item.
    /// </summary>
    [JsonPropertyName("variations")]
    public FoodVariation[]? Variations { get; set; }
    
    /// <summary>
    /// Returns the display name of the food item.
    /// </summary>
    public override string ToString() => DisplayName;
}

/// <summary>
/// Represents a variation of a food item.
/// </summary>
public class FoodVariation
{
    /// <summary>
    /// The metadata value for this variation.
    /// </summary>
    [JsonPropertyName("metadata")]
    public int Metadata { get; set; }
    
    /// <summary>
    /// The display name of this variation.
    /// </summary>
    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; } = string.Empty;
    
    /// <summary>
    /// Returns the display name of the food variation.
    /// </summary>
    public override string ToString() => DisplayName;
}
