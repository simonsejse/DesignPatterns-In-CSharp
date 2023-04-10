namespace Week10.EventBus;

public class Notification1 : IEventProcessor<EventType>
{
    
    public void HandleEvent(Event<EventType> @event)
    { 
        Console.WriteLine("Notification 1 | Not Subscribed but target!");
    }
}