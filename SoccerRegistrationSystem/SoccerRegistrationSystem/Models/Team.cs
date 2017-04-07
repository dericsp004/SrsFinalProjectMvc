using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SoccerRegistrationSystem.Models
{
    public class Team
    {
        public Team() { }
        public Team(string name)
        {
            this.name = name;
        }

        public int ID { get; set; }
        [Required]
        [Display(Name ="Team Name")]
        public string name { get; set; }
        public ICollection<Player> PlayerList { get; set; }
    }
}
