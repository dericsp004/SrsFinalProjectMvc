using SoccerRegistrationSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace SoccerRegistrationSystem.Data
{
    public class LeagueContext : DbContext
    {
        public LeagueContext(DbContextOptions<LeagueContext> options) : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Volunteer> Volunteers { get; set; }
        public DbSet<Team> Teams { get; set; }
    }
}