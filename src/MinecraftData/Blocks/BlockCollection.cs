namespace MinecraftData;

/// <summary>
/// A collection of Minecraft blocks.
/// </summary>
public class BlockCollection
{
    private readonly Dictionary<int, Block> _byId = new();
    private readonly Dictionary<string, Block> _byName = new(StringComparer.OrdinalIgnoreCase);
    
    /// <summary>
    /// Initializes a new instance of the BlockCollection class.
    /// </summary>
    /// <param name="blocks">Array of blocks to include in the collection.</param>
    public BlockCollection(Block[] blocks)
    {
        Blocks = blocks;
        
        foreach (var block in blocks)
        {
            _byId[block.Id] = block;
            _byName[block.Name] = block;
        }
    }
    
    /// <summary>
    /// Gets the array of all blocks.
    /// </summary>
    public Block[] Blocks { get; }
    
    /// <summary>
    /// Gets a block by its ID.
    /// </summary>
    /// <param name="id">The block ID.</param>
    /// <returns>The block with the specified ID.</returns>
    public Block GetById(int id) => _byId.TryGetValue(id, out var block) ? block : throw new KeyNotFoundException($"Block with ID {id} not found");
    
    /// <summary>
    /// Gets a block by its name.
    /// </summary>
    /// <param name="name">The block name.</param>
    /// <returns>The block with the specified name.</returns>
    public Block GetByName(string name) => _byName.TryGetValue(name, out var block) ? block : throw new KeyNotFoundException($"Block with name '{name}' not found");
}
