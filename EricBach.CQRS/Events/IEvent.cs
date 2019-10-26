using System;

namespace EricBach.CQRS.Events
{
    public interface IEvent
    {
        Guid Id { get; }
        int Version { get; set; }
        string  EventName { get; set; }
        int EventVersion { get; set; }
        DateTime Timestamp { get; set; }
    }
}