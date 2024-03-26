using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Turbo.az.Migrations
{
    /// <inheritdoc />
    public partial class addedUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BackgroundImage",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsSalon",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isBanned",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BackgroundImage",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsSalon",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "isBanned",
                table: "AspNetUsers");
        }
    }
}
