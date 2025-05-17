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

// Asynchronously load enchantments data
var enchantments = await minecraft.LoadEnchantmentsAsync();

// Access all enchantments
IReadOnlyCollection<Enchantment> allEnchantments = enchantments;
Console.WriteLine($"Found {allEnchantments.Count} enchantments");

// Access by index (ID)
Enchantment respiration = enchantments[6]; // Get enchantment with ID 6
Console.WriteLine($"Enchantment ID 6: {respiration.DisplayName}");

// Access by name (case-insensitive)
Enchantment featherFalling = enchantments["feather_falling"];
Console.WriteLine($"Feather Falling max level: {featherFalling.MaxLevel}");

// Check enchantment properties
if (featherFalling.TreasureOnly)
{
    Console.WriteLine($"{featherFalling.DisplayName} is a treasure enchantment");
}

// Calculate enchantment costs
int minCost = respiration.CalculateMinCost(3); // Cost for level 3
Console.WriteLine($"{respiration.DisplayName} level 3 min cost: {minCost}");
```

## Implementation Details

The MinecraftData library uses source generators to create the model classes at compile time, based on the schema files from the minecraft-data repository. This ensures that the library stays in sync with the data format and allows for easy updates when new versions are released.

The library also copies the JSON data files as content, making them available at runtime for deserialization.
