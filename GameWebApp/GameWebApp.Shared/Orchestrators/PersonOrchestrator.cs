using GameWebApp.Domain;
using GameWebApp.Shared.Orchestrators.Interfaces;
using GameWebApp.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWebApp.Shared.Orchestrators
{
    public class PersonOrchestrator : IPersonOrchestrator
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

        public async Task<bool> UpdateUser(PersonViewModel user)
        {
            System.Diagnostics.Debug.WriteLine(user.PersonId);

            var updateEntity = await _personContext.People.FindAsync(user.PersonId);

            if(updateEntity == null)
            {
                return false;
            }

            updateEntity.FirstName = user.FirstName;
            updateEntity.LastName = user.LastName;
            updateEntity.Email = user.Email;

            await _personContext.SaveChangesAsync();

            return true;
        }
    }
}
