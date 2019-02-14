using System;
using System.ComponentModel.DataAnnotations;
//You will need to create an entity / table called HighScore it will have the following fields: HighScoreId, PersonId, Score, and DateAttained
namespace GameWebApp.Domain.Entities
{
    public class HighScore
    {
        public Guid HighScoreId { get; set; }
        public Guid PersonId { get; set; }
        public double Score { get; set; }
        public DateTime DateAttained { get; set; }
    }
}
