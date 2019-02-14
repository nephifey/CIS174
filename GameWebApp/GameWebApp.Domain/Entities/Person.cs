using System;
using System.ComponentModel.DataAnnotations;
//You will need to create an entity / table called Person it will have the following fields: PersonId, FirstName, LastName, DateCreated, and Email
namespace GameWebApp.Domain.Entities
{
    public class Person
    {
        public Guid PersonId { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }

        public DateTime? DateCreated { get; set; }

        [StringLength(50)]
        [EmailAddress]
        public string Email { get; set; }
    }
}
