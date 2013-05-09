using System;
using Cqrs.Net;
namespace Scrum.Commands
{
    public class CreateBacklogItem : Command
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
