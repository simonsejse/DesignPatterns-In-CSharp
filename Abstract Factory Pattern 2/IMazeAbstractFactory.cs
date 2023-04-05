namespace Week10.Abstract_Factory_Pattern_2;

public interface IMazeAbstractFactory
{
    Maze MakeMaze();
    Wall MakeWall();
    Room MakeRoom(int n);
    Door MakeDoor(Room r1, Room r2);
}