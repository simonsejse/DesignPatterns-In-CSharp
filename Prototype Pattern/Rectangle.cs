namespace Week10.Prototype_Pattern;

/// <summary>
/// Concrete prototype implementation
/// </summary>
public class Rectangle : ShapePrototype
{
    public int Height { get; init; }
    public int Width { get; init; }
    public Rectangle() { }
    
    private Rectangle(Rectangle? target)
    {
        if (target is null) return;
        base.X = target.X;
        base.Y = target.Y;
        base.Color = target.Color;
        Height = target.Height;
        Width = target.Width;
    }
    
    public override ShapePrototype Clone()
    {
        return new Rectangle(this);
    }
    
    public override bool Equals(object? obj)
    {
        if (obj is not Rectangle shape2) return false;
        return shape2.Width == this.Width && shape2.Height == this.Height;
    }
}