namespace Week10.EventBus;

public class Notification2 : IEventProcessor<EventType>
{
    public Notification2()
    {
        EventBusMachine.GetInstance().Subscribe(EventType.Message, this);
    }
    
    public void HandleEvent(Event<EventType> @event)
    {
        Console.WriteLine("Notification 2 | Subscribed!");
    }
}