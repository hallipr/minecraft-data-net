using System.Text.Json.Serialization;

namespace MinecraftData;

/// <summary>
/// Extended functionality for the Entity class.
/// </summary>
public partial class Entity
{
    /// <summary>
    /// Gets whether the entity is a hostile mob.
    /// </summary>
    [JsonIgnore]
    public bool IsHostile => 
        Category?.Equals("hostile", StringComparison.OrdinalIgnoreCase) ?? false;
    
    /// <summary>
    /// Gets whether the entity is a passive mob.
    /// </summary>
    [JsonIgnore]
    public bool IsPassive => 
        Category?.Equals("passive", StringComparison.OrdinalIgnoreCase) ?? false;
    
    /// <summary>
    /// Gets whether the entity is a water mob.
    /// </summary>
    [JsonIgnore]
    public bool IsWaterMob => 
        Category?.Equals("water", StringComparison.OrdinalIgnoreCase) ?? false;
    
    /// <summary>
    /// Gets whether the entity is an ambient mob.
    /// </summary>
    [JsonIgnore]
    public bool IsAmbient => 
        Category?.Equals("ambient", StringComparison.OrdinalIgnoreCase) ?? false;
    
    /// <summary>
    /// Gets the bounding box width of the entity, or 0 if not specified.
    /// </summary>
    [JsonIgnore]
    public float BoundingBoxWidth => Width ?? 0;
    
    /// <summary>
    /// Gets the bounding box height of the entity, or 0 if not specified.
    /// </summary>
    [JsonIgnore]
    public float BoundingBoxHeight => Height ?? 0;
    
    /// <summary>
    /// Gets the volume of the entity's bounding box, or 0 if dimensions are not fully specified.
    /// </summary>
    [JsonIgnore]
    public float BoundingBoxVolume => 
        Width.HasValue && Height.HasValue && Length.HasValue
            ? Width.Value * Height.Value * Length.Value
            : 0;
    
    /// <summary>
    /// Returns the display name of the entity.
    /// </summary>
    public override string ToString() => DisplayName;
}
