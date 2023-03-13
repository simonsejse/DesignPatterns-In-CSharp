namespace Week10.Observer_Pattern;

public class StockGrabber : ISubject
{
    /// <summary>
    /// List of dependents.
    /// </summary>
    private readonly List<IObserver> _observerCollectionList = new();

    private double _ibmPrice;
    private double _aaplPrice;
    
    /// <summary>
    /// Instantiates a new Subject object.
    /// </summary>
    public StockGrabber()
    {
        _ibmPrice = 0;
        _aaplPrice = 0; 
    }
    
    /// <summary>
    /// Attaches or adds a dependent/observer to the collection of observers.
    /// </summary>
    /// <param name="newObserver">The dependent to be added/attached.</param>
    public void RegisterObserver(IObserver newObserver)
    {
        _observerCollectionList.Add(newObserver);
    }
    /// <summary>
    /// Detaches or removes a dependent/observer from the collection of observers.
    /// </summary>
    /// <param name="removeObserver">The dependent/observer to be removed/detached.</param>
    public void UnregisterObserver(IObserver removeObserver)
    {
        int indexOf = _observerCollectionList.IndexOf(removeObserver);
        if (indexOf == -1) return;
        _observerCollectionList.RemoveAt(indexOf);
        Console.WriteLine($"Observer deleted!");
    }
    /// <summary>
    /// Handles notifying observers on state change.
    /// </summary>
    public void NotifyObservers()
    {
        _observerCollectionList.ForEach(observer => observer.Update(_ibmPrice, _aaplPrice));
    }
    
    /// <summary>
    /// Change the state of IBM Stock Price.
    /// Also notifies the observers of state change.
    /// </summary>
    /// <param name="ibmPrice">The new ibmPrice state.</param>
    public void SetIbmPrice(double ibmPrice)
    {
        _ibmPrice = ibmPrice;
        NotifyObservers();
    }
    /// <summary>
    /// Change the state of AAPL Stock Price.
    /// Also notifies the observers of state change.
    /// </summary>
    /// <param name="aaplPrice">The new aaplPrice state.</param>
    public void SetAaplPrice(double aaplPrice)
    {
        _aaplPrice = aaplPrice;
        NotifyObservers();
    }
    
    
    
}