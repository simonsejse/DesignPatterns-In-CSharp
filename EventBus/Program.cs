namespace Week10.EventBus;

public class Program : ITestPattern
{
    private Notification1 _notification1;
    private Notification2 _notification2;
    private Notification3 _notification3;
    
    public string Name() => "EventBus";

    public void Run()
    {
        EventBus<EventType> eventBus = EventBusMachine.GetInstance();
        eventBus.InitialiseEventBus(new List<EventType> { EventType.Message, EventType.Alert});
        
        _notification1 = new Notification1();
        Event<EventType> onlyNotification1 = new() {
            To = _notification1,
        }; 
        
        _notification2 = new Notification2();
        Event<EventType> onlyMessage = new()
        {
            EventType = new []
            {
                EventType.Message
            }
        };
        
        _notification3 = new Notification3();
        Event<EventType> onlyAlert = new()
        {
            EventType = new [] { EventType.Alert }
        };

        Event<EventType> all = new()
        {
            EventType = new [] 
            {
                EventType.Alert,
                EventType.Message
            }
        };

        eventBus.RegisterEvent(onlyNotification1);
        eventBus.RegisterEvent(onlyMessage);
        eventBus.RegisterEvent(onlyAlert);
        Console.WriteLine("---");
        eventBus.RegisterEvent(all);
    }

}