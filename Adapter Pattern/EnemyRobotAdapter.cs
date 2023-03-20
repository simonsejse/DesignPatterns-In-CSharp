namespace Week10.ClassAdapterPattern;

public class EnemyRobotAdapter : IEnemyAttacker
{
    
    // Using Composition
    private EnemyRobot _enemyRobot;

    public EnemyRobotAdapter(EnemyRobot enemyRobot)
    {
        _enemyRobot = enemyRobot;
    }
    
    public void FireWeapon()
    {
        _enemyRobot.SmashWithHand();
    }

    public void DriveForward()
    {
        _enemyRobot.WalkForward();
    }

    public void AssignDriver(string driverName)
    {
        _enemyRobot.ReactToHuman(driverName);
    }
}