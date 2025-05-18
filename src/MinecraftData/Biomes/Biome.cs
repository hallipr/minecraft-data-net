using System.Text.Json.Serialization;

namespace MinecraftData;

/// <summary>
/// Represents a Minecraft biome.
/// </summary>
public partial class Biome : INamedItem<int>
{
    /// <summary>
    /// The unique identifier for a biome.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    /// <summary>
    /// The name of a biome.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
    
    /// <summary>
    /// The category of a biome.
    /// </summary>
    [JsonPropertyName("category")]
    public string Category { get; set; } = string.Empty;
    
    /// <summary>
    /// An indicator for the temperature in a biome.
    /// </summary>
    [JsonPropertyName("temperature")]
    public float Temperature { get; set; }
    
    /// <summary>
    /// The type of precipitation: none, rain or snow [before 1.19.4].
    /// </summary>
    [JsonPropertyName("precipitation")]
    public string? Precipitation { get; set; }
    
    /// <summary>
    /// True if a biome has any precipitation (rain or snow) [1.19.4+].
    /// </summary>
    [JsonPropertyName("has_precipitation")]
    public bool? HasPrecipitation { get; set; }
    
    /// <summary>
    /// The dimension of a biome: overworld, nether or end.
    /// </summary>
    [JsonPropertyName("dimension")]
    public string Dimension { get; set; } = string.Empty;
    
    /// <summary>
    /// The display name of a biome.
    /// </summary>
    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; } = string.Empty;
    
    /// <summary>
    /// The color in a biome.
    /// </summary>
    [JsonPropertyName("color")]
    public int Color { get; set; }
    
    /// <summary>
    /// How much rain there is in a biome [before 1.19.4].
    /// </summary>
    [JsonPropertyName("rainfall")]
    public float? Rainfall { get; set; }
}
