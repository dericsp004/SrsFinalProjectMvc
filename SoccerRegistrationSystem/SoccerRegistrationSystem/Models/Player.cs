using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace SoccerRegistrationSystem.Models
{
    public enum Position
    {
        NoPreference, Forward, Midfield, Defense, GoalKeeper
    }

    public class Player : Person
    {
        public int YearsExperience { get; set; }
        public Position? PreferredPosition { get; set; }
        [Required]
        [StringLength (100, ErrorMessage ="Guardian Name Length cannot be longer than 100 characters")]
        [Display(Name = "Parent/Guardian Name")]
        public string GuardianName { get; set; }

    }
}
