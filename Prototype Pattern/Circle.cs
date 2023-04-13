namespace Week10.Prototype_Pattern;

/// <summary>
/// Concrete prototype implementation 
/// </summary>
public class Circle : ShapePrototype
{
    public int Radius { get; init; }

    public Circle(){}

    private Circle(Circle? target)
    {
        if (target is null) return;
        base.X = target.X;
        base.Y = target.Y;
        base.Color = target.Color;
        Radius = target.Radius;
    }
    public override ShapePrototype Clone()
    {
        return new Circle(this);
    }

    public override bool Equals(object? obj)
    {
        if (obj is not Circle shape2) return false;
        return shape2.Radius == this.Radius;
    }
}