using System;
using Cqrs.Net;
using Scrum.Commands;

namespace Scrum.CommandHandlers
{
    public class CreateBacklogItemHandler : ICommandHandler<CreateBacklogItem>
    {
        private IRepository<BacklogItem> _repository;
        public CreateBacklogItemHandler(IRepository<BacklogItem> repository)
        {
            _repository = repository;
        }
        public void Handle(CreateBacklogItem command)
        {
            var backlogItem = new BacklogItem(command.ID, command.Name, command.Description);
            _repository.Save(backlogItem, -1);
        }
    }
}
