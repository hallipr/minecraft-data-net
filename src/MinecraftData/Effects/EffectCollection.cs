namespace MinecraftData;

/// <summary>
/// A collection of Minecraft potion effects.
/// </summary>
public class EffectCollection
{
    private readonly Dictionary<int, Effect> _byId = new();
    private readonly Dictionary<string, Effect> _byName = new(StringComparer.OrdinalIgnoreCase);
    
    /// <summary>
    /// Initializes a new instance of the EffectCollection class.
    /// </summary>
    /// <param name="effects">Array of effects to include in the collection.</param>
    public EffectCollection(Effect[] effects)
    {
        Effects = effects;
        
        foreach (var effect in effects)
        {
            _byId[effect.Id] = effect;
            _byName[effect.Name] = effect;
        }
    }
    
    /// <summary>
    /// Gets the array of all effects.
    /// </summary>
    public Effect[] Effects { get; }
    
    /// <summary>
    /// Gets the number of effects in the collection.
    /// </summary>
    public int Count => Effects.Length;
    
    /// <summary>
    /// Gets an effect by its ID.
    /// </summary>
    /// <param name="id">The effect ID.</param>
    /// <returns>The effect with the specified ID.</returns>
    public Effect GetById(int id) => _byId.TryGetValue(id, out var effect) ? effect : throw new KeyNotFoundException($"Effect with ID {id} not found");
    
    /// <summary>
    /// Gets an effect by its name.
    /// </summary>
    /// <param name="name">The effect name.</param>
    /// <returns>The effect with the specified name.</returns>
    public Effect GetByName(string name) => _byName.TryGetValue(name, out var effect) ? effect : throw new KeyNotFoundException($"Effect with name '{name}' not found");
    
    /// <summary>
    /// Gets all positive effects.
    /// </summary>
    /// <returns>An enumerable of positive effects.</returns>
    public IEnumerable<Effect> GetPositiveEffects() => Effects.Where(e => e.IsPositive);
    
    /// <summary>
    /// Gets all negative effects.
    /// </summary>
    /// <returns>An enumerable of negative effects.</returns>
    public IEnumerable<Effect> GetNegativeEffects() => Effects.Where(e => e.IsNegative);
    
    /// <summary>
    /// Indexer to access effects by ID.
    /// </summary>
    /// <param name="id">The effect ID.</param>
    /// <returns>The effect with the specified ID.</returns>
    public Effect this[int id] => GetById(id);
    
    /// <summary>
    /// Indexer to access effects by name.
    /// </summary>
    /// <param name="name">The effect name.</param>
    /// <returns>The effect with the specified name.</returns>
    public Effect this[string name] => GetByName(name);
}
