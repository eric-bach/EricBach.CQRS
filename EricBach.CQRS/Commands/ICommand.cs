using System;

namespace EricBach.CQRS.Commands
{
    public interface ICommand
    {
        Guid Id { get; }
    }
}