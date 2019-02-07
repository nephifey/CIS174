using System.Collections.Generic;
using WebAppHomeWorkShared.Orchestrators.Interfaces;
using WebAppHomeWorkShared.ViewModels;

namespace WebAppHomeWorkShared.Orchestrators
{
    public class DetailsOrchestrator : IPersonDetailOrchestrator
    {
        public List<PersonDetailViewModel> GetAllDetails()
        {
            var details = new List<PersonDetailViewModel>
            {
                new PersonDetailViewModel
                {
                    FirstName = "Nathan",
                    LastName = "Phifer",
                    Age = 19,
                    Major = "Web Development"
                }, 
                new PersonDetailViewModel
                {
                    FirstName = "Jake",
                    LastName = "Hutching",
                    Age = 21,
                    Major = "Computer Science"
                }
            };
            return details;
        }
    }
}
