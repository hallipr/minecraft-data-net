using System.Text.Json.Serialization;

namespace MinecraftData;

/// <summary>
/// Represents a Minecraft musical instrument.
/// </summary>
public class Instrument : INamedItem<int>
{
    /// <summary>
    /// The unique identifier for an instrument.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    /// <summary>
    /// The name of an instrument.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
    
    /// <summary>
    /// The sound ID played by this instrument.
    /// </summary>
    [JsonPropertyName("sound")]
    public string? Sound { get; set; }
    
    /// <summary>
    /// Returns the name of the instrument.
    /// </summary>
    public override string ToString() => Name;
}
