using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebAppHomeWorkShared.Enums;
using WebAppHomeWorkShared.ViewModels;

namespace WebAppHomework.Models
{
    public class PersonModel
    {
        public GenderEnums Gender { get; set; }
        [Display(Name = "Gender: ")]
        public string GenderString => Gender.ToString();
        public List<PersonDetailViewModel> Details { get; set; }
    }
}