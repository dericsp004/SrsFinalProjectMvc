using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SoccerRegistrationSystem.Models
{
    public enum VolunteerPosition
    {
        Coach, Assistant, Referee, ScoreKeeper, Other
    }
    public class Volunteer : Person
    {
        public bool SubmitBackGroundCheck { get; set; }

        public VolunteerPosition Position { get; set; }

        public int YearsExperience { get; set; }

        [Display(Name = "Date Of Birth")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public new DateTime BirthDay { get; set; }

        [Required]
        public new string PhoneNumber { get; set; }

        [Required]
        public new string Street { get; set; }

        [Required]
        public new string City { get; set; }

        [Required]
        public new string State { get; set; }

        [Required]
        public new string Zipcode { get; set; }
    }
}
