namespace Week10.EventBus;

public struct Event<TEvent> where TEvent : Enum
{
    public TEvent[] EventType;
    public IEventProcessor<TEvent> To;
    public string Message;
}