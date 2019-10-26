using System;

namespace EricBach.CQRS.Events
{
    public class Event : IEvent
    {
        public Guid Id { get; set; }
        public int Version { get; set; }
        public string EventName { get; set; }
        public int EventVersion { get; set; }
        public DateTime Timestamp { get; set; }

        public Event(string eventName, int eventVersion)
        {
            EventName = eventName;
            EventVersion = eventVersion;
            Timestamp = DateTime.UtcNow;
        }
    }
}
