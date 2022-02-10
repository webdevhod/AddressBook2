using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AddressBook2.Data.Migrations
{
    public partial class ContactInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address1",
                table: "Contact",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Address2",
                table: "Contact",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Contact",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Contact",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Contact",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Contact",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Contact",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Contact",
                type: "character varying(2)",
                maxLength: 2,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ZipCode",
                table: "Contact",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address1",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "Address2",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "ZipCode",
                table: "Contact");
        }
    }
}
