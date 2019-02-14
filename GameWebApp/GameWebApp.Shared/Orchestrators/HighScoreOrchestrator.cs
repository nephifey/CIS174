using GameWebApp.Domain;
using GameWebApp.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWebApp.Shared.Orchestrators
{
    public class HighScoreOrchestrator
    {
        private readonly PersonContext _personContext;

        public HighScoreOrchestrator()
        {
            _personContext = new PersonContext();
        }

        public List<HighScoreViewModel> GetScores()
        {
            var scores = _personContext.HighScores.Select(x => new HighScoreViewModel
            {
                Score = x.Score,
                DateAttained = x.DateAttained
            }).ToList();

            return scores;
        }
    }
}
