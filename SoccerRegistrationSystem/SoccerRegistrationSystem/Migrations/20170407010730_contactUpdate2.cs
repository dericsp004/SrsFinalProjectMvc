using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SoccerRegistrationSystem.Migrations
{
    public partial class contactUpdate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "address",
                table: "Contacts");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Contacts",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Contacts",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Street",
                table: "Contacts",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Zipcode",
                table: "Contacts",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "Street",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "Zipcode",
                table: "Contacts");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Contacts",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "address",
                table: "Contacts",
                nullable: true);
        }
    }
}
