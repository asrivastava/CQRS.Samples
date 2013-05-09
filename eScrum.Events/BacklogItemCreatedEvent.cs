using Cqrs.Net;
using System;

namespace eScrum.Events
{
    public class BacklogItemCreatedEvent: Event
    {
        public BacklogItemCreatedEvent(Guid id, string name, string description)
        {
            ID = id;
            Name = name;
            Description = description;
        }
        public Guid ID { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
    }
}
