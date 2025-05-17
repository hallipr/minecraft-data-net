namespace MinecraftData;

public partial class MinecraftDataLoader
{
    /// <summary>
    /// Asynchronously loads instruments data for the specified edition and version.
    /// </summary>
    /// <returns>A collection of Instrument objects.</returns>
    public async Task<InstrumentCollection> LoadInstrumentsAsync()
    {
        var instruments = await LoadDataAsync<Instrument[]>("instruments");
        return new InstrumentCollection(instruments);
    }
}
