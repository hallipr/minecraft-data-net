using System.Text.Json.Serialization;

namespace MinecraftData;

/// <summary>
/// Extended functionality for the Item class.
/// </summary>
public partial class Item
{
    /// <summary>
    /// Determines if this item has durability.
    /// </summary>
    [JsonIgnore]
    public bool HasDurability => MaxDurability.HasValue && MaxDurability.Value > 0;

    /// <summary>
    /// Returns the display name of the item.
    /// </summary>
    public override string ToString() => DisplayName;
}

/// <summary>
/// Extended functionality for the ItemVariation class.
/// </summary>
public partial class ItemVariation
{
    /// <summary>
    /// Returns the display name of the item variation.
    /// </summary>
    public override string ToString() => DisplayName;
}
