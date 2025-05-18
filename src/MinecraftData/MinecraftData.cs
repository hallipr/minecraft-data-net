namespace MinecraftData;

/// <summary>
/// Main entry point for accessing Minecraft data for different editions and versions.
/// </summary>
public class MinecraftData
{
    public BiomeCollection? Biomes { get; init; }
    public BlockCollection? Blocks { get; init; }
    public EffectCollection? Effects { get; init; }
    public EnchantmentCollection? Enchantments { get; init; }
    public EntityCollection? Entities { get; init; }
    public FoodCollection? Foods { get; init; }
    public InstrumentCollection? Instruments { get; init; }
    public ItemCollection? Items { get; init; }
    public MaterialCollection? Materials { get; init; }
    public ParticleCollection? Particles { get; init; }
    public RecipeCollection? Recipes { get; init; }
    public WindowCollection? Windows { get; init; }
}
