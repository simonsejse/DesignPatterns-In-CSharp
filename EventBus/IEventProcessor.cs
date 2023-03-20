namespace Week10.EventBus;

public interface IEventProcessor<in TEvent> where TEvent : Enum
{
    void HandleEvent(TEvent @event);
}