using System;

namespace EricBach.CQRS.Events
{
    public class Event : IEvent
    {
        public Guid Id { get; set; }
        public int Version { get; set; }
        public string EventName { get; set; }

        public Event(string eventName)
        {
            EventName = eventName;
        }
    }
}
