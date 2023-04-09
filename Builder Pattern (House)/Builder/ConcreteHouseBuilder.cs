using Week10.Builder_Pattern.Products;

namespace Week10.Builder_Pattern__House_.Builder;

/// <summary>
/// A concrete builder for constructing a house
/// </summary>
public class ConcreteHouseBuilder : IAbstractBuilder
{
    private int _space;
    private int _walls;
    private int _doors;
    private int _windows;
    private bool _hasSwimPool;
    private bool _hasStatues;
    private bool _hasGarden;
    private readonly List<Garage> _garages = new();
    private Floor? _floor;
    private RoofType? _roofType;

    public void SetWalls(int walls)
    {
        _walls = walls;
    }

    public void SetDoors(int doors)
    {
        _doors = doors;
    }

    public void SetWindows(int windows)
    {
        _windows = windows;
    }

    public void SetHasSwimPool(bool has)
    {
        _hasSwimPool = has;
    }

    public void SetHasStatues(bool has)
    {
        _hasStatues = has;
    }

    public void SetHasGarden(bool has)
    {
        _hasGarden = has;
    }

    public void SetFloor(Floor floor)
    {
        _floor = floor;
    }

    public void SetRoof(RoofType roof)
    {
        _roofType = roof;
    }

    public void SetSpace(int space)
    {
        _space = space;
    }
    
    public void AddGarage(Garage garage)
    {
        _garages.Add(garage);
    }

    public House GetResult()
    {
        return new House(_space,
            _walls,
            _doors,
            _windows,
            _hasSwimPool,
            _hasStatues,
            _hasGarden,
            _floor,
            _garages,
            _roofType);
    }
}