using System.Text.Json.Serialization;

namespace MinecraftData;

/// <summary>
/// Represents a Minecraft recipe item.
/// </summary>
public class RecipeItem
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
    
    /// <summary>
    /// Creates a new recipe item from an ID.
    /// </summary>
    /// <param name="id">The item ID.</param>
    /// <returns>A new recipe item.</returns>
    public static RecipeItem FromId(int id) => new RecipeItem { Id = id };
    
    /// <summary>
    /// Creates a new recipe item from ID, metadata, and count.
    /// </summary>
    /// <param name="id">The item ID.</param>
    /// <param name="metadata">The item metadata.</param>
    /// <param name="count">The item count.</param>
    /// <returns>A new recipe item.</returns>
    public static RecipeItem Create(int id, int metadata = 0, int count = 1) =>
        new RecipeItem { Id = id, Metadata = metadata, Count = count };
}
