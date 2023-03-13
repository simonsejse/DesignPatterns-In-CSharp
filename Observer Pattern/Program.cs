namespace Week10.Observer_Pattern;

public class Program : ITestPattern
{
    public string Name() => "Observer Pattern";
    public void Run()
    {
        var subject = new StockGrabber();
        Console.WriteLine("Subject object instantiated!");
        IObserver observer = new StockObserver(subject);
        
        Console.WriteLine("1. Change IBM State");
        subject.SetIbmPrice(20);
        Console.WriteLine("2. Change AAPL State");
        subject.SetAaplPrice(100);
        
        IObserver secondObserver = new StockObserver(subject);
        Console.WriteLine("1. Change IBM State");
        subject.SetIbmPrice(500);
        Console.WriteLine("2. Change AAPL State");
        subject.SetAaplPrice(1000);
        
        subject.UnregisterObserver(observer);
        Console.WriteLine("1. Change IBM State");
        subject.SetIbmPrice(20);
        Console.WriteLine("2. Change AAPL State");
        subject.SetAaplPrice(100);
        
    }

}