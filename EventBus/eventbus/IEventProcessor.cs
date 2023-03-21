namespace Week10.EventBus;

public interface IEventProcessor<TEvent> where TEvent : Enum
{
    void HandleEvent(Event<TEvent> @event);
}