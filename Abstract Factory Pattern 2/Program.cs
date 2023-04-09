using Week10.Abstract_Factory_Pattern.AbstractProducts;
using Week10.Abstract_Factory_Pattern.ConcreteFactory;

namespace Week10.Abstract_Factory_Pattern_2;

public class Program : ITestPattern
{
    public string Name() => "Abstract Factory Pattern (Widget example)"; 

    public void Run()
    {
        MazeGame mazeGame = new MazeGame();
        var mazeFactory = new MazeFactory();
        Maze maze = mazeGame.CreateMaze(mazeFactory);
    }
}