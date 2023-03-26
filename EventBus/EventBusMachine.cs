namespace Week10.EventBus;

public class EventBusMachine
{
    private static EventBus<EventType>? _eventBus;

    public static EventBus<EventType> GetInstance()
    {
        return _eventBus ??= new EventBus<EventType>();
    }

}