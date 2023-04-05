namespace Week10.Abstract_Factory_Pattern_2;

public class MazeFactory : IMazeAbstractFactory
{
    public Maze MakeMaze() => new();
    public Wall MakeWall() => new();
    public Room MakeRoom(int n) => new(n);
    public Door MakeDoor(Room r1, Room r2) => new(r1, r2);
}