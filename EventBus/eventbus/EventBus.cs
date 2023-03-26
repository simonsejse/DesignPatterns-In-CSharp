using System.Diagnostics.Tracing;

namespace Week10.EventBus;

public class EventBus<TEvent> : IEventBus<TEvent> where TEvent : Enum
{
    private Dictionary<TEvent, ICollection<IEventProcessor<TEvent>>> _eventProcessors { get; set; }
    private Dictionary<TEvent, Queue<Event<TEvent>>> _eventsQueue { get; set; }
    
    public void InitialiseEventBus(ICollection<TEvent> events)
    {
        if (_eventProcessors != null)
            throw new InvalidOperationException("You have to initialise the event bus first!");

        _eventProcessors = new Dictionary<TEvent, ICollection<IEventProcessor<TEvent>>>();
        _eventsQueue = new Dictionary<TEvent, Queue<Event<TEvent>>>();
        
        foreach (var @event in events)
        {
            _eventProcessors.Add(@event, new List<IEventProcessor<TEvent>>());
            _eventsQueue.Add(@event, new Queue<Event<TEvent>>());
        }
    }

    public void Subscribe(TEvent @event, IEventProcessor<TEvent> eventProcessor)
    {
        if (_eventProcessors == default(Dictionary<TEvent, ICollection<IEventProcessor<TEvent>>>))
            throw new InvalidOperationException("You have to initialise the event bus first!");
        
        if (eventProcessor == default(IEventProcessor<TEvent>))
            throw new InvalidOperationException("eventProcessor cannot be null!");

        if (_eventProcessors[@event] == default(ICollection<IEventProcessor<TEvent>>))
            throw new ArgumentNullException(nameof(eventProcessor), "eventProcessor has not been added to the dictionary initialise first!");
        
        _eventProcessors[@event].Add(eventProcessor);
    }

    public void Unsubscribe(TEvent @event, IEventProcessor<TEvent> eventProcessor)
    {
        if (eventProcessor == default(IEventProcessor<TEvent>))
            throw new InvalidOperationException("eventProcessor cannot be null!");

        if (_eventProcessors == default(Dictionary<TEvent, ICollection<IEventProcessor<TEvent>>>))
            throw new InvalidOperationException("You have to initialise the event bus first!");
        
        if (_eventProcessors[@event] == default(ICollection<IEventProcessor<TEvent>>))
            throw new ArgumentNullException(nameof(eventProcessor), "eventProcessor has not been added to the dictionary initialise first!");
        
        _eventProcessors[@event].Remove(eventProcessor);
    }

    public void RegisterEvent(Event<TEvent> anEvent)
    {
        if (_eventsQueue == default(Dictionary<TEvent, Queue<Event<TEvent>>>))
            throw new InvalidOperationException("You have to initialise the event bus first!");
        
        foreach (var @event in anEvent.EventType) _eventsQueue[@event].Enqueue(anEvent);
        ProcessEvents();
    }
    


    public void ProcessEvents()
    {
        if (_eventsQueue == default(Dictionary<TEvent, Queue<Event<TEvent>>>))
            throw new InvalidOperationException("EventsQueue cannot be null!");

        if (_eventProcessors == default(Dictionary<TEvent, ICollection<IEventProcessor<TEvent>>>))
            throw new InvalidOperationException("EventProcessors cannot be null!");

        var eventKeys = _eventsQueue.Keys;

        if (_eventsQueue.Count <= 0) return;

        foreach (var eventType in eventKeys)
        {
            while (_eventsQueue[eventType].Count > 0)
            {
                Event<TEvent> @event = _eventsQueue[eventType].Dequeue();
                if (@event.To is not default(IEventProcessor<TEvent>))
                {
                    @event.To.HandleEvent(@event);
                }
                else //The specific eventProcessor is null, hence go through all subscribed ones in dictionary
                {
                    Console.WriteLine(""+_eventProcessors[eventType].Count);
                    if (_eventProcessors[eventType].Count <= 0) continue;
                    
                    foreach (IEventProcessor<TEvent> eventProcessor in _eventProcessors[eventType])
                    {
                        eventProcessor.HandleEvent(@event);
                    }
                }
            }
        }
    }
}