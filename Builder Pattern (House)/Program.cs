using Week10.Builder_Pattern__House_.Builder;
using Week10.Builder_Pattern__House_.Director;
using Week10.Builder_Pattern.Products;

namespace Week10.Builder_Pattern__House_;

public class Program : ITestPattern
{
    public string Name() => "Builder pattern";

    public void Run()
    {
        ConcreteHouseBuilder builder = new();
        HouseDirector director = new();
        director.ConstructSimpleHouse(builder);
        
        House simpleHouse = builder.GetResult();
        
        ConcreteHousePrintBuilder printBuilder = new();
        director.ConstructSimpleHouse(printBuilder);

        string simpleHousePrint = printBuilder.Print();
        
        Console.WriteLine(simpleHousePrint);
        
        

    }
}