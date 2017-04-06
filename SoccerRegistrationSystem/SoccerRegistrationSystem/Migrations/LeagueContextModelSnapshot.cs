using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using SoccerRegistrationSystem.Data;
using SoccerRegistrationSystem.Models;

namespace SoccerRegistrationSystem.Migrations
{
    [DbContext(typeof(LeagueContext))]
    partial class LeagueContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SoccerRegistrationSystem.Models.Contact", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("PersonId");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("address");

                    b.HasKey("ID");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("SoccerRegistrationSystem.Models.Person", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("BirthDay");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("MiddleName")
                        .HasMaxLength(50);

                    b.HasKey("ID");

                    b.ToTable("Persons");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Person");
                });

            modelBuilder.Entity("SoccerRegistrationSystem.Models.Team", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("name");

                    b.HasKey("ID");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("SoccerRegistrationSystem.Models.Player", b =>
                {
                    b.HasBaseType("SoccerRegistrationSystem.Models.Person");

                    b.Property<int?>("ElementarySchool");

                    b.Property<string>("GuardianName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int?>("TeamID");

                    b.Property<int>("YearsExperience");

                    b.HasIndex("TeamID");

                    b.ToTable("Player");

                    b.HasDiscriminator().HasValue("Player");
                });

            modelBuilder.Entity("SoccerRegistrationSystem.Models.Volunteer", b =>
                {
                    b.HasBaseType("SoccerRegistrationSystem.Models.Person");

                    b.Property<int>("Position");

                    b.Property<bool>("SubmitBackGroundCheck");

                    b.Property<int>("YearsExperience");

                    b.ToTable("Volunteer");

                    b.HasDiscriminator().HasValue("Volunteer");
                });

            modelBuilder.Entity("SoccerRegistrationSystem.Models.Player", b =>
                {
                    b.HasOne("SoccerRegistrationSystem.Models.Team")
                        .WithMany("PlayerList")
                        .HasForeignKey("TeamID");
                });
        }
    }
}
