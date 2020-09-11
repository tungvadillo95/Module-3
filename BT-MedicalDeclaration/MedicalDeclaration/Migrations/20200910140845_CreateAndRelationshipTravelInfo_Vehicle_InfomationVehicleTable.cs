using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalDeclaration.Migrations
{
    public partial class CreateAndRelationshipTravelInfo_Vehicle_InfomationVehicleTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TravelInformation",
                columns: table => new
                {
                    TravelInformationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OtherVehicles = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    VehicleNumber = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    SeatsNumber = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    DepartureDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EntryDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DepartureLocation_ProvinceId = table.Column<int>(type: "int", nullable: false),
                    PlaceOfDestination_ProvinceId = table.Column<int>(type: "int", nullable: false),
                    TravelHistory = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TravelInformation", x => x.TravelInformationId);
                });

            migrationBuilder.CreateTable(
                name: "Vehicle",
                columns: table => new
                {
                    VehiclesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehiclesName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle", x => x.VehiclesId);
                });

            migrationBuilder.CreateTable(
                name: "InfomationVehicles",
                columns: table => new
                {
                    TravelInformationId = table.Column<int>(type: "int", nullable: false),
                    VehiclesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InfomationVehicles", x => new { x.TravelInformationId, x.VehiclesId });
                    table.ForeignKey(
                        name: "FK_InfomationVehicles_TravelInformation_TravelInformationId",
                        column: x => x.TravelInformationId,
                        principalTable: "TravelInformation",
                        principalColumn: "TravelInformationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InfomationVehicles_Vehicle_VehiclesId",
                        column: x => x.VehiclesId,
                        principalTable: "Vehicle",
                        principalColumn: "VehiclesId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InfomationVehicles_VehiclesId",
                table: "InfomationVehicles",
                column: "VehiclesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InfomationVehicles");

            migrationBuilder.DropTable(
                name: "TravelInformation");

            migrationBuilder.DropTable(
                name: "Vehicle");
        }
    }
}
