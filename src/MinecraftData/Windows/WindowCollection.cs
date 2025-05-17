namespace MinecraftData;

/// <summary>
/// A collection of Minecraft windows/GUI screens.
/// </summary>
public class WindowCollection
{
    private readonly Dictionary<string, Window> _byId = new(StringComparer.OrdinalIgnoreCase);
    
    /// <summary>
    /// Initializes a new instance of the WindowCollection class.
    /// </summary>
    /// <param name="windows">Array of windows to include in the collection.</param>
    public WindowCollection(Window[] windows)
    {
        Windows = windows;
        
        foreach (var window in windows)
        {
            _byId[window.Id] = window;
        }
    }
    
    /// <summary>
    /// Gets the array of all windows.
    /// </summary>
    public Window[] Windows { get; }
    
    /// <summary>
    /// Gets the number of windows in the collection.
    /// </summary>
    public int Count => Windows.Length;
    
    /// <summary>
    /// Gets a window by its ID.
    /// </summary>
    /// <param name="id">The window ID.</param>
    /// <returns>The window with the specified ID.</returns>
    public Window GetById(string id) => _byId.TryGetValue(id, out var window) ? window : throw new KeyNotFoundException($"Window with ID '{id}' not found");
    
    /// <summary>
    /// Gets all windows that can be opened with a specific item, entity, or block.
    /// </summary>
    /// <param name="type">The type of opener (item, entity, or block).</param>
    /// <param name="id">The ID of the item, entity, or block.</param>
    /// <returns>An enumerable of windows that can be opened with the specified opener.</returns>
    public IEnumerable<Window> GetByOpener(string type, int id)
    {
        return Windows.Where(w => 
            w.OpenedWith != null && 
            w.OpenedWith.Any(o => o.Type.Equals(type, StringComparison.OrdinalIgnoreCase) && o.Id == id));
    }
    
    /// <summary>
    /// Gets all windows that include a slot with the specified name.
    /// </summary>
    /// <param name="slotName">The name of the slot.</param>
    /// <returns>An enumerable of windows that include the specified slot.</returns>
    public IEnumerable<Window> GetBySlotName(string slotName)
    {
        return Windows.Where(w => 
            w.Slots != null && 
            w.Slots.Any(s => s.Name.Equals(slotName, StringComparison.OrdinalIgnoreCase)));
    }
    
    /// <summary>
    /// Indexer to access windows by ID.
    /// </summary>
    /// <param name="id">The window ID.</param>
    /// <returns>The window with the specified ID.</returns>
    public Window this[string id] => GetById(id);
}
