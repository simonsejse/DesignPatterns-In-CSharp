namespace Week10.EventBus;

public struct Event<T> where T : Enum
{ 
    public IEventProcessor<T> To;
}