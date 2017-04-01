using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoccerRegistrationSystem.Models
{
    public class Team
    {
        public int ID { get; set; }
        public string name { get; set; }
        public ICollection<Player> PlayerList { get; set; }
    }
}
