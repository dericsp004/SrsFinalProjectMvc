using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SoccerRegistrationSystem.Migrations
{
    public partial class DropContact : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Persons",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Persons",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Street",
                table: "Persons",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Zipcode",
                table: "Persons",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "Street",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "Zipcode",
                table: "Persons");

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    City = table.Column<string>(nullable: false),
                    PersonId = table.Column<int>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: false),
                    Street = table.Column<string>(nullable: false),
                    Zipcode = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Contacts_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_PersonId",
                table: "Contacts",
                column: "PersonId",
                unique: true);
        }
    }
}
