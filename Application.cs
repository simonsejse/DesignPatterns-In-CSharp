﻿namespace Week10;

public class Application
{
    public static void Main(string[] args)
    {
        ITestPattern[] patterns =
        {
            new ClassAdapterPattern.Program(),
            new StrategyDesignPattern.Program(),
            new Observer_Pattern.Program(),
        };
        
        foreach(var pattern in patterns)
        {
            Console.WriteLine($"============== {pattern.Name()} ==============");
            pattern.Run();
            Console.WriteLine("");
        }

    }
}