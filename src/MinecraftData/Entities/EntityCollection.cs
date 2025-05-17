namespace MinecraftData;

/// <summary>
/// A collection of Minecraft entities.
/// </summary>
public class EntityCollection
{
    private readonly Dictionary<int, Entity> _byId = new();
    private readonly Dictionary<string, Entity> _byName = new(StringComparer.OrdinalIgnoreCase);
    
    /// <summary>
    /// Initializes a new instance of the EntityCollection class.
    /// </summary>
    /// <param name="entities">Array of entities to include in the collection.</param>
    public EntityCollection(Entity[] entities)
    {
        Entities = entities;
        
        foreach (var entity in entities)
        {
            _byId[entity.Id] = entity;
            _byName[entity.Name] = entity;
        }
    }
    
    /// <summary>
    /// Gets the array of all entities.
    /// </summary>
    public Entity[] Entities { get; }
    
    /// <summary>
    /// Gets an entity by its ID.
    /// </summary>
    /// <param name="id">The entity ID.</param>
    /// <returns>The entity with the specified ID.</returns>
    public Entity GetById(int id) => _byId.TryGetValue(id, out var entity) ? entity : throw new KeyNotFoundException($"Entity with ID {id} not found");
    
    /// <summary>
    /// Gets an entity by its name.
    /// </summary>
    /// <param name="name">The entity name.</param>
    /// <returns>The entity with the specified name.</returns>
    public Entity GetByName(string name) => _byName.TryGetValue(name, out var entity) ? entity : throw new KeyNotFoundException($"Entity with name '{name}' not found");
}
