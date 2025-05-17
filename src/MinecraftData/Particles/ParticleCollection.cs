namespace MinecraftData;

/// <summary>
/// A collection of Minecraft particles.
/// </summary>
public class ParticleCollection
{
    private readonly Dictionary<int, Particle> _byId = new();
    private readonly Dictionary<string, Particle> _byName = new(StringComparer.OrdinalIgnoreCase);
    
    /// <summary>
    /// Initializes a new instance of the ParticleCollection class.
    /// </summary>
    /// <param name="particles">Array of particles to include in the collection.</param>
    public ParticleCollection(Particle[] particles)
    {
        Particles = particles;
        
        foreach (var particle in particles)
        {
            _byId[particle.Id] = particle;
            _byName[particle.Name] = particle;
        }
    }
    
    /// <summary>
    /// Gets the array of all particles.
    /// </summary>
    public Particle[] Particles { get; }
    
    /// <summary>
    /// Gets the number of particles in the collection.
    /// </summary>
    public int Count => Particles.Length;
    
    /// <summary>
    /// Gets a particle by its ID.
    /// </summary>
    /// <param name="id">The particle ID.</param>
    /// <returns>The particle with the specified ID.</returns>
    public Particle GetById(int id) => _byId.TryGetValue(id, out var particle) ? particle : throw new KeyNotFoundException($"Particle with ID {id} not found");
    
    /// <summary>
    /// Gets a particle by its name.
    /// </summary>
    /// <param name="name">The particle name.</param>
    /// <returns>The particle with the specified name.</returns>
    public Particle GetByName(string name) => _byName.TryGetValue(name, out var particle) ? particle : throw new KeyNotFoundException($"Particle with name '{name}' not found");
    
    /// <summary>
    /// Indexer to access particles by ID.
    /// </summary>
    /// <param name="id">The particle ID.</param>
    /// <returns>The particle with the specified ID.</returns>
    public Particle this[int id] => GetById(id);
    
    /// <summary>
    /// Indexer to access particles by name.
    /// </summary>
    /// <param name="name">The particle name.</param>
    /// <returns>The particle with the specified name.</returns>
    public Particle this[string name] => GetByName(name);
}
