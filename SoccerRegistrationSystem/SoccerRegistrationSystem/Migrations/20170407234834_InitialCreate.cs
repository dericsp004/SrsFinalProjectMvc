﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SoccerRegistrationSystem.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BirthDay = table.Column<DateTime>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    MiddleName = table.Column<string>(maxLength: 50, nullable: true),
                    PhoneNumber = table.Column<string>(nullable: false),
                    Street = table.Column<string>(nullable: false),
                    Zipcode = table.Column<string>(nullable: false),
                    ElementarySchool = table.Column<int>(nullable: true),
                    GuardianName = table.Column<string>(maxLength: 50, nullable: true),
                    TeamID = table.Column<int>(nullable: true),
                    YearsExperience = table.Column<int>(nullable: true),
                    Position = table.Column<int>(nullable: true),
                    SubmitBackGroundCheck = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Persons_Teams_TeamID",
                        column: x => x.TeamID,
                        principalTable: "Teams",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Persons_TeamID",
                table: "Persons",
                column: "TeamID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
