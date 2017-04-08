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
                    ElementarySchool = Elementary.Lincoln,
                    PhoneNumber = "951-515-2660",
                    Street = "123 1st East",
                    City = "Rexburg",
                    State = "Idaho",
                    Zipcode = "83440"},
                new Player{LastName="McFarlane", FirstName="Andrew",
                    GuardianName = "Mary McFarlane",
                    BirthDay =DateTime.Parse("2009-01-21"), YearsExperience = 1,
                    ElementarySchool = Elementary.Adams,
                    PhoneNumber = "951-515-2660",
                    Street = "123 1st East",
                    City = "Rexburg",
                    State = "Idaho",
                    Zipcode = "83440"},
                new Player{LastName="Carson", FirstName="Alexander",
                    GuardianName = "John Doe",
                    BirthDay =DateTime.Parse("2011-09-01"), YearsExperience = 0,
                    ElementarySchool = Elementary.Lincoln,
                    PhoneNumber = "951-515-2660",
                    Street = "123 1st East",
                    City = "Rexburg",
                    State = "Idaho",
                    Zipcode = "83440"},
                new Player{LastName="Simpson", FirstName="Jessica",
                    GuardianName = "Eric Simpson",
                    BirthDay =DateTime.Parse("2011-07-06"), YearsExperience = 1,
                    ElementarySchool = Elementary.Lincoln,
                    PhoneNumber = "951-515-2660",
                    Street = "123 1st East",
                    City = "Rexburg",
                    State = "Idaho",
                    Zipcode = "83440"}
            };
            foreach (Player p in players)
            {
                context.Players.Add(p);
            }
            context.SaveChanges();

            var volunteers = new Volunteer[]
            {
                new Volunteer{LastName="Plummer",FirstName="Sandra", MiddleName = "Lea",
                    BirthDay =DateTime.Parse("1954-06-15"), YearsExperience = 2,
                    Position = VolunteerPosition.Other,
                    SubmitBackGroundCheck = true,
                    PhoneNumber = "951-515-2660",
                    Street = "123 1st East",
                    City = "Rexburg",
                    State = "Idaho",
                    Zipcode = "83440"},
                new Volunteer{LastName="Wenger",FirstName="Arsene",
                    BirthDay =DateTime.Parse("1950-12-08"), YearsExperience = 30,
                    Position = VolunteerPosition.Coach,
                    SubmitBackGroundCheck = true,
                    PhoneNumber = "951-515-2660",
                    Street = "123 1st East",
                    City = "Rexburg",
                    State = "Idaho",
                    Zipcode = "83440"}
            };

            foreach (Volunteer v in volunteers)
            {
                context.Volunteers.Add(v);
            }
            context.SaveChanges();

        }
    }
}
