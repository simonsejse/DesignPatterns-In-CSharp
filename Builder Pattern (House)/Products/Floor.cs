namespace Week10.Builder_Pattern.Products;

/// <summary>
/// Represents a Floor of a House
/// </summary>
public class Floor
{
    public Floor(int space)
    {
        Space = space;
    }

    public int Space { get; }
}