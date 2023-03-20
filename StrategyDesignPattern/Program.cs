using Week10.StrategyDesignPattern.strategies;

namespace Week10.StrategyDesignPattern;

public class Program : ITestPattern
{
    public void Run()
    {
        var defaultDiscountStrategy = new DefaultDiscountStrategy();
        var halfDiscountStrategy = new HalfDiscountStrategy();
        var cart = new Cart(defaultDiscountStrategy);
        Console.WriteLine("A cart was created using the default strategy!");
        cart.AddItem("Basketball", 1, 1000);
        cart.AddItem("Football", 1, 500);
        cart.AddItem("Protein Shake", 1, 20);
        cart.AddItem("Protein Bar", 1, 480);
        Console.WriteLine("Added all items successfully!");
        Console.WriteLine($"Total price using defaultDiscountStrategy: {cart.TotalPrice()}");
        cart.SetStrategy(halfDiscountStrategy);
        Console.WriteLine("Switched to halfDiscountStrategy!");
        Console.WriteLine($"Total price using halfDiscountStrategy: {cart.TotalPrice()}");
    }

    public string Name() => "Strategy Pattern";
}