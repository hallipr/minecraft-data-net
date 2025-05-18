using System.Text.Json.Serialization;

namespace MinecraftData;

/// <summary>
/// Represents a Minecraft item.
/// </summary>
public partial class Item : INamedItem<int>
{
    /// <summary>
    /// The unique identifier for an item.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    /// <summary>
    /// The display name of an item.
    /// </summary>
    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; } = string.Empty;
    
    /// <summary>
    /// Stack size for an item.
    /// </summary>
    [JsonPropertyName("stackSize")]
    public int StackSize { get; set; }
    
    /// <summary>
    /// The name of an item.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
    
    /// <summary>
    /// Describes categories of enchants this item can use.
    /// </summary>
    [JsonPropertyName("enchantCategories")]
    public string[]? EnchantCategories { get; set; }
    
    /// <summary>
    /// Describes what items this item can be fixed with in an anvil.
    /// </summary>
    [JsonPropertyName("repairWith")]
    public string[]? RepairWith { get; set; }
    
    /// <summary>
    /// The amount of durability an item has before being damaged/used.
    /// </summary>
    [JsonPropertyName("maxDurability")]
    public int? MaxDurability { get; set; }
    
    /// <summary>
    /// Variations of the item.
    /// </summary>
    [JsonPropertyName("variations")]
    public ItemVariation[]? Variations { get; set; }
}
