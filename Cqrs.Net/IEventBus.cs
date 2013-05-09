using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cqrs.Net
{
    public interface IEventBus
    {
        void Publish<T>(T @event) where T : Event;
    }
}
