using Week10.Factory_Pattern.AbstractProducts;

namespace Week10.Factory_Pattern.ConcreteProducts;

public class PmWindow : IWindow
{
    public void Display()
    {
        Console.WriteLine("I am a PM Window!");
    }
}