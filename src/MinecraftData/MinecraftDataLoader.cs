using System.Text.Json;

namespace MinecraftData;

/// <summary>
/// Main entry point for accessing Minecraft data for different editions and versions.
/// </summary>
public partial class MinecraftDataLoader
{
    private readonly string _edition;
    private readonly string _version;
    private readonly string _dataBasePath;
    private readonly DataPathsIndex _dataPathsIndex;

    /// <summary>
    /// Initializes a new instance of the MinecraftData class for accessing Minecraft data.
    /// </summary>
    /// <param name="edition">The Minecraft edition (e.g., "pc", "bedrock")</param>
    /// <param name="version">The Minecraft version (e.g., "1.21.80", "1.19.2")</param>
    public MinecraftDataLoader(string edition, string version)
    {
        _edition = edition;
        _version = version;
        _dataBasePath = Path.Combine(AppContext.BaseDirectory, "Data");
        
        // Load the data paths index file
        string dataPathsJson = File.ReadAllText(Path.Combine(_dataBasePath, "dataPaths.json"));
        _dataPathsIndex = JsonSerializer.Deserialize<DataPathsIndex>(dataPathsJson)
            ?? throw new InvalidOperationException("Failed to load dataPaths.json");
            
        if (!_dataPathsIndex.ContainsEdition(edition) || !_dataPathsIndex.ContainsVersion(edition, version))
        {
            throw new ArgumentException($"Edition '{edition}' with version '{version}' not found in dataPaths.json");
        }
    }

    /// <summary>
    /// Helper method to load data from a JSON file for the current edition and version.
    /// </summary>
    /// <typeparam name="T">The type of data to deserialize.</typeparam>
    /// <param name="dataType">The type of data to load (e.g., "enchantments", "blocks").</param>
    /// <param name="fileName">The name of the JSON file (defaults to dataType + ".json").</param>
    /// <returns>An array of deserialized objects.</returns>
    private async Task<T> LoadDataAsync<T>(string dataType, string? fileName = null)
    {
        fileName ??= $"{dataType}.json";
        string dataPath = _dataPathsIndex.GetPath(_edition, _version, dataType);
        string filePath = Path.Combine(_dataBasePath, dataPath, fileName);

        using FileStream stream = File.OpenRead(filePath);
        var result = await JsonSerializer.DeserializeAsync<T>(stream);
        if (result == null)
        {
            throw new InvalidOperationException($"Failed to load data from {filePath}");
        }
        return result;
    }
    
    /// <summary>
    /// Gets all available editions in the data.
    /// </summary>
    public IEnumerable<string> GetAvailableEditions() => _dataPathsIndex.GetEditions();
    
    /// <summary>
    /// Gets all available versions for a specific edition.
    /// </summary>
    /// <param name="edition">The Minecraft edition.</param>
    public IEnumerable<string> GetAvailableVersions(string edition) => _dataPathsIndex.GetVersions(edition);
}
