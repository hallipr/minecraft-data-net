namespace MinecraftData;

/// <summary>
/// Main entry point for accessing Minecraft data for different editions and versions.
/// </summary>
public class MinecraftData : MinecraftDataLoader
{
    /// <summary>
    /// Initializes a new instance of the MinecraftData class for accessing Minecraft data.
    /// </summary>
    /// <param name="edition">The Minecraft edition (e.g., "pc", "bedrock")</param>
    /// <param name="version">The Minecraft version (e.g., "1.21.80", "1.19.2")</param>
    public MinecraftData(string edition, string version) : base(edition, version)
    {
    }
}
