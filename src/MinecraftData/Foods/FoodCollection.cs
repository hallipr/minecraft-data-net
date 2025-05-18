namespace MinecraftData;

/// <summary>
/// A collection of Minecraft food items.
/// </summary>
public class FoodCollection(Food[] data) : CollectionBase<Food>(data)
{
    /// <summary>
    /// Gets all food items with food points greater than or equal to the specified value.
    /// </summary>
    /// <param name="minFoodPoints">The minimum food points value.</param>
    /// <returns>An enumerable of food items that meet the criteria.</returns>
    public IEnumerable<Food> GetByMinimumFoodPoints(float minFoodPoints) => Items.Where(f => f.FoodPoints >= minFoodPoints);
    
    /// <summary>
    /// Gets all food items with effective quality greater than or equal to the specified value.
    /// </summary>
    /// <param name="minQuality">The minimum effective quality value.</param>
    /// <returns>An enumerable of food items that meet the criteria.</returns>
    public IEnumerable<Food> GetByMinimumQuality(float minQuality) => Items.Where(f => f.EffectiveQuality >= minQuality);
}
