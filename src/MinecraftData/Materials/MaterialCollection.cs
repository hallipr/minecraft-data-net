using System.Collections;
using System.Diagnostics.CodeAnalysis;

namespace MinecraftData;

/// <summary>
/// A collection of Minecraft materials.
/// </summary>
public class MaterialCollection : IReadOnlyDictionary<string, Dictionary<int, float>>
{
    private readonly Dictionary<string, Dictionary<int, float>> _materials = new(StringComparer.OrdinalIgnoreCase);
    
    /// <summary>
    /// Initializes a new instance of the MaterialCollection class.
    /// </summary>
    /// <param name="materialsJson">The JSON document containing material data.</param>
    public MaterialCollection(Dictionary<string, Dictionary<int, float>> materials)
    {
        _materials = materials;
    }

    /// <summary>
    /// Indexer to access materials by name.
    /// </summary>
    /// <param name="name">The material name.</param>
    /// <returns>The material with the specified name.</returns>
    public Dictionary<int, float> this[string name] => _materials[name];

    /// <summary>
    /// Gets the number of materials in the collection.
    /// </summary>
    public int Count => _materials.Count;

    public IEnumerable<string> Keys => _materials.Keys;

    public IEnumerable<Dictionary<int, float>> Values => _materials.Values;

    public bool ContainsKey(string key) => _materials.ContainsKey(key);

    public bool TryGetValue(string key, [MaybeNullWhen(false)] out Dictionary<int, float> value) => _materials.TryGetValue(key, out value);

    public IEnumerator<KeyValuePair<string, Dictionary<int, float>>> GetEnumerator() => _materials.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => _materials.GetEnumerator();
}
