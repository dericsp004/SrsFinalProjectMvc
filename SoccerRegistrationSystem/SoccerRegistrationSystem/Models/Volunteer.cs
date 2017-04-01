using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoccerRegistrationSystem.Models
{
    public enum VolunteerPosition
    {
        Coach, Assistent, Referee, ScoreKeeper, Other
    }
    public class Volunteer : Person
    {
        public bool SubmitBackGroundCheck { get; set; }
        public VolunteerPosition Position { get; set; }
        public int YearsExperience { get; set; }
    }
}
