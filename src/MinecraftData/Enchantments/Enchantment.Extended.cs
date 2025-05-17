using System.Text.Json.Serialization;

namespace MinecraftData;

/// <summary>
/// Extended functionality for the Enchantment class.
/// </summary>
public partial class Enchantment
{
    /// <summary>
    /// Calculates the minimum enchantment cost for a specific level.
    /// </summary>
    /// <param name="level">The enchantment level.</param>
    /// <returns>The minimum cost.</returns>
    public int CalculateMinCost(int level) => MinCost.Calculate(level);
    
    /// <summary>
    /// Calculates the maximum enchantment cost for a specific level.
    /// </summary>
    /// <param name="level">The enchantment level.</param>
    /// <returns>The maximum cost.</returns>
    public int CalculateMaxCost(int level) => MaxCost.Calculate(level);
    
    /// <summary>
    /// Checks if this enchantment is incompatible with the specified enchantment name.
    /// </summary>
    /// <param name="enchantmentName">The name of the enchantment to check for incompatibility.</param>
    /// <returns>True if the enchantments are incompatible, otherwise false.</returns>
    public bool IsIncompatibleWith(string enchantmentName)
    {
        return Exclude.Contains(enchantmentName, StringComparer.OrdinalIgnoreCase);
    }
    
    /// <summary>
    /// Gets whether the enchantment is applicable to the specified item category.
    /// </summary>
    /// <param name="itemCategory">The category of the item.</param>
    /// <returns>True if the enchantment can be applied to the item category.</returns>
    public bool IsApplicableTo(string itemCategory)
    {
        // This is a simplification. In reality, the rules for enchantment compatibility are more complex.
        return Category.Equals(itemCategory, StringComparison.OrdinalIgnoreCase) || 
               (Category == "breakable" && !string.IsNullOrEmpty(itemCategory));
    }
    
    /// <summary>
    /// Returns a string that represents the current object.
    /// </summary>
    public override string ToString() => DisplayName;
}
