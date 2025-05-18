namespace MinecraftData;

/// <summary>
/// A collection of Minecraft potion effects.
/// </summary>
public class EffectCollection(Effect[] data) : CollectionBase<Effect>(data)
{
    /// <summary>
    /// Gets all positive effects.
    /// </summary>
    /// <returns>An enumerable of positive effects.</returns>
    public IEnumerable<Effect> GetPositiveEffects() => Items.Where(e => e.IsPositive);
    
    /// <summary>
    /// Gets all negative effects.
    /// </summary>
    /// <returns>An enumerable of negative effects.</returns>
    public IEnumerable<Effect> GetNegativeEffects() => Items.Where(e => e.IsNegative);    
}
