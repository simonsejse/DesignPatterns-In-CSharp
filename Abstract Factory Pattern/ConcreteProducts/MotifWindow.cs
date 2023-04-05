using Week10.Abstract_Factory_Pattern.AbstractProducts;

namespace Week10.Abstract_Factory_Pattern.ConcreteProducts;

public class MotifWindow : IWindow
{
    public void Display()
    {
        Console.WriteLine("I am a Motif Window!");

    }
}