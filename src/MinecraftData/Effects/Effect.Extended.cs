using System.Text.Json.Serialization;

namespace MinecraftData;

/// <summary>
/// Extended functionality for the Effect class.
/// </summary>
public partial class Effect
{
    /// <summary>
    /// Determines if this is a positive effect.
    /// </summary>
    [JsonIgnore]
    public bool IsPositive => Type.Equals("good", StringComparison.OrdinalIgnoreCase);

    /// <summary>
    /// Determines if this is a negative effect.
    /// </summary>
    [JsonIgnore]
    public bool IsNegative => Type.Equals("bad", StringComparison.OrdinalIgnoreCase);

    /// <summary>
    /// Returns the display name of the effect.
    /// </summary>
    public override string ToString() => DisplayName;
}
