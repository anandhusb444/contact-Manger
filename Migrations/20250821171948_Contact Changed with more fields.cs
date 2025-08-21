using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace contact_Manger.Migrations
{
    /// <inheritdoc />
    public partial class ContactChangedwithmorefields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "contacts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "DOB",
                table: "contacts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Remark",
                table: "contacts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "contacts");

            migrationBuilder.DropColumn(
                name: "DOB",
                table: "contacts");

            migrationBuilder.DropColumn(
                name: "Remark",
                table: "contacts");
        }
    }
}
