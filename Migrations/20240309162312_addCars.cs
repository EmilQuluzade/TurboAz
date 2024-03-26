using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Turbo.az.Migrations
{
    /// <inheritdoc />
    public partial class addCars : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    ModelId = table.Column<int>(type: "int", nullable: false),
                    YearId = table.Column<int>(type: "int", nullable: false),
                    MilAge = table.Column<int>(type: "int", nullable: false),
                    UnitOfLenghtId = table.Column<int>(type: "int", nullable: false),
                    ColorId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    CurrencyId = table.Column<int>(type: "int", nullable: false),
                    OwnershipId = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    SitsId = table.Column<int>(type: "int", nullable: false),
                    FuelId = table.Column<int>(type: "int", nullable: false),
                    TransmitternId = table.Column<int>(type: "int", nullable: false),
                    TransmitterId = table.Column<int>(type: "int", nullable: false),
                    GearboxId = table.Column<int>(type: "int", nullable: false),
                    EngineCapacityId = table.Column<int>(type: "int", nullable: false),
                    EnginePower = table.Column<int>(type: "int", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    Credit = table.Column<bool>(type: "bit", nullable: false),
                    Barter = table.Column<bool>(type: "bit", nullable: false),
                    VinCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoreInfo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EquipmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cars_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_Colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_Currency_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currency",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_EngineCapacity_EngineCapacityId",
                        column: x => x.EngineCapacityId,
                        principalTable: "EngineCapacity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_Fuel_FuelId",
                        column: x => x.FuelId,
                        principalTable: "Fuel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_Gearbox_GearboxId",
                        column: x => x.GearboxId,
                        principalTable: "Gearbox",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_Models_ModelId",
                        column: x => x.ModelId,
                        principalTable: "Models",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_Ownership_OwnershipId",
                        column: x => x.OwnershipId,
                        principalTable: "Ownership",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_Sits_SitsId",
                        column: x => x.SitsId,
                        principalTable: "Sits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_Transmitter_TransmitterId",
                        column: x => x.TransmitterId,
                        principalTable: "Transmitter",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_Unitoflength_UnitOfLenghtId",
                        column: x => x.UnitOfLenghtId,
                        principalTable: "Unitoflength",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_Year_YearId",
                        column: x => x.YearId,
                        principalTable: "Year",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EquipmentCar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarId = table.Column<int>(type: "int", nullable: false),
                    EquipmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentCar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EquipmentCar_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EquipmentCar_Equipment_EquipmentId",
                        column: x => x.EquipmentId,
                        principalTable: "Equipment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VipPayment_CarId",
                table: "VipPayment",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_PremiumPayment_CarId",
                table: "PremiumPayment",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Image_CarId",
                table: "Image",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_CarId",
                table: "Comment",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CityId",
                table: "Cars",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_ColorId",
                table: "Cars",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CountryId",
                table: "Cars",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CurrencyId",
                table: "Cars",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_EngineCapacityId",
                table: "Cars",
                column: "EngineCapacityId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_FuelId",
                table: "Cars",
                column: "FuelId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_GearboxId",
                table: "Cars",
                column: "GearboxId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_ModelId",
                table: "Cars",
                column: "ModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_OwnershipId",
                table: "Cars",
                column: "OwnershipId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_SitsId",
                table: "Cars",
                column: "SitsId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_StatusId",
                table: "Cars",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_TransmitterId",
                table: "Cars",
                column: "TransmitterId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_UnitOfLenghtId",
                table: "Cars",
                column: "UnitOfLenghtId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_UserId",
                table: "Cars",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_YearId",
                table: "Cars",
                column: "YearId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentCar_CarId",
                table: "EquipmentCar",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentCar_EquipmentId",
                table: "EquipmentCar",
                column: "EquipmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Cars_CarId",
                table: "Comment",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Image_Cars_CarId",
                table: "Image",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PremiumPayment_Cars_CarId",
                table: "PremiumPayment",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VipPayment_Cars_CarId",
                table: "VipPayment",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Cars_CarId",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_Image_Cars_CarId",
                table: "Image");

            migrationBuilder.DropForeignKey(
                name: "FK_PremiumPayment_Cars_CarId",
                table: "PremiumPayment");

            migrationBuilder.DropForeignKey(
                name: "FK_VipPayment_Cars_CarId",
                table: "VipPayment");

            migrationBuilder.DropTable(
                name: "EquipmentCar");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_VipPayment_CarId",
                table: "VipPayment");

            migrationBuilder.DropIndex(
                name: "IX_PremiumPayment_CarId",
                table: "PremiumPayment");

            migrationBuilder.DropIndex(
                name: "IX_Image_CarId",
                table: "Image");

            migrationBuilder.DropIndex(
                name: "IX_Comment_CarId",
                table: "Comment");
        }
    }
}
