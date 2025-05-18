namespace MinecraftData;

/// <summary>
/// A collection of Minecraft windows/GUI screens.
/// </summary>
public class WindowCollection(Window[] data) : CollectionBase<Window, string>(data)
{
    /// <summary>
    /// Gets all windows that can be opened with a specific item, entity, or block.
    /// </summary>
    /// <param name="type">The type of opener (item, entity, or block).</param>
    /// <param name="id">The ID of the item, entity, or block.</param>
    /// <returns>An enumerable of windows that can be opened with the specified opener.</returns>
    public IEnumerable<Window> GetByOpener(string type, int id)
    {
        return Items.Where(w => 
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
        return Items.Where(w => 
            w.Slots != null && 
            w.Slots.Any(s => s.Name.Equals(slotName, StringComparison.OrdinalIgnoreCase)));
    }
}
