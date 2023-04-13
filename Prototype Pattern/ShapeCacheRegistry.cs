namespace Week10.Prototype_Pattern;

/// <summary>
/// Prototype registry/factory
/// </summary>
public class ShapeCacheRegistry
{
    private readonly Dictionary<string, ShapePrototype> _cache = new();

    /// <summary>
    /// Initialises dummy data
    /// </summary>
    public ShapeCacheRegistry()
    {
        Circle circle = new()
        {
            X = 6,
            Y = 9,
            Radius = 45,
            Color = "Green"
        };
        Rectangle rectangle = new()
        {
            X = 6,
            Y = 9,
            Color = "Blue",
            Width = 8,
            Height = 10,
        };
        _cache["Big green circle"] = circle;
        _cache["Medium blue rectangle"] = rectangle;
    }
    /// <summary>
    /// Uses indexers to access our _cache dictionary and clone the concrete prototype.
    /// </summary>
    /// <param name="key">The specific key the prototype is mapped to in the dictionary</param>
    public ShapePrototype? this[string key] => _cache[key]?.Clone();
}