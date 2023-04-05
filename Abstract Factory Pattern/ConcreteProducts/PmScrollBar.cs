using Week10.Abstract_Factory_Pattern.AbstractProducts;

namespace Week10.Abstract_Factory_Pattern.ConcreteProducts;

public class PmScrollBar : IScrollBar
{
    public void Display()
    {
        Console.WriteLine("I am Pm ScrollBar");
    }
}