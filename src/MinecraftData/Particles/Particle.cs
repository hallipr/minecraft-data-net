using System.Text.Json.Serialization;

namespace MinecraftData;

/// <summary>
/// Represents a Minecraft particle.
/// </summary>
public class Particle
{
    /// <summary>
    /// The unique identifier for a particle.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    /// <summary>
    /// The name of a particle.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
    
    /// <summary>
    /// Returns the name of the particle.
    /// </summary>
    public override string ToString() => Name;
}
