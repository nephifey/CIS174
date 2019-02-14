using GameWebApp.Domain;
using GameWebApp.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWebApp.Shared.Orchestrators
{
    public class PersonOrchestrator
    {
        private readonly PersonContext _personContext;

        public PersonOrchestrator()
        {
            _personContext = new PersonContext();
        }

        public List<PersonViewModel> GetPeople()
        {
            var people = _personContext.People.Select(x => new PersonViewModel
            {
                FirstName = x.FirstName,
                LastName = x.LastName,
                DateCreated = x.DateCreated
            }).ToList();

            return people;
        }
    }
}
