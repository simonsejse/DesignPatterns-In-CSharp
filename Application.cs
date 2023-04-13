namespace Week10;

public class Application
{
    public static void Main(string[] args)
    {
        ITestPattern[] patterns =
        {
            new ClassAdapterPattern.Program(),
            new StrategyDesignPattern.Program(),
            new Observer_Pattern.Program(),
            new Factory_Pattern.Program(),
            new EventBus.Program(),
            new Builder_Pattern__House_.Program(),
            new Builder_pattern__Pizza_.Program(),
            new Prototype_Pattern.Program()
        };
        
        foreach(var pattern in patterns)
        {
            Console.WriteLine($"============== {pattern.Name()} ==============");
            pattern.Run();
            Console.WriteLine("");
        }

    }
}