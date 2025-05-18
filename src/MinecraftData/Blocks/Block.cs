using System.Text.Json.Serialization;

namespace MinecraftData;

/// <summary>
/// Represents a Minecraft block.
/// </summary>
public partial class Block : INamedItem<int>
{
    /// <summary>
    /// The unique identifier for a block.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    /// <summary>
    /// The display name of a block.
    /// </summary>
    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; } = string.Empty;
    
    /// <summary>
    /// The name of a block.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
    
    /// <summary>
    /// Hardness of a block.
    /// </summary>
    [JsonPropertyName("hardness")]
    public double? Hardness { get; set; }
    
    /// <summary>
    /// Stack size for a block.
    /// </summary>
    [JsonPropertyName("stackSize")]
    public int StackSize { get; set; }
    
    /// <summary>
    /// True if a block is diggable.
    /// </summary>
    [JsonPropertyName("diggable")]
    public bool Diggable { get; set; }
    
    /// <summary>
    /// BoundingBox of a block.
    /// </summary>
    [JsonPropertyName("boundingBox")]
    public string BoundingBox { get; set; } = string.Empty;
    
    /// <summary>
    /// Material of a block.
    /// </summary>
    [JsonPropertyName("material")]
    public string Material { get; set; } = string.Empty;
    
    /// <summary>
    /// Using one of these tools is required to harvest a block.
    /// </summary>
    [JsonPropertyName("harvestTools")]
    public Dictionary<string, bool>? HarvestTools { get; set; }
    
    /// <summary>
    /// Variations of the block.
    /// </summary>
    [JsonPropertyName("variations")]
    public BlockVariation[]? Variations { get; set; }
    
    /// <summary>
    /// Block states.
    /// </summary>
    [JsonPropertyName("states")]
    public BlockState[]? States { get; set; }
}
