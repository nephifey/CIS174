using GameWebApp.Shared.Orchestrators;
using GameWebApp.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Api
{
    [Route("api/people")]
    public class PersonApiController : ApiController
    {
        private readonly PersonOrchestrator _personOrchestrator;

        public PersonApiController()
        {
            _personOrchestrator = new PersonOrchestrator();
        }

        [HttpGet]
        public List<PersonViewModel> GetPeople()
        {
            var people = _personOrchestrator.GetPeople();

            return people;
        }
    }
}
