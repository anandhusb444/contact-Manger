using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace contact_Manger.Migrations
{
    /// <inheritdoc />
    public partial class Addedtherelationshipwiththeuserandthecontact : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "contacts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_contacts_UserId",
                table: "contacts",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_contacts_users_UserId",
                table: "contacts",
                column: "UserId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_contacts_users_UserId",
                table: "contacts");

            migrationBuilder.DropIndex(
                name: "IX_contacts_UserId",
                table: "contacts");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "contacts");
        }
    }
}
