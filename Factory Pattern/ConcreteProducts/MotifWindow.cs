using Week10.Factory_Pattern.AbstractProducts;

namespace Week10.Factory_Pattern.ConcreteProducts;

public class MotifWindow : IWindow
{
    public void Display()
    {
        Console.WriteLine("I am a Motif Window!");

    }
}