using System.Collections;

namespace MinecraftData;

/// <summary>
/// A collection of Minecraft items.
/// </summary>
public class ItemCollection(Item[] data) : CollectionBase<Item>(data)
{
}