using System;

namespace EricBach.CQRS.Commands
{
    public class CommandResponse
    {
        public string Name { get; set; }
        public Guid Id { get; set; }
        public string Error { get; set; }
    }
}
