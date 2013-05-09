using Cqrs.Net;
using eScrum.Events;

namespace eScrum.ReadModel
{
    public class BacklogItemCreatedEventHandler: Handles<BacklogItemCreatedEvent>
    {
        public void Handle(BacklogItemCreatedEvent eventData)
        {
            var newItem = new BacklogItemDto {ID = eventData.ID, Name = eventData.Name, Description = eventData.Description };
            DB.BacklogItems.Add(newItem);
        }
    }
}
