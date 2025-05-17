namespace MinecraftData;

/// <summary>
/// A collection of Minecraft items.
/// </summary>
public class ItemCollection
{
    private readonly Dictionary<int, Item> _byId = new();
    private readonly Dictionary<string, Item> _byName = new(StringComparer.OrdinalIgnoreCase);
    
    /// <summary>
    /// Initializes a new instance of the ItemCollection class.
    /// </summary>
    /// <param name="items">Array of items to include in the collection.</param>
    public ItemCollection(Item[] items)
    {
        Items = items;
        
        foreach (var item in items)
        {
            _byId[item.Id] = item;
            _byName[item.Name] = item;
        }
    }
    
    /// <summary>
    /// Gets the array of all items.
    /// </summary>
    public Item[] Items { get; }
    
    /// <summary>
    /// Gets an item by its ID.
    /// </summary>
    /// <param name="id">The item ID.</param>
    /// <returns>The item with the specified ID.</returns>
    public Item GetById(int id) => _byId.TryGetValue(id, out var item) ? item : throw new KeyNotFoundException($"Item with ID {id} not found");
    
    /// <summary>
    /// Gets an item by its name.
    /// </summary>
    /// <param name="name">The item name.</param>
    /// <returns>The item with the specified name.</returns>
    public Item GetByName(string name) => _byName.TryGetValue(name, out var item) ? item : throw new KeyNotFoundException($"Item with name '{name}' not found");
}
