using Week10.Factory_Pattern.AbstractProducts;

namespace Week10.Factory_Pattern.ConcreteProducts;

public class PmScrollBar : IScrollBar
{
    public void Display()
    {
        Console.WriteLine("I am Pm ScrollBar");
    }
}