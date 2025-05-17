using System.Text.Json.Serialization;

namespace MinecraftData;

/// <summary>
/// Represents a cost equation for an enchantment with coefficients a * level + b.
/// </summary>
public class EnchantmentCostEquation
{
    /// <summary>
    /// The 'a' coefficient in the equation a * level + b.
    /// </summary>
    [JsonPropertyName("a")]
    public int A { get; set; }
    
    /// <summary>
    /// The 'b' coefficient in the equation a * level + b.
    /// </summary>
    [JsonPropertyName("b")]
    public int B { get; set; }
}
