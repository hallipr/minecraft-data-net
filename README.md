# Minecraft Data .NET

A comprehensive .NET wrapper library for accessing Minecraft game data from the [minecraft-data](https://github.com/PrismarineJS/minecraft-data) repository. This library provides strongly-typed C# objects for various Minecraft data elements, making it easy to work with game data in .NET applications.

## Features

- **Multi-Edition Support**: Access data for both "bedrock" and "pc" (Java) editions
- **Version-Specific Data**: Support for different Minecraft versions
- **Strongly-Typed Objects**: Well-defined C# classes for game elements
- **Async Loading**: Efficient asynchronous data loading
- **Indexed Collections**: Fast lookups by ID, name, or other properties
- **Computation Methods**: Helper methods for calculating enchantment costs and other game mechanics

## Supported Data Types

- **Biomes**: Information about game biomes
- **Blocks**: Comprehensive block data with states and variations
- **Enchantments**: Detailed enchantment information with cost equations
- **Entities**: Data about all game entities
- **Items**: Item properties and metadata

## Installation

Add the MinecraftData library to your project:

```bash
dotnet add package MinecraftData
```

## Quick Start

```csharp
// Initialize with specific edition and version
var minecraft = new MinecraftData("bedrock", "1.19.1");

// Load various data types
var enchantments = await minecraft.LoadEnchantmentsAsync();
var blocks = await minecraft.LoadBlocksAsync();
var items = await minecraft.LoadItemsAsync();
var biomes = await minecraft.LoadBiomesAsync();
var entities = await minecraft.LoadEntitiesAsync();
```

## Detailed Usage

### Enchantments

```csharp
// Initialize the data provider
var minecraft = new MinecraftData("bedrock", "1.19.1");

// Load enchantments data
var enchantments = await minecraft.LoadEnchantmentsAsync();

// Get all enchantments as a collection
IReadOnlyCollection<Enchantment> allEnchantments = enchantments;

// Access by ID
Enchantment respiration = enchantments[6];

// Access by name (case-insensitive)
Enchantment featherFalling = enchantments["feather_falling"];

// Access properties
Console.WriteLine($"Name: {featherFalling.DisplayName}");
Console.WriteLine($"Max Level: {featherFalling.MaxLevel}");
Console.WriteLine($"Category: {featherFalling.Category}");

// Calculate costs for specific levels
int minCost = featherFalling.CalculateMinCost(3);
int maxCost = featherFalling.CalculateMaxCost(3);
```

### Blocks

```csharp
// Load blocks data
var blocks = await minecraft.LoadBlocksAsync();

// Access by ID or name
var stone = blocks["stone"];
var dirt = blocks[3]; // ID for dirt

// Access properties
Console.WriteLine($"Name: {stone.DisplayName}");
Console.WriteLine($"Hardness: {stone.Hardness}");

// Access block states
foreach (var state in stone.States)
{
    Console.WriteLine($"State: {state.Name}, Default: {state.Default}");
}
```

## Project Structure

- **src/MinecraftData**: Main library code
  - **Biomes**: Classes for biome data
  - **Blocks**: Classes for block data
  - **Enchantments**: Classes for enchantment data
  - **Entities**: Classes for entity data
  - **Items**: Classes for item data
- **external/minecraft-data**: Source data from the minecraft-data repository
- **tests/MinecraftDataTests**: Unit tests for the library

## Implementation Details

The MinecraftData library uses a data-driven approach:

1. **Schema-Based Models**: C# models are based on the schema files from minecraft-data
2. **JSON Data**: Original data is preserved in JSON format
3. **Lazy Loading**: Data is loaded only when requested
4. **Efficient Indexing**: Collections are optimized for quick lookups

## Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

1. Fork the repository
2. Create your feature branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes (`git commit -m 'Add some amazing feature'`)
4. Push to the branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request

## License

This project is licensed under the MIT License - see the LICENSE file for details.

## Acknowledgments

- [minecraft-data](https://github.com/PrismarineJS/minecraft-data) project for providing the original data
- Minecraft and Mojang for creating the game
