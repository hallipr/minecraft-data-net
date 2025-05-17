namespace MinecraftData;

public partial class MinecraftDataLoader
{
    /// <summary>
    /// Asynchronously loads biomes data for the specified edition and version.
    /// </summary>
    /// <returns>A collection of Biome objects.</returns>
    public async Task<BiomeCollection> LoadBiomesAsync()
    {
        var biomes = await LoadDataAsync<Biome[]>("biomes");
        return new BiomeCollection(biomes);
    }
}
