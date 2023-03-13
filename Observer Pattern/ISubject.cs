namespace Week10.Observer_Pattern;

public interface ISubject
{
    void RegisterObserver(IObserver newObserver);
    void UnregisterObserver(IObserver removeObserver);
    void NotifyObservers();
}