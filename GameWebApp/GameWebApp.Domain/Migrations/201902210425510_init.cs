namespace GameWebApp.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                {
                    PersonId = c.String(nullable: false, maxLength: 128),
                    FirstName = c.String(maxLength: 20),
                    LastName = c.String(maxLength: 20),
                    DateCreated = c.DateTime(),
                    Email = c.String(),
                    Phone = c.String(),
                    Gender = c.String(),
                }).PrimaryKey(t => t.PersonId);

            AddForeignKey("dbo.People", "PersonId", "dbo.AspNetUsers", "Id");
        }

        public override void Down()
        {
            DropForeignKey("dbo.People", "PersonId", "dbo.AspNetUsers");
            DropTable("dbo.People");
        }
    }
}
