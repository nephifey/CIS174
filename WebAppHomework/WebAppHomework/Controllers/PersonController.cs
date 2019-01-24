using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppHomework.Models;
using WebAppHomeWorkShared.Enums;
using WebAppHomeWorkShared.Orchestrators;

namespace WebAppHomework.Controllers
{
    public class PersonController : Controller
    {
        // GET: Course
        public ActionResult Index()
        {
            var personDetailsOrchestrator = new DetailsOrchestrator();

            var personModel = new PersonModel
            {
                Details = personDetailsOrchestrator.GetAllDetails(),
                Gender = GenderEnums.Male
            };

            return View(personModel);
        }
    }
}