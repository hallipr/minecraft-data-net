using System.Text.Json;
using System.Text.Json.Serialization;

namespace MinecraftData;

/// <summary>
/// Represents a Minecraft material.
/// </summary>
public partial class Material
{
    /// <summary>
    /// The name of the material.
    /// </summary>
    public string Name { get; }
    
    /// <summary>
    /// The properties of the material, indexed by their key.
    /// </summary>
    public IReadOnlyDictionary<int, float> Properties { get; }
    
    /// <summary>
    /// Initializes a new instance of the Material class.
    /// </summary>
    /// <param name="name">The name of the material.</param>
    /// <param name="properties">The properties of the material.</param>
    public Material(string name, Dictionary<int, float> properties)
    {
        Name = name;
        Properties = properties;
    }
}
