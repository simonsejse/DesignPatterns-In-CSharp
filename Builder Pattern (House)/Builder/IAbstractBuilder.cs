using Week10.Builder_Pattern.Products;

namespace Week10.Builder_Pattern__House_.Builder;

public interface IAbstractBuilder
{
    void SetWalls(int walls);
    void SetDoors(int doors);
    void SetWindows(int windows);
    void SetHasSwimPool(bool has);
    void SetHasStatues(bool has);
    void SetHasGarden(bool has);
    void AddGarage(Garage garage);
    void SetFloor(Floor floor);
    void SetRoof(RoofType roof);
    void SetSpace(int space);
}