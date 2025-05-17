namespace MinecraftData;

public partial class MinecraftDataLoader
{
    /// <summary>
    /// Asynchronously loads particles data for the specified edition and version.
    /// </summary>
    /// <returns>A collection of Particle objects.</returns>
    public async Task<ParticleCollection> LoadParticlesAsync()
    {
        var particles = await LoadDataAsync<Particle[]>("particles");
        return new ParticleCollection(particles);
    }
}
