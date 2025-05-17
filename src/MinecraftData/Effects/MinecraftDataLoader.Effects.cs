namespace MinecraftData;

public partial class MinecraftDataLoader
{
    /// <summary>
    /// Asynchronously loads potion effects data for the specified edition and version.
    /// </summary>
    /// <returns>A collection of Effect objects.</returns>
    public async Task<EffectCollection> LoadEffectsAsync()
    {
        var effects = await LoadDataAsync<Effect[]>("effects");
        return new EffectCollection(effects);
    }
}
