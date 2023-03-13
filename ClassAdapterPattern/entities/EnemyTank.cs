using System;

namespace Week10.ClassAdapterPattern;

public class EnemyTank : IEnemyAttacker
{
    private Random generator = new Random();
    
    public void FireWeapon()
    {
        int attackDamage = generator.Next(10) + 1; //random value (0-inf) + 1
        Console.WriteLine($"Enemy Tank Does {attackDamage} damage!");
    }

    public void DriveForward()
    {
        int movement = generator.Next(5) + 1;
        Console.WriteLine($"Enemy Tank Moves Forward {movement} spaces!");
    }

    public void AssignDriver(string driverName)
    {
        Console.WriteLine($"{driverName} has been assigned as a driver!");
    }
}