namespace Week10.Abstract_Factory_Pattern_2;

public class Maze
{
    private readonly List<Room> rooms = new();

    void AddRoom(Room room)
    {
        rooms.Add(room);
    }
}