using Week10.Abstract_Factory_Pattern.AbstractFactory;
using Week10.Abstract_Factory_Pattern.AbstractProducts;
using Week10.Abstract_Factory_Pattern.ConcreteProducts;

namespace Week10.Abstract_Factory_Pattern.ConcreteFactory;

public class PmWidgetFactory : IWidgetFactory
{
    public IScrollBar CreateScrollbar()
    {
        return new PmScrollBar();
    }

    public IWindow CreateWindow()
    {
        return new PmWindow();
    }
}