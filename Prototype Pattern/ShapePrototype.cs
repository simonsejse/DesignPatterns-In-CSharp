namespace Week10.Prototype_Pattern;

/// <summary>
/// Abstract prototype or base prototype that declares the clone method
/// </summary>
public abstract class ShapePrototype
{    
    public int X { get; set; }
    public int Y { get; set; }
    public string? Color { get; set; }

    /// <summary>
    /// Returns a copy of the IShapePrototype object
    /// </summary>
    /// <returns>A copy of the IShapePrototype object</returns>
    public abstract ShapePrototype Clone();
}