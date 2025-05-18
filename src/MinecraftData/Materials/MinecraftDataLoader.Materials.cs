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
        var materials = await LoadDataAsync<Dictionary<string, Dictionary<int, float>>>("materials");
        return new MaterialCollection(materials);
    }
}
