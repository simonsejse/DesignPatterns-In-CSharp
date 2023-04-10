using Week10.Builder_pattern__Pizza_.Builder;
using Week10.Builder_pattern__Pizza_.Director;
using Week10.Builder_pattern__Pizza_.Product;

namespace Week10.Builder_pattern__Pizza_;

public class Program : ITestPattern
{
    public string Name() => "Builder pattern (Pizza)";

    public void Run()
    {
        PizzaDirector director = new PizzaDirector();
        Pizza romagnola = director.ConstructRomagnola(new ConcretePizzaBuilder());
        Pizza adamsSpecial = director.ConstructAdamsSpecial(new ConcretePizzaBuilder());
        
        Console.WriteLine(romagnola);
        Console.WriteLine(adamsSpecial);
    }
}