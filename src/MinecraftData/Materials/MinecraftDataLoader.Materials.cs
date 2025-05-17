using System.Text.Json;

namespace MinecraftData;

public partial class MinecraftDataLoader
{
    /// <summary>
    /// Asynchronously loads materials data for the specified edition and version.
    /// </summary>
    /// <returns>A collection of Material objects.</returns>
    public async Task<MaterialCollection> LoadMaterialsAsync()
    {
        using var stream = await GetDataStreamAsync("materials");
        var document = await JsonDocument.ParseAsync(stream);
        return new MaterialCollection(document);
    }
    
    /// <summary>
    /// Helper method to get a data stream for the specified data type.
    /// </summary>
    /// <param name="dataType">The type of data to load (e.g., "enchantments", "blocks").</param>
    /// <param name="fileName">The name of the JSON file (defaults to dataType + ".json").</param>
    private async Task<Stream> GetDataStreamAsync(string dataType, string? fileName = null)
    {
        fileName ??= $"{dataType}.json";
        string dataPath = _dataPathsIndex.GetPath(_edition, _version, dataType);
        string filePath = Path.Combine(_dataBasePath, dataPath, fileName);
        
        return File.OpenRead(filePath);
    }
}
