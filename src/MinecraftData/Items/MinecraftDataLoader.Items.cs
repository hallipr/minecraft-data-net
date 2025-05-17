namespace MinecraftData;

public partial class MinecraftDataLoader
{
    /// <summary>
    /// Asynchronously loads items data for the specified edition and version.
    /// </summary>
    /// <returns>A collection of Item objects.</returns>
    public async Task<ItemCollection> LoadItemsAsync()
    {
        var items = await LoadDataAsync<Item[]>("items");
        return new ItemCollection(items);
    }
}
