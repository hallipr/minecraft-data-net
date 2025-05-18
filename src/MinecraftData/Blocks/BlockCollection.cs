using System.Collections.Generic;

namespace MinecraftData;

/// <summary>
/// A collection of Minecraft blocks.
/// </summary>
public class BlockCollection(Block[] data) : CollectionBase<Block>(data)
{
}
