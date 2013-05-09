using System;
using System.Web.Mvc;
using Cqrs.Net;
using eScrum.ReadModel;
using Scrum.Commands;

namespace Scrum.Web.Controllers
{
    public class BacklogItemController : Controller
    {
        private ICommandBus CommandBus
        {
            get
            {
                return ServiceLocator.CommandBus;
            }
        }

        public ActionResult Index()
        {
            var readRepository = new Repository();
            var backlogItemList = readRepository.GetAllBacklogItem();
            return View(backlogItemList);
        }
        
        public ActionResult Create()
        {
            return View();
        } 

        [HttpPost]
        public ActionResult Create(CreateBacklogItem command)
        {
            try
            {
                command.ID = Guid.NewGuid();
                CommandBus.Send<CreateBacklogItem>(command);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Point(Guid id)
        {
            return View();
        }
    }
}
