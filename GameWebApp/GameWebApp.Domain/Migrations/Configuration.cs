namespace GameWebApp.Domain.Migrations
{
    using GameWebApp.Domain.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GameWebApp.Domain.PersonContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(GameWebApp.Domain.PersonContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.People.AddOrUpdate(new Person()
            {
                //PersonId, FirstName, LastName, DateCreated, and Email
                PersonId = Guid.Parse("7f2b1f09-7830-4226-bc8e-4b340eb8ea7b"),
                FirstName = "Nathan",
                LastName = "Phifer",
                DateCreated = new DateTime(2019, 02, 12),
                Email = "nephifer@dmacc.edu"
            });

            context.HighScores.AddOrUpdate(new HighScore()
            {
                //HighScoreId, PersonId, Score, and DateAttained
                HighScoreId = Guid.Parse("f243cd8f-8311-45ac-b89f-3eab3ac3e7f4"),
                PersonId = Guid.Parse("7f2b1f09-7830-4226-bc8e-4b340eb8ea7b"),
                Score = 12,
                DateAttained = new DateTime(2001, 05, 21)
            });
        }
    }
}
