using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SoccerRegistrationSystem.Models;

namespace SoccerRegistrationSystem.Data
{
    //note
    public class DbInitializer
    {
        public static void Initialize(LeagueContext context)
        {
            context.Database.EnsureCreated();

            // Look for any players
            if (context.Players.Any())
            {
                return;   // DB has been seeded
            }

            var players = new Player[]
            {
                new Player{LastName="Plummer", FirstName="Deric",
                    GuardianName = "Sandra Plummer",
                    BirthDay =DateTime.Parse("2009-04-15"), YearsExperience = 2,
                    ElementarySchool = Elementary.Lincoln},
                new Player{LastName="McFarlane", FirstName="Andrew",
                    GuardianName = "Mary McFarlane",
                    BirthDay =DateTime.Parse("2009-01-21"), YearsExperience = 1,
                    ElementarySchool = Elementary.Adams},
                new Player{LastName="Carson", FirstName="Alexander",
                    GuardianName = "John Doe",
                    BirthDay =DateTime.Parse("2011-09-01"), YearsExperience = 0,
                    ElementarySchool = Elementary.Lincoln},
                new Player{LastName="Simpson", FirstName="Jessica",
                    GuardianName = "Eric Simpson",
                    BirthDay =DateTime.Parse("2011-07-06"), YearsExperience = 1,
                    ElementarySchool = Elementary.Lincoln}
            };
            foreach (Player s in players)
            {
                context.Players.Add(s);
            }
            context.SaveChanges();

            var volunteers = new Volunteer[]
            {
                new Volunteer{LastName="Plummer",FirstName="Sandra", MiddleName = "Lea",
                    BirthDay =DateTime.Parse("1954-06-15"), YearsExperience = 2,
                    Position = VolunteerPosition.Other,
                    SubmitBackGroundCheck = true},
                new Volunteer{LastName="Wenger",FirstName="Arsene",
                    BirthDay =DateTime.Parse("1950-12-08"), YearsExperience = 30,
                    Position = VolunteerPosition.Coach,
                    SubmitBackGroundCheck = true}
            };

            foreach (Volunteer v in volunteers)
            {
                context.Volunteers.Add(v);
            }


            var contactInfo = new Contact[]
            {
                new Contact{PersonId = 1, address = "1926 S Starfire Ave, Rexburg, ID 83440", PhoneNumber = "951-515-2660"},
                new Contact{PersonId = 2, address = "1111 2nd St, Rexburg, ID 83440", PhoneNumber="111-222-3333"},
                new Contact{PersonId = 3, address = "123 1st East, Rexburg, ID 83440", PhoneNumber="111-123-4567"},
                new Contact{PersonId = 4, address = "1926 S Starfire Ave, Rexburg, ID 83440", PhoneNumber = "951-515-2660"},
                new Contact{PersonId = 5, address = "1926 S Starfire Ave, Rexburg, ID 83440", PhoneNumber = "951-515-2660"},
                new Contact{PersonId = 6, address = "1926 S Starfire Ave, Rexburg, ID 83440", PhoneNumber = "951-515-2660"}
            };
            foreach (Contact c in contactInfo)
            {
                context.Contacts.Add(c);
            }

            context.SaveChanges();
        }
    }
}
