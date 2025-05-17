using System.Text.Json.Serialization;

namespace MinecraftData;

/// <summary>
/// Represents a Minecraft potion effect.
/// </summary>
public partial class Effect
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
}
