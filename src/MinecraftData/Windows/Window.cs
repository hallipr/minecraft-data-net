using System.Text.Json.Serialization;

namespace MinecraftData;

/// <summary>
/// Represents a Minecraft GUI window/screen.
/// </summary>
public partial class Window
{
    /// <summary>
    /// The unique identifier for the window.
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; } = string.Empty;
    
    /// <summary>
    /// The default displayed name of the window.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
    
    /// <summary>
    /// The slots displayed in the window.
    /// </summary>
    [JsonPropertyName("slots")]
    public WindowSlot[]? Slots { get; set; }
    
    /// <summary>
    /// Names of the properties of the window.
    /// </summary>
    [JsonPropertyName("properties")]
    public string[]? Properties { get; set; }
      /// <summary>
    /// Information about how the window can be opened.
    /// </summary>
    [JsonPropertyName("openedWith")]
    public WindowOpener[]? OpenedWith { get; set; }
}

/// <summary>
/// Represents a slot or slot range in a Minecraft window.
/// </summary>
public partial class WindowSlot
{
    /// <summary>
    /// The name of the slot or slot range.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
    
    /// <summary>
    /// The position of the slot or begin of the slot range.
    /// </summary>
    [JsonPropertyName("index")]
    public int Index { get; set; }
      /// <summary>
    /// The size of the slot range.
    /// </summary>
    [JsonPropertyName("size")]
    public int? Size { get; set; }
}

/// <summary>
/// Represents a way to open a Minecraft window.
/// </summary>
public partial class WindowOpener
{
    /// <summary>
    /// The type of opener (item, entity, or block).
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = string.Empty;
      /// <summary>
    /// The ID of the item, entity, or block that opens the window.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }
}
