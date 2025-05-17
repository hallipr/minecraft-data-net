using System.Text.Json.Serialization;

namespace MinecraftData;

/// <summary>
/// Extended functionality for the RecipeItem class.
/// </summary>
public partial class RecipeItem
{
    /// <summary>
    /// Creates a new recipe item from an ID.
    /// </summary>
    /// <param name="id">The item ID.</param>
    /// <returns>A new recipe item.</returns>
    public static RecipeItem FromId(int id) => new RecipeItem { Id = id };
    
    /// <summary>
    /// Creates a new recipe item from ID, metadata, and count.
    /// </summary>
    /// <param name="id">The item ID.</param>
    /// <param name="metadata">The item metadata.</param>
    /// <param name="count">The item count.</param>
    /// <returns>A new recipe item.</returns>
    public static RecipeItem Create(int id, int metadata = 0, int count = 1) =>
        new RecipeItem { Id = id, Metadata = metadata, Count = count };
    
    /// <summary>
    /// Returns a string representation of the recipe item.
    /// </summary>
    public override string ToString()
    {
        string result = $"Item {Id}";
        
        if (Metadata.HasValue)
        {
            result += $":{Metadata.Value}";
        }
        
        if (Count.HasValue && Count.Value != 1)
        {
            result += $" x{Count.Value}";
        }
        
        return result;
    }
}
