namespace Week10.Builder_Pattern.Products;

/// <summary>
/// Represents a product created by the builder
/// </summary>
public class House
{
    public int Space { get; set; }
    public int Walls { get; set; }
    public int Doors { get; set; }
    public int Windows { get; set; }
    public bool HasSwimPool { get; set; }
    public bool HasStatues { get; set; }
    public bool HasGarden { get; set; }
    public Floor? Floor { get; set; }
    public List<Garage>? Garages { get; set; }
    public RoofType? RoofType { get; set; }

    public House(int space, int walls, int doors, int windows, bool hasSwimPool, bool hasStatues, bool hasGarden, Floor? floor, List<Garage>? garages, RoofType? roofType)
    {
        Space = space;
        Walls = walls;
        Doors = doors;
        Windows = windows;
        HasSwimPool = hasSwimPool;
        HasStatues = hasStatues;
        HasGarden = hasGarden;
        Floor = floor;
        Garages = garages;
        RoofType = roofType;
    }
}


