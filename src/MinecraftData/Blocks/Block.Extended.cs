using System.Text.Json.Serialization;

namespace MinecraftData;

/// <summary>
/// Extended functionality for the Block class.
/// </summary>
public partial class Block
{
    /// <summary>
    /// Gets whether the block is unbreakable.
    /// </summary>
    [JsonIgnore]
    public bool IsUnbreakable => Hardness == -1 || Hardness == null;
    
    /// <summary>
    /// Gets whether the block is a full block (occupies a full cubic space).
    /// </summary>
    [JsonIgnore]
    public bool IsFullBlock => BoundingBox.Equals("block", StringComparison.OrdinalIgnoreCase);
    
    /// <summary>
    /// Gets whether the block is transparent.
    /// </summary>
    [JsonIgnore]
    public bool IsTransparent => BoundingBox.Equals("empty", StringComparison.OrdinalIgnoreCase);
    
    /// <summary>
    /// Gets whether the block is a solid block.
    /// </summary>
    [JsonIgnore]
    public bool IsSolid => !IsTransparent;
    
    /// <summary>
    /// Gets whether the block requires a tool to harvest.
    /// </summary>
    [JsonIgnore]
    public bool RequiresTool => HarvestTools != null && HarvestTools.Count > 0;
    
    /// <summary>
    /// Gets whether the block has states.
    /// </summary>
    [JsonIgnore]
    public bool HasStates => States != null && States.Length > 0;
    
    /// <summary>
    /// Gets whether the block has variations.
    /// </summary>
    [JsonIgnore]
    public bool HasVariations => Variations != null && Variations.Length > 0;
    
    /// <summary>
    /// Gets whether a specific tool type can harvest this block.
    /// </summary>
    /// <param name="toolId">The tool ID to check.</param>
    /// <returns>True if the tool can harvest this block, false otherwise.</returns>
    public bool CanBeHarvestedWith(int toolId)
    {
        if (HarvestTools == null)
            return true; // No specific tool required
        
        return HarvestTools.ContainsKey(toolId.ToString());
    }
    
    /// <summary>
    /// Returns the display name of the block.
    /// </summary>
    public override string ToString() => DisplayName;
}
