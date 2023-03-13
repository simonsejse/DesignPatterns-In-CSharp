namespace Week10.Observer_Pattern;

public class StockObserver : IObserver
{
    /// <summary>
    /// Tracks the ID of observers.
    /// </summary>
    private static int ObserverIdTracker { get; set; }
    
    private int _observerId;
    private double _ibmPrice;
    private double _aaplPrice;

    /// <summary>
    /// Instantiates a new observer/dependent.
    /// </summary>
    /// <param name="stockGrabber">The subject object/instance to register the observer within.</param>
    public StockObserver(ISubject stockGrabber)
    {
        _observerId = ++ObserverIdTracker;
        stockGrabber.RegisterObserver(this);
        Console.WriteLine($"Created Observer ID: {_observerId}");
    }
    /// <summary>
    /// Updates the stock prices, and prints the new state to the console.
    /// </summary>
    /// <param name="ibmPrice"></param>
    /// <param name="aaplPrice"></param>
    public void Update(double ibmPrice, double aaplPrice)
    {
        _ibmPrice = ibmPrice;
        _aaplPrice = aaplPrice;
        PrintStateToScreen();
    }

    /// <summary>
    /// Prints state to console
    /// </summary>
    private void PrintStateToScreen()
    {
        Console.WriteLine($"Observer {_observerId}: ");
        Console.WriteLine($"IBM Price: {_ibmPrice}");
        Console.WriteLine($"AAPL Price: {_aaplPrice}");
        Console.WriteLine("");
    }
}