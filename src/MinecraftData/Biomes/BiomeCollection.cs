namespace MinecraftData;

/// <summary>
/// A collection of Minecraft biomes.
/// </summary>
public class BiomeCollection
{
    private readonly Dictionary<int, Biome> _byId = new();
    private readonly Dictionary<string, Biome> _byName = new(StringComparer.OrdinalIgnoreCase);
    
    /// <summary>
    /// Initializes a new instance of the BiomeCollection class.
    /// </summary>
    /// <param name="biomes">Array of biomes to include in the collection.</param>
    public BiomeCollection(Biome[] biomes)
    {
        Biomes = biomes;
        
        foreach (var biome in biomes)
        {
            _byId[biome.Id] = biome;
            _byName[biome.Name] = biome;
        }
    }
    
    /// <summary>
    /// Gets the array of all biomes.
    /// </summary>
    public Biome[] Biomes { get; }
    
    /// <summary>
    /// Gets a biome by its ID.
    /// </summary>
    /// <param name="id">The biome ID.</param>
    /// <returns>The biome with the specified ID.</returns>
    public Biome GetById(int id) => _byId.TryGetValue(id, out var biome) ? biome : throw new KeyNotFoundException($"Biome with ID {id} not found");
    
    /// <summary>
    /// Gets a biome by its name.
    /// </summary>
    /// <param name="name">The biome name.</param>
    /// <returns>The biome with the specified name.</returns>
    public Biome GetByName(string name) => _byName.TryGetValue(name, out var biome) ? biome : throw new KeyNotFoundException($"Biome with name '{name}' not found");
}
