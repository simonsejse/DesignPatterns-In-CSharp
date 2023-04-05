using Week10.Abstract_Factory_Pattern.AbstractProducts;

namespace Week10.Abstract_Factory_Pattern.AbstractFactory;

public interface IWidgetFactory
{
    IScrollBar CreateScrollbar();
    IWindow CreateWindow();
}