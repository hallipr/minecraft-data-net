namespace MinecraftData;

/// <summary>
/// A collection of Minecraft food items.
/// </summary>
public class FoodCollection
{
    private readonly Dictionary<int, Food> _byId = new();
    private readonly Dictionary<string, Food> _byName = new(StringComparer.OrdinalIgnoreCase);
    
    /// <summary>
    /// Initializes a new instance of the FoodCollection class.
    /// </summary>
    /// <param name="foods">Array of food items to include in the collection.</param>
    public FoodCollection(Food[] foods)
    {
        Foods = foods;
        
        foreach (var food in foods)
        {
            _byId[food.Id] = food;
            _byName[food.Name] = food;
        }
    }
    
    /// <summary>
    /// Gets the array of all food items.
    /// </summary>
    public Food[] Foods { get; }
    
    /// <summary>
    /// Gets the number of food items in the collection.
    /// </summary>
    public int Count => Foods.Length;
    
    /// <summary>
    /// Gets a food item by its ID.
    /// </summary>
    /// <param name="id">The food item ID.</param>
    /// <returns>The food item with the specified ID.</returns>
    public Food GetById(int id) => _byId.TryGetValue(id, out var food) ? food : throw new KeyNotFoundException($"Food with ID {id} not found");
    
    /// <summary>
    /// Gets a food item by its name.
    /// </summary>
    /// <param name="name">The food item name.</param>
    /// <returns>The food item with the specified name.</returns>
    public Food GetByName(string name) => _byName.TryGetValue(name, out var food) ? food : throw new KeyNotFoundException($"Food with name '{name}' not found");
    
    /// <summary>
    /// Gets all food items with food points greater than or equal to the specified value.
    /// </summary>
    /// <param name="minFoodPoints">The minimum food points value.</param>
    /// <returns>An enumerable of food items that meet the criteria.</returns>
    public IEnumerable<Food> GetByMinimumFoodPoints(float minFoodPoints) => 
        Foods.Where(f => f.FoodPoints >= minFoodPoints);
    
    /// <summary>
    /// Gets all food items with effective quality greater than or equal to the specified value.
    /// </summary>
    /// <param name="minQuality">The minimum effective quality value.</param>
    /// <returns>An enumerable of food items that meet the criteria.</returns>
    public IEnumerable<Food> GetByMinimumQuality(float minQuality) => 
        Foods.Where(f => f.EffectiveQuality >= minQuality);
    
    /// <summary>
    /// Indexer to access food items by ID.
    /// </summary>
    /// <param name="id">The food item ID.</param>
    /// <returns>The food item with the specified ID.</returns>
    public Food this[int id] => GetById(id);
    
    /// <summary>
    /// Indexer to access food items by name.
    /// </summary>
    /// <param name="name">The food item name.</param>
    /// <returns>The food item with the specified name.</returns>
    public Food this[string name] => GetByName(name);
}
