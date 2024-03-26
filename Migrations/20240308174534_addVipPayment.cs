using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Turbo.az.Migrations
{
    /// <inheritdoc />
    public partial class addVipPayment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VipPayment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VipId = table.Column<int>(type: "int", nullable: false),
                    CarId = table.Column<int>(type: "int", nullable: false),
                    isPayed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VipPayment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VipPayment_Vip_VipId",
                        column: x => x.VipId,
                        principalTable: "Vip",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VipPayment_VipId",
                table: "VipPayment",
                column: "VipId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VipPayment");
        }
    }
}
