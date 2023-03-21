namespace Week10.EventBus;

public struct Event<T> where T : Enum
{
    public T EventType;
    public IEventProcessor<T> To;
    public string Message;
}