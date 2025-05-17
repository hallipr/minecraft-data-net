using System.Text.Json.Serialization;

namespace MinecraftData;

/// <summary>
/// Extended functionality for the EnchantmentCostEquation class.
/// </summary>
public partial class EnchantmentCostEquation
{
    /// <summary>
    /// Calculates the cost for the given level using the equation a * level + b.
    /// </summary>
    /// <param name="level">The level to calculate the cost for.</param>
    /// <returns>The calculated cost.</returns>
    public int Calculate(int level) => A * level + B;
    
    /// <summary>
    /// Returns a string representation of the equation.
    /// </summary>
    /// <returns>A string in the format "a * level + b".</returns>
    public override string ToString() => $"{A} * level + {B}";
}
