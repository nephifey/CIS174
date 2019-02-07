using System.Collections.Generic;
using WebAppHomeWorkShared.ViewModels;

namespace WebAppHomeWorkShared.Orchestrators.Interfaces
{
    public interface IPersonDetailOrchestrator
    {
        List<PersonDetailViewModel> GetAllDetails();
    }
}
