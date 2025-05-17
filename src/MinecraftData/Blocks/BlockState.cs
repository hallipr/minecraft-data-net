using System.Text.Json;
using System.Text.Json.Serialization;

namespace MinecraftData;

/// <summary>
/// Represents a state of a block.
/// </summary>
public class BlockState
{
    /// <summary>
    /// The name of the property.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
    
    /// <summary>
    /// The type of the property.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = string.Empty;
    
    /// <summary>
    /// The possible values of the property.
    /// </summary>
    [JsonPropertyName("values")]
    public JsonElement[]? Values { get; set; }
    
    /// <summary>
    /// The number of possible values.
    /// </summary>
    [JsonPropertyName("num_values")]
    public int NumValues { get; set; }
}
