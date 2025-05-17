namespace MinecraftData;

/// <summary>
/// A collection of Minecraft enchantments.
/// </summary>
public class EnchantmentCollection
{
    private readonly Dictionary<int, Enchantment> _byId = new();
    private readonly Dictionary<string, Enchantment> _byName = new(StringComparer.OrdinalIgnoreCase);
    
    /// <summary>
    /// Initializes a new instance of the EnchantmentCollection class.
    /// </summary>
    /// <param name="enchantments">Array of enchantments to include in the collection.</param>
    public EnchantmentCollection(Enchantment[] enchantments)
    {
        Enchantments = enchantments;
        
        foreach (var enchantment in enchantments)
        {
            _byId[enchantment.Id] = enchantment;
            _byName[enchantment.Name] = enchantment;
        }
    }
    
    /// <summary>
    /// Gets the array of all enchantments.
    /// </summary>
    public Enchantment[] Enchantments { get; }
    
    /// <summary>
    /// Gets an enchantment by its ID.
    /// </summary>
    /// <param name="id">The enchantment ID.</param>
    /// <returns>The enchantment with the specified ID.</returns>
    public Enchantment GetById(int id) => _byId.TryGetValue(id, out var enchantment) ? enchantment : throw new KeyNotFoundException($"Enchantment with ID {id} not found");
    
    /// <summary>
    /// Gets an enchantment by its name.
    /// </summary>
    /// <param name="name">The enchantment name.</param>
    /// <returns>The enchantment with the specified name.</returns>
    public Enchantment GetByName(string name) => _byName.TryGetValue(name, out var enchantment) ? enchantment : throw new KeyNotFoundException($"Enchantment with name '{name}' not found");
}
