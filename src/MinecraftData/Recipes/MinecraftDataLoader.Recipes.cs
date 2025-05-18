using System.Text.Json;

namespace MinecraftData;

public partial class MinecraftDataLoader
{
    /// <summary>
    /// Asynchronously loads recipes data for the specified edition and version.
    /// </summary>
    /// <returns>A collection of Recipe objects.</returns>
    public async Task<RecipeCollection> LoadRecipesAsync()
    {
        using var stream = GetDataStream("recipes", out string _);
        var document = await JsonDocument.ParseAsync(stream);
        return new RecipeCollection(document);
    }
}
