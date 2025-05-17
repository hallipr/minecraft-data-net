using System.Text.Json;

namespace MinecraftData;

/// <summary>
/// Helper class for parsing and navigating dataPaths.json
/// </summary>
internal class DataPathsIndex
{
    private readonly Dictionary<string, Dictionary<string, Dictionary<string, string>>> _data = new();
    
    public bool ContainsEdition(string edition) => _data.ContainsKey(edition);
    
    public bool ContainsVersion(string edition, string version) => 
        ContainsEdition(edition) && _data[edition].ContainsKey(version);
        
    public IEnumerable<string> GetEditions() => _data.Keys;
    
    public IEnumerable<string> GetVersions(string edition) => 
        ContainsEdition(edition) ? _data[edition].Keys : Enumerable.Empty<string>();
        
    public string GetPath(string edition, string version, string dataType)
    {
        if (!ContainsEdition(edition))
            throw new ArgumentException($"Edition '{edition}' not found", nameof(edition));
            
        if (!ContainsVersion(edition, version))
            throw new ArgumentException($"Version '{version}' not found for edition '{edition}'", nameof(version));
            
        var versionData = _data[edition][version];
        
        if (!versionData.ContainsKey(dataType))
            throw new ArgumentException($"Data type '{dataType}' not available for {edition} {version}", nameof(dataType));
            
        return versionData[dataType];
    }
}
