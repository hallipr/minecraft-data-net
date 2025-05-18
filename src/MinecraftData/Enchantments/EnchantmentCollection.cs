using System.Collections;

namespace MinecraftData;

/// <summary>
/// A collection of Minecraft enchantments.
/// </summary>
public class EnchantmentCollection(Enchantment[] data) : CollectionBase<Enchantment>(data)
{
}
