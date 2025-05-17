using System.Text.Json.Serialization;

namespace MinecraftData;

/// <summary>
/// Represents a Minecraft potion effect.
/// </summary>
public class Effect
{
    /// <summary>
    /// The unique identifier for an effect.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    /// <summary>
    /// The display name of an effect.
    /// </summary>
    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; } = string.Empty;
    
    /// <summary>
    /// The internal name of an effect.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
    
    /// <summary>
    /// Whether an effect is positive ("good") or negative ("bad").
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = string.Empty;
    
    /// <summary>
    /// Determines if this is a positive effect.
    /// </summary>
    [JsonIgnore]
    public bool IsPositive => Type.Equals("good", StringComparison.OrdinalIgnoreCase);
    
    /// <summary>
    /// Determines if this is a negative effect.
    /// </summary>
    [JsonIgnore]
    public bool IsNegative => Type.Equals("bad", StringComparison.OrdinalIgnoreCase);
    
    /// <summary>
    /// Returns the display name of the effect.
    /// </summary>
    public override string ToString() => DisplayName;
}
