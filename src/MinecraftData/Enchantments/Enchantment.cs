using System.Text.Json.Serialization;

namespace MinecraftData;

/// <summary>
/// Represents a Minecraft enchantment.
/// </summary>
public partial class Enchantment : INamedItem<int>
{
    /// <summary>
    /// The unique identifier for an enchantment.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    /// <summary>
    /// The name of an enchantment.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
    
    /// <summary>
    /// The display name of an enchantment.
    /// </summary>
    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; } = string.Empty;
    
    /// <summary>
    /// The maximum level of an enchantment.
    /// </summary>
    [JsonPropertyName("maxLevel")]
    public int MaxLevel { get; set; }
    
    /// <summary>
    /// Min cost equation's coefficients a * level + b.
    /// </summary>
    [JsonPropertyName("minCost")]
    public EnchantmentCostEquation MinCost { get; set; } = new();
    
    /// <summary>
    /// Max cost equation's coefficients a * level + b.
    /// </summary>
    [JsonPropertyName("maxCost")]
    public EnchantmentCostEquation MaxCost { get; set; } = new();
    
    /// <summary>
    /// Can only be found in a treasure, not created.
    /// </summary>
    [JsonPropertyName("treasureOnly")]
    public bool TreasureOnly { get; set; }
    
    /// <summary>
    /// Is a curse, not an enchantment.
    /// </summary>
    [JsonPropertyName("curse")]
    public bool Curse { get; set; }
    
    /// <summary>
    /// List of enchantment not compatibles.
    /// </summary>
    [JsonPropertyName("exclude")]
    public string[] Exclude { get; set; } = Array.Empty<string>();
    
    /// <summary>
    /// The category of enchantable items.
    /// </summary>
    [JsonPropertyName("category")]
    public string Category { get; set; } = string.Empty;
    
    /// <summary>
    /// Weight of the rarity of the enchantment.
    /// </summary>
    [JsonPropertyName("weight")]
    public int Weight { get; set; }
    
    /// <summary>
    /// Can this enchantment be traded.
    /// </summary>
    [JsonPropertyName("tradeable")]
    public bool Tradeable { get; set; }
    
    /// <summary>
    /// Can this enchantment be discovered.
    /// </summary>
    [JsonPropertyName("discoverable")]
    public bool Discoverable { get; set; }
}
