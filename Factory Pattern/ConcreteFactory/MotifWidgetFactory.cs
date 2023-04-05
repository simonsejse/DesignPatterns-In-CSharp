using Week10.Factory_Pattern.AbstractFactory;
using Week10.Factory_Pattern.AbstractProducts;
using Week10.Factory_Pattern.ConcreteProducts;

namespace Week10.Factory_Pattern.ConcreteFactory;


public class MotifWidgetFactory : IWidgetFactory
{
    public IScrollBar CreateScrollbar()
    {
        return new MotifScrollBar();
    }

    public IWindow CreateWindow()
    {
        return new MotifWindow();
    }
}