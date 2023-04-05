using Week10.Abstract_Factory_Pattern.AbstractProducts;
using Week10.Abstract_Factory_Pattern.ConcreteFactory;

namespace Week10.Factory_Pattern;

public class Program : ITestPattern
{
    public string Name() => "Abstract Factory Pattern (Widget example)"; 

    public void Run()
    {
        var motifFactory = new MotifWidgetFactory();
        var pmFactory = new PmWidgetFactory();
        
        List<IWindow> windows = new()
        {
            motifFactory.CreateWindow(),
            pmFactory.CreateWindow()
        };
        List<IWindow> scrollbars = new()
        {
            motifFactory.CreateWindow(),
            pmFactory.CreateWindow()
        };
        
        foreach(var scrollbar in scrollbars) scrollbar.Display();
        foreach(var window in windows) window.Display();
    }
}