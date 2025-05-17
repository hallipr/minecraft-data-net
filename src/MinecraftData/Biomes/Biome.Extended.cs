using System.Text.Json.Serialization;
using System.Drawing;

namespace MinecraftData;

/// <summary>
/// Extended functionality for the Biome class.
/// </summary>
public partial class Biome
{
    /// <summary>
    /// Gets whether the biome has any precipitation (modern or legacy property).
    /// </summary>
    [JsonIgnore]
    public bool HasAnyPrecipitation => 
        HasPrecipitation.HasValue ? HasPrecipitation.Value : 
        !string.IsNullOrEmpty(Precipitation) && !Precipitation.Equals("none", StringComparison.OrdinalIgnoreCase);
    
    /// <summary>
    /// Gets whether the biome has snow precipitation.
    /// </summary>
    [JsonIgnore]
    public bool HasSnow => 
        Precipitation?.Equals("snow", StringComparison.OrdinalIgnoreCase) ?? false;
    
    /// <summary>
    /// Gets whether the biome has rain precipitation.
    /// </summary>
    [JsonIgnore]
    public bool HasRain => 
        Precipitation?.Equals("rain", StringComparison.OrdinalIgnoreCase) ?? false;
    
    /// <summary>
    /// Gets whether the biome is in the Overworld dimension.
    /// </summary>
    [JsonIgnore]
    public bool IsOverworld => Dimension.Equals("overworld", StringComparison.OrdinalIgnoreCase);
    
    /// <summary>
    /// Gets whether the biome is in the Nether dimension.
    /// </summary>
    [JsonIgnore]
    public bool IsNether => Dimension.Equals("nether", StringComparison.OrdinalIgnoreCase);
    
    /// <summary>
    /// Gets whether the biome is in the End dimension.
    /// </summary>
    [JsonIgnore]
    public bool IsEnd => Dimension.Equals("end", StringComparison.OrdinalIgnoreCase);
    
    /// <summary>
    /// Gets the biome's color as a System.Drawing.Color.
    /// </summary>
    [JsonIgnore]
    public Color ColorValue => Color.FromArgb(this.Color);
    
    /// <summary>
    /// Gets the biome's color as a hex string.
    /// </summary>
    [JsonIgnore]
    public string ColorHex => $"#{this.Color:X6}";
    
    /// <summary>
    /// Returns the display name of the biome.
    /// </summary>
    public override string ToString() => DisplayName;
}
