namespace MinecraftData;

public partial class MinecraftDataLoader
{
    /// <summary>
    /// Asynchronously loads enchantments data for the specified edition and version.
    /// </summary>
    /// <returns>A collection of Enchantment objects.</returns>
    public async Task<EnchantmentCollection> LoadEnchantmentsAsync()
    {
        var enchantments = await LoadDataAsync<Enchantment[]>("enchantments");
        return new EnchantmentCollection(enchantments);
    }
}
