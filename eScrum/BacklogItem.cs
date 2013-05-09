
using Cqrs.Net;
using System;
using eScrum.Events;

namespace Scrum
{
    public class BacklogItem: AggregateRoot
    {
        private Guid _id;
        private string _name;
        private int _point;
        private string _description;

        public BacklogItem()
        {

        }
        public BacklogItem(Guid id, string name, string description)
        {
            var @event = new BacklogItemCreatedEvent(id, name, description);
            ApplyChange(@event);
        }

        
        public override Guid Id
        {
            get
            {
                return _id;
            }
        }

        public string Name 
        {
            set
            {
                _name = value;
            }
        }

        public int Point 
        {
            set
            {
                _point = value;
            }
        }

        private void Apply(BacklogItemCreatedEvent e)
        {
            _id = e.ID;
            _name = e.Name;
            _description = e.Description;
        }
    }
}
