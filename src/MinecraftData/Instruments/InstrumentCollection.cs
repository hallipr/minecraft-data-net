namespace MinecraftData;

/// <summary>
/// A collection of Minecraft instruments.
/// </summary>
public class InstrumentCollection
{
    private readonly Dictionary<int, Instrument> _byId = new();
    private readonly Dictionary<string, Instrument> _byName = new(StringComparer.OrdinalIgnoreCase);
    
    /// <summary>
    /// Initializes a new instance of the InstrumentCollection class.
    /// </summary>
    /// <param name="instruments">Array of instruments to include in the collection.</param>
    public InstrumentCollection(Instrument[] instruments)
    {
        Instruments = instruments;
        
        foreach (var instrument in instruments)
        {
            _byId[instrument.Id] = instrument;
            _byName[instrument.Name] = instrument;
        }
    }
    
    /// <summary>
    /// Gets the array of all instruments.
    /// </summary>
    public Instrument[] Instruments { get; }
    
    /// <summary>
    /// Gets the number of instruments in the collection.
    /// </summary>
    public int Count => Instruments.Length;
    
    /// <summary>
    /// Gets an instrument by its ID.
    /// </summary>
    /// <param name="id">The instrument ID.</param>
    /// <returns>The instrument with the specified ID.</returns>
    public Instrument GetById(int id) => _byId.TryGetValue(id, out var instrument) ? instrument : throw new KeyNotFoundException($"Instrument with ID {id} not found");
    
    /// <summary>
    /// Gets an instrument by its name.
    /// </summary>
    /// <param name="name">The instrument name.</param>
    /// <returns>The instrument with the specified name.</returns>
    public Instrument GetByName(string name) => _byName.TryGetValue(name, out var instrument) ? instrument : throw new KeyNotFoundException($"Instrument with name '{name}' not found");
    
    /// <summary>
    /// Indexer to access instruments by ID.
    /// </summary>
    /// <param name="id">The instrument ID.</param>
    /// <returns>The instrument with the specified ID.</returns>
    public Instrument this[int id] => GetById(id);
    
    /// <summary>
    /// Indexer to access instruments by name.
    /// </summary>
    /// <param name="name">The instrument name.</param>
    /// <returns>The instrument with the specified name.</returns>
    public Instrument this[string name] => GetByName(name);
}
