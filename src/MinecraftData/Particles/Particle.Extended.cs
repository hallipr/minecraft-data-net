using System.Text.Json.Serialization;

namespace MinecraftData;

/// <summary>
/// Extended functionality for the Particle class.
/// </summary>
public partial class Particle
{
    /// <summary>
    /// Returns the name of the particle.
    /// </summary>
    public override string ToString() => Name;
}
