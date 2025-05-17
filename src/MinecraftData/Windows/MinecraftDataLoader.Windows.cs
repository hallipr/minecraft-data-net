namespace MinecraftData;

public partial class MinecraftDataLoader
{
    /// <summary>
    /// Asynchronously loads windows/GUI screens data for the specified edition and version.
    /// </summary>
    /// <returns>A collection of Window objects.</returns>
    public async Task<WindowCollection> LoadWindowsAsync()
    {
        var windows = await LoadDataAsync<Window[]>("windows");
        return new WindowCollection(windows);
    }
}
