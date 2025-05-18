using System.Text.Json;

namespace MinecraftData;

/// <summary>
/// Helper class for parsing and navigating dataPaths.json
/// </summary>
internal class DataPathsIndex
{
    private readonly Dictionary<string, Dictionary<string, Dictionary<string, string>>> _data = new();
    
    public DataPathsIndex(JsonDocument document)
    {
        var parsed = document.Deserialize<Dictionary<string, Dictionary<string, Dictionary<string, string>>>>();
        if (parsed == null)
            throw new InvalidOperationException("Failed to parse dataPaths.json");
        _data = parsed;
    }

    public bool ContainsEdition(string edition) => _data.ContainsKey(edition);
    
    public bool ContainsVersion(string edition, string version) => 
        ContainsEdition(edition) && _data[edition].ContainsKey(version);
        
    public IEnumerable<string> GetEditions() => _data.Keys;
    
    public IEnumerable<string> GetVersions(string edition) => 
        ContainsEdition(edition) ? _data[edition].Keys : Enumerable.Empty<string>();
        
    public string GetPath(string edition, string version, string dataType)
    {
        if (!_data.TryGetValue(edition, out var editionData))
            throw new ArgumentException($"Edition '{edition}' not found", nameof(edition));

        if (!editionData.TryGetValue(version, out var versionData))
            throw new ArgumentException($"Version '{version}' not found for edition '{edition}'", nameof(version));
            
        if(!versionData.TryGetValue(dataType, out string? value))
            throw new DataNotFoundException(dataType, edition, version);

        return value;
    }
}
