using System.Numerics;
using Week10.ClassAdapterPattern;

namespace Week10.EventBus;

public interface IEventBus<TEvent> where TEvent : Enum
{

    /// <summary>
    /// Initialises all TEvent's into the dictionary with empty lists.
    /// </summary>
    /// <param name="events"></param>
    void InitialiseEventBus(ICollection<TEvent> events);
    
    /// <summary>
    /// Subscribes the IEventProcessor to the specified TEvent 
    /// </summary>
    /// <param name="event">The event (the subject)</param>
    /// <param name="eventProcessor">The event processor (the subscriber/dependent)</param>
    void Subscribe(TEvent @event, IEventProcessor<TEvent> eventProcessor);
    
    /// <summary>
    /// Unsubscribes the IEventProcessor to the specified TEvent 
    /// </summary>
    /// <param name="event">The event (the subject)</param>
    /// <param name="eventProcessor">The event processor (the subscriber/dependent)</param>
    void Unsubscribe(TEvent @event, IEventProcessor<TEvent> eventProcessor);
    
   
    void RegisterEvent(TEvent @event, Event<TEvent> anEvent);
}