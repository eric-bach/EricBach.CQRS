using System;

namespace EricBach.CQRS.Commands
{
    public class Command : ICommand
    {
        public Guid Id { get; private set; }

        public Command(Guid aggregateId)
        {
            Id = aggregateId;
        }
    }
}
