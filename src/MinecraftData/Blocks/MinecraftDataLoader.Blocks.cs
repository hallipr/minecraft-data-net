namespace MinecraftData;

public partial class MinecraftDataLoader
{
    /// <summary>
    /// Asynchronously loads blocks data for the specified edition and version.
    /// </summary>
    /// <returns>A collection of Block objects.</returns>
    public async Task<BlockCollection> LoadBlocksAsync()
    {
        var blocks = await LoadDataAsync<Block[]>("blocks");
        return new BlockCollection(blocks);
    }
}
