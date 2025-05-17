# MinecraftData Library Wrapper

This library provides a .NET wrapper for the `minecraft-data` repository, giving you easy access to Minecraft game data in your C# applications.

## Features

- Access Minecraft data for both "bedrock" and "pc" (Java) editions
- Support for different game versions
- Strongly-typed C# objects for game items, blocks, entities, enchantments, etc.
- Generated from schemas for data consistency

## Usage Example

```csharp
// Initialize with specific edition and version
var minecraft = new MinecraftData("bedrock", "1.19.1");

// Load different types of data
var enchantments = await minecraft.LoadEnchantmentsAsync();
var blocks = await minecraft.LoadBlocksAsync();
var items = await minecraft.LoadItemsAsync();
var biomes = await minecraft.LoadBiomesAsync();
var entities = await minecraft.LoadEntitiesAsync();
var effects = await minecraft.LoadEffectsAsync();
var foods = await minecraft.LoadFoodsAsync();
var instruments = await minecraft.LoadInstrumentsAsync();
var materials = await minecraft.LoadMaterialsAsync();
var particles = await minecraft.LoadParticlesAsync();
var recipes = await minecraft.LoadRecipesAsync();
var windows = await minecraft.LoadWindowsAsync();

// Working with enchantments
Console.WriteLine($"Found {enchantments.Count} enchantments");

// Access by index (ID)
Enchantment respiration = enchantments[6]; // Get enchantment with ID 6
Console.WriteLine($"Enchantment ID 6: {respiration.DisplayName}");

// Access by name (case-insensitive)
Enchantment featherFalling = enchantments["feather_falling"];
Console.WriteLine($"Feather Falling max level: {featherFalling.MaxLevel}");

// Working with blocks
var stone = blocks["stone"];
Console.WriteLine($"Stone hardness: {stone.Hardness}");

// Working with food items
var goldenApple = foods["golden_apple"];
Console.WriteLine($"Golden Apple food points: {goldenApple.FoodPoints}, saturation: {goldenApple.Saturation}");

// Working with effects
var speedEffect = effects["speed"];
Console.WriteLine($"Speed effect is positive: {speedEffect.IsPositive}");

// Working with recipes
var recipesByResult = recipes[1]; // Get recipes for item with ID 1
Console.WriteLine($"Found {recipesByResult.Count} recipes for item ID 1");

// Working with windows
var inventoryWindow = windows["inventory"];
Console.WriteLine($"Inventory window has {inventoryWindow.Slots?.Length ?? 0} slot definitions");
```

## Implementation Details

The MinecraftData library uses source generators to create the model classes at compile time, based on the schema files from the minecraft-data repository. This ensures that the library stays in sync with the data format and allows for easy updates when new versions are released.

The library also copies the JSON data files as content, making them available at runtime for deserialization.
