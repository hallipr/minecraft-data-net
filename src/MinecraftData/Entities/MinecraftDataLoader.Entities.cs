namespace MinecraftData;

public partial class MinecraftDataLoader
{
    /// <summary>
    /// Asynchronously loads entities data for the specified edition and version.
    /// </summary>
    /// <returns>A collection of Entity objects.</returns>
    public async Task<EntityCollection> LoadEntitiesAsync()
    {
        var entities = await LoadDataAsync<Entity[]>("entities");
        return new EntityCollection(entities);
    }
}
