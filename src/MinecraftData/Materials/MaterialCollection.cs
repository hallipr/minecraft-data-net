using System.Text.Json;

namespace MinecraftData;

/// <summary>
/// A collection of Minecraft materials.
/// </summary>
public class MaterialCollection
{
    private readonly Dictionary<string, Material> _materials = new(StringComparer.OrdinalIgnoreCase);
    
    /// <summary>
    /// Initializes a new instance of the MaterialCollection class.
    /// </summary>
    /// <param name="materialsJson">The JSON document containing material data.</param>
    public MaterialCollection(JsonDocument materialsJson)
    {
        foreach (var materialProp in materialsJson.RootElement.EnumerateObject())
        {
            string materialName = materialProp.Name;
            var properties = new Dictionary<int, float>();
            
            foreach (var prop in materialProp.Value.EnumerateObject())
            {
                if (int.TryParse(prop.Name, out int key))
                {
                    properties[key] = prop.Value.GetSingle();
                }
            }
            
            var material = new Material(materialName, properties);
            _materials[materialName] = material;
        }
    }
    
    /// <summary>
    /// Gets all material names.
    /// </summary>
    public IEnumerable<string> Names => _materials.Keys;
    
    /// <summary>
    /// Gets all materials.
    /// </summary>
    public IEnumerable<Material> Materials => _materials.Values;
    
    /// <summary>
    /// Gets the number of materials in the collection.
    /// </summary>
    public int Count => _materials.Count;
    
    /// <summary>
    /// Gets a material by its name.
    /// </summary>
    /// <param name="name">The material name.</param>
    /// <returns>The material with the specified name.</returns>
    public Material GetByName(string name)
    {
        if (_materials.TryGetValue(name, out var material))
        {
            return material;
        }
        
        throw new KeyNotFoundException($"Material with name '{name}' not found");
    }
    
    /// <summary>
    /// Tries to get a material by its name.
    /// </summary>
    /// <param name="name">The material name.</param>
    /// <param name="material">When this method returns, contains the material with the specified name, if found; otherwise, null.</param>
    /// <returns>true if the material was found; otherwise, false.</returns>
    public bool TryGetByName(string name, out Material? material)
    {
        return _materials.TryGetValue(name, out material);
    }
    
    /// <summary>
    /// Indexer to access materials by name.
    /// </summary>
    /// <param name="name">The material name.</param>
    /// <returns>The material with the specified name.</returns>
    public Material this[string name] => GetByName(name);
}
