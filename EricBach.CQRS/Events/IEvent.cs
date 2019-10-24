using System;

namespace EricBach.CQRS.Events
{
    public interface IEvent
    {
        Guid Id { get; }
        int Version { get; set; }
    }
}