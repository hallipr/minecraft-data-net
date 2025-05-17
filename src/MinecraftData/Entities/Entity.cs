using System.Text.Json.Serialization;

namespace MinecraftData;

/// <summary>
/// Represents a Minecraft entity.
/// </summary>
public class Entity
{
    /// <summary>
    /// The unique identifier for an entity.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    /// <summary>
    /// The internal id of an entity: used in eggs metadata for example.
    /// </summary>
    [JsonPropertyName("internalId")]
    public int? InternalId { get; set; }
    
    /// <summary>
    /// The display name of an entity.
    /// </summary>
    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; } = string.Empty;
    
    /// <summary>
    /// The name of an entity.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
    
    /// <summary>
    /// The type of an entity.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = string.Empty;
    
    /// <summary>
    /// The width of the entity.
    /// </summary>
    [JsonPropertyName("width")]
    public float? Width { get; set; }
    
    /// <summary>
    /// The height of the entity.
    /// </summary>
    [JsonPropertyName("height")]
    public float? Height { get; set; }
    
    /// <summary>
    /// The length of the entity.
    /// </summary>
    [JsonPropertyName("length")]
    public float? Length { get; set; }
    
    /// <summary>
    /// The offset of the entity.
    /// </summary>
    [JsonPropertyName("offset")]
    public float? Offset { get; set; }
    
    /// <summary>
    /// The category of an entity: a semantic category.
    /// </summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }
    
    /// <summary>
    /// The PC metadata tags of an entity.
    /// </summary>
    [JsonPropertyName("metadataKeys")]
    public string[]? MetadataKeys { get; set; }
}
