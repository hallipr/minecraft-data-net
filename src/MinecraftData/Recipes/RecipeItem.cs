using System.Text.Json.Serialization;

namespace MinecraftData;

/// <summary>
/// Represents a Minecraft recipe item.
/// </summary>
public partial class RecipeItem
{
    /// <summary>
    /// The ID of the item.
    /// </summary>
    [JsonPropertyName("id")]
    public int? Id { get; set; }
    
    /// <summary>
    /// The metadata of the item.
    /// </summary>
    [JsonPropertyName("metadata")]
    public int? Metadata { get; set; }
    
    /// <summary>
    /// The count of the item.
    /// </summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }
}
