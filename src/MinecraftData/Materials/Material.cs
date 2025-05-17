using System.Text.Json;
using System.Text.Json.Serialization;

namespace MinecraftData;

/// <summary>
/// Represents a Minecraft material.
/// </summary>
public class Material
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
    
    /// <summary>
    /// Gets a property value by its key.
    /// </summary>
    /// <param name="key">The property key.</param>
    /// <returns>The property value.</returns>
    public float GetProperty(int key)
    {
        if (Properties.TryGetValue(key, out var value))
        {
            return value;
        }
        
        throw new KeyNotFoundException($"Property with key {key} not found for material '{Name}'");
    }
    
    /// <summary>
    /// Tries to get a property value by its key.
    /// </summary>
    /// <param name="key">The property key.</param>
    /// <param name="value">When this method returns, contains the property value, if found; otherwise, the default value of the type.</param>
    /// <returns>true if the property was found; otherwise, false.</returns>
    public bool TryGetProperty(int key, out float value)
    {
        return Properties.TryGetValue(key, out value);
    }
    
    /// <summary>
    /// Returns the name of the material.
    /// </summary>
    public override string ToString() => Name;
}
