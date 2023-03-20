using System.Diagnostics.Contracts;

namespace Week10.State_Pattern;

public class Program : ITestPattern
{
    public string Name() => "State Pattern";
    public void Run()
    {
        Console.WriteLine("Hello, World!");
    }


    public void Add(int a, int b)
    {
        Contract.Requires<ArgumentException>(a > 0);
        Contract.Requires<ArgumentException>(b > 0);
        
    }

}