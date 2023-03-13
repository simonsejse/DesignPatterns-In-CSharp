namespace Week10.ClassAdapterPattern;

public class Program : ITestPattern
{
    public void Run()
    {
        IEnemyAttacker enemyTank = new EnemyTank();
        var enemyRobot = new EnemyRobot();

        IEnemyAttacker enemyRobotAdapter = new EnemyRobotAdapter(enemyRobot);

        Console.WriteLine("--------------- The Robot ---------------");
        enemyRobotAdapter.DriveForward();
        enemyRobotAdapter.FireWeapon();
        enemyRobotAdapter.AssignDriver("John")
            ;
        Console.WriteLine("--------------- The Enemy Tank ---------------");
        enemyTank.DriveForward();
        enemyTank.FireWeapon();
        enemyTank.AssignDriver("Benja");
    }

    public string Name() => "Adapter Pattern";
}