using Cqrs.Net;
using System;

namespace Scrum
{
    public class Sprint: AggregateRoot
    {
        

        public void CommitItem(BacklogItem item)
        { 
            //Do Something ..
        }

        public void DropItem(BacklogItem item)
        {
            //Do Something ..
        }

        private Guid _id;
        public override Guid Id
        {
            get
            {
                return _id;
            }
        }
    }
}
