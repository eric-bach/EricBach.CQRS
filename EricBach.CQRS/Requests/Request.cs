using System;

namespace EricBach.CQRS.Requests
{
    public class Request
    {
        public Guid Id { get; set; }

        public Request(Guid id)
        {
            Id = id;
        }
    }
}
