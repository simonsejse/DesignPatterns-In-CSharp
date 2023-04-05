using Week10.Abstract_Factory_Pattern.AbstractProducts;

namespace Week10.Abstract_Factory_Pattern.ConcreteProducts;

public class MotifScrollBar : IScrollBar
{
    public void Display()
    {
        Console.WriteLine("I am Motif scrollbar");
    }
}