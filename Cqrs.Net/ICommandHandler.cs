using System;
using System.Collections.Generic;

namespace Cqrs.Net
{
    public interface ICommandHandler<T> where T : Command
    {
        void Handle(T command);
    }

    //public abstract class CommandHandler<T> where T : Command
    //{
    //    public CommandHandler()
    //    {
    //        var storage = new EventStore(new FakeBus());
    //        Repository = new Repository<T>(storage);      
    //    }
    //    protected IRepository<T> Repository { get; private set; }
    //    public abstract void Handle(T command);
    //}
}
