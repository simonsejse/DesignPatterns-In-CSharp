using System;

namespace Week10.ClassAdapterPattern;

public class EnemyRobot
{
    private Random generator = new Random();

    public void SmashWithHand()
    {        
        int attackDamage = generator.Next(10) + 1;
        Console.WriteLine($"Enemy Robot Causes {attackDamage} damage with it's hands!");
    }

    public void WalkForward()
    {
        int movement = generator.Next(5) + 1;
        Console.WriteLine($"Enemy Robot Walks Forward {movement} Spaces!");
    }

    public void ReactToHuman(string driverName)
    {
        Console.WriteLine($"Enemy Robot Tramps on {driverName}");
    }
    
}