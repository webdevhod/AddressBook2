using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AddressBook2.Data.Migrations
{
    public partial class ImageFileAndDateTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Contact",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<byte[]>(
                name: "ImageData",
                table: "Contact",
                type: "bytea",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Modified",
                table: "Contact",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Created",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "ImageData",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "Modified",
                table: "Contact");
        }
    }
}
