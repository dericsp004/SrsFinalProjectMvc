using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace SoccerRegistrationSystem.Models
{
    public enum Elementary
    {
        Adams, Burton, Hibbard, Kennedy, Lincoln, Sugar
    }

    public class Player : Person
    {
        public int YearsExperience { get; set; }
        public Elementary? ElementarySchool { get; set; }

        [Required]
        [StringLength (50, ErrorMessage ="Guardian Name Length cannot be longer than 50 characters")]
        [Display(Name = "Parent/Guardian Full Name")]
        public string GuardianName { get; set; }

    }
}
