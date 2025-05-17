using System.Text.Json.Serialization;

namespace MinecraftData;

/// <summary>
/// Represents a variation of an item.
/// </summary>
public class ItemVariation
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
}
