using GameWebApp.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWebApp.Shared.Orchestrators.Interfaces
{
    public interface IPersonOrchestrator
    {
        List<PersonViewModel> GetPeople();

        Task<bool> UpdateUser(PersonViewModel user);
    }
}
