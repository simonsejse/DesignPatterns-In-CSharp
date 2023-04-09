using Week10.Builder_Pattern__House_.Builder;
using Week10.Builder_Pattern.Products;

namespace Week10.Builder_Pattern__House_.Director;

public class HouseDirector
{
    public void ConstructSimpleHouse(IAbstractBuilder builder)
    {
        builder.SetSpace(100);
        builder.SetDoors(4);
        builder.SetFloor(new Floor(100));
        builder.SetWalls(5);
        builder.SetWindows(5);
        builder.SetRoof(RoofType.Flat);
    }

    public void ConstructCastleHouse(IAbstractBuilder builder)
    {
        builder.SetSpace(300);
        builder.SetDoors(20);
        builder.SetWalls(12);
        builder.SetWindows(23);
        builder.SetHasStatues(true);
        builder.SetHasGarden(true);
        builder.SetFloor(new Floor(300));

        builder.SetRoof(RoofType.Castle);
    }

    public void ConstructPalaceHouse(IAbstractBuilder builder)
    {
        builder.SetSpace(500);
        builder.SetDoors(100);
        builder.SetWalls(100);
        builder.SetWindows(200);
        builder.SetHasStatues(true);
        builder.SetHasGarden(true);
        builder.SetHasSwimPool(true);
        builder.SetRoof(RoofType.Pointy);
        builder.SetFloor(new Floor(500));
    }
}