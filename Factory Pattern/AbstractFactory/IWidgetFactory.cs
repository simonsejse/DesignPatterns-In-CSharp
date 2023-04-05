using Week10.Factory_Pattern.AbstractProducts;

namespace Week10.Factory_Pattern.AbstractFactory;

public interface IWidgetFactory
{
    IScrollBar CreateScrollbar();
    IWindow CreateWindow();
}