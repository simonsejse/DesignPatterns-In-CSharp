namespace Week10.Abstract_Factory_Pattern_2;

public class MazeGame
{
    public Maze CreateMaze(MazeFactory factory)
    {
        Maze makeMaze = factory.MakeMaze();
        Room r1 = factory.MakeRoom(5);
        Room r2 = factory.MakeRoom(7);
        Room r3 = factory.MakeRoom(2);
        Door makeDoor = factory.MakeDoor(r1, r3);
        return makeMaze;
    }
}