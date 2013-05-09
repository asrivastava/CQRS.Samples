using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using Microsoft.Practices.Unity;
using Cqrs.Net;

namespace Scrum.Web
{
    public class Bootstrapper
    {
        //public UnityContainer Container { get; private set; }
        public void Bootstrap()
        {
            //var bus = new FakeBus();
            
            //Container = new UnityContainer();
            //Container.RegisterInstance<ICommandBus>(bus);

            //var detail = new InvenotryItemDetailView();
            //bus.RegisterHandler<InventoryItemCreated>(detail.Handle);
        }
    }
}