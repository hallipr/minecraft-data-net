using MinecraftData;

namespace MinecraftDataTests;

[TestClass]
public sealed class Test1
{
    [TestMethod]
    public async Task TestMethod1()
    {
        var loader = new MinecraftDataLoader("bedrock", "1.21.80");
        var enchantments = await loader.LoadEnchantmentsAsync();
        
        Assert.IsNotNull(enchantments);
    }

    [TestMethod]
    public async Task TestMethod2()
    {
        var loader = new MinecraftDataLoader("bedrock", "1.21.80");
        var data = await loader.LoadAsync();
        var enchantmentCategories = data.Enchantments.Select(x => x.Category).Distinct().ToArray(); 
        var itemEnchantCategories = data.Items.SelectMany(x => x.EnchantCategories ?? []).Distinct().ToArray();

    }
}
