using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class UpdateUserModel
    {
        public Guid PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; } 
        public string Gender { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }
    }
}