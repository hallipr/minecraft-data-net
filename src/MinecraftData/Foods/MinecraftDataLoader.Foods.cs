
namespace MinecraftData;

public partial class MinecraftDataLoader
{
    /// <summary>
    /// Asynchronously loads food items data for the specified edition and version.
    /// </summary>
    /// <returns>A collection of Food objects.</returns>
    public async Task<FoodCollection> LoadFoodsAsync()
    {
        var foods = await LoadDataAsync<Food[]>("foods");
        return new FoodCollection(foods);
    }
}
