using System.Text.Json.Serialization;

namespace MinecraftData;

/// <summary>
/// Extended functionality for the Window class.
/// </summary>
public partial class Window
{
    /// <summary>
    /// Returns the name of the window.
    /// </summary>
    public override string ToString() => Name;
}

/// <summary>
/// Extended functionality for the WindowSlot class.
/// </summary>
public partial class WindowSlot
{
    /// <summary>
    /// Gets whether this is a slot range rather than a single slot.
    /// </summary>
    [JsonIgnore]
    public bool IsRange => Size.HasValue && Size.Value > 1;
    
    /// <summary>
    /// Returns a string that represents the current object.
    /// </summary>
    public override string ToString()
    {
        if (IsRange)
        {
            return $"{Name} (slots {Index}-{Index + Size!.Value - 1})";
        }
        
        return $"{Name} (slot {Index})";
    }
}

/// <summary>
/// Extended functionality for the WindowOpener class.
/// </summary>
public partial class WindowOpener
{
    /// <summary>
    /// Returns a string that represents the current object.
    /// </summary>
    public override string ToString() => $"{Type} ({Id})";
}
