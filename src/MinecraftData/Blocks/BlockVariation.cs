using System.Text.Json.Serialization;

namespace MinecraftData;

/// <summary>
/// Represents a variation of a block.
/// </summary>
public class BlockVariation
{
    /// <summary>
    /// The metadata value of the variation.
    /// </summary>
    [JsonPropertyName("metadata")]
    public int Metadata { get; set; }
    
    /// <summary>
    /// The display name of the variation.
    /// </summary>
    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; } = string.Empty;
    
    /// <summary>
    /// Description of the variation.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }
}
