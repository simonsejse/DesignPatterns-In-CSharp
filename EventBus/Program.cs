namespace Week10.EventBus;

public class Program : ITestPattern
{
    private Notification1 _notification1;
    private Notification2 _notification2;
    
    public string Name() => "EventBus";

    public void Run()
    {
        EventBus<EventType> eventBus = EventBusMachine.GetInstance();
        eventBus.InitialiseEventBus(new List<EventType> { EventType.Message });
        
        _notification1 = new Notification1();
        Event<EventType> onlyNotification1 = new() {
            To = _notification1,
        }; 
        
        _notification2 = new Notification2();
        Event<EventType> bothNotifications = new();
        
        
        eventBus.RegisterEvent(onlyNotification1);
        eventBus.RegisterEvent(bothNotifications);
    }

}