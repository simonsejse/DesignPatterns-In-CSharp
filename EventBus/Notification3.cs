namespace Week10.EventBus;

public class Notification3 : IEventProcessor<EventType>
{
    public Notification3()
    {
        EventBusMachine.GetInstance().Subscribe(EventType.Alert, this);
    }
    
    public void HandleEvent(Event<EventType> @event)
    {
        Console.WriteLine("Notification 3 | Subscribed to alert!");
    }
}