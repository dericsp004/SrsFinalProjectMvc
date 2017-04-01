using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoccerRegistrationSystem.Models
{
    public class Contact
    {
        public int ID { get; set; }
        public int PersonId { get; set; }
        public string PhoneNumber { get; set; }
        public string address { get; set; }
    }
}
