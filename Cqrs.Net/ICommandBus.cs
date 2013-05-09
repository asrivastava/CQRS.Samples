using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cqrs.Net
{
    public interface ICommandBus
    {
        void Send<T>(T command) where T : Command;
    }
}
