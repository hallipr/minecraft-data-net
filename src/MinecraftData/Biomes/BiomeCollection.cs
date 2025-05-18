using System.Collections;
using System.Collections.Generic;

namespace MinecraftData;

/// <summary>
/// A collection of Minecraft biomes.
/// </summary>
public class BiomeCollection(Biome[] data) : CollectionBase<Biome>(data)
{
}
