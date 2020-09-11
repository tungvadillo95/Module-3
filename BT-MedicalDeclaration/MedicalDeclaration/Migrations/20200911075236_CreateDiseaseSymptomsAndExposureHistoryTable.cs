using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalDeclaration.Migrations
{
    public partial class CreateDiseaseSymptomsAndExposureHistoryTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InfomationVehicles_TravelInformation_TravelInformationId",
                table: "InfomationVehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_InfomationVehicles_Vehicle_VehiclesId",
                table: "InfomationVehicles");

            migrationBuilder.DropTable(
                name: "Gate");

            migrationBuilder.DropTable(
                name: "Gender");

            migrationBuilder.DropTable(
                name: "PersonalInfo");

            migrationBuilder.DropTable(
                name: "TravelInformation");

            migrationBuilder.DropTable(
                name: "Vehicle");

            migrationBuilder.DropIndex(
                name: "IX_InfomationVehicles_VehiclesId",
                table: "InfomationVehicles");

            migrationBuilder.CreateTable(
                name: "DiseaseSymptomsAndExposureHistorys",
                columns: table => new
                {
                    DSAEH_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fever = table.Column<bool>(type: "bit", nullable: false),
                    Cough = table.Column<bool>(type: "bit", nullable: false),
                    Sultry = table.Column<bool>(type: "bit", nullable: false),
                    SoreThroat = table.Column<bool>(type: "bit", nullable: false),
                    VomitingOrNausea = table.Column<bool>(type: "bit", nullable: false),
                    Diarrhea = table.Column<bool>(type: "bit", nullable: false),
                    BleedingFromTheSkin = table.Column<bool>(type: "bit", nullable: false),
                    SkinRash = table.Column<bool>(type: "bit", nullable: false),
                    VaccinesOrBiologicalsUsed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnimalContact = table.Column<bool>(type: "bit", nullable: false),
                    CloseContact = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiseaseSymptomsAndExposureHistorys", x => x.DSAEH_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiseaseSymptomsAndExposureHistorys");

            migrationBuilder.CreateTable(
                name: "Gate",
                columns: table => new
                {
                    GateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GateName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gate", x => x.GateId);
                });

            migrationBuilder.CreateTable(
                name: "Gender",
                columns: table => new
                {
                    GenderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenderName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gender", x => x.GenderId);
                });

            migrationBuilder.CreateTable(
                name: "PersonalInfo",
                columns: table => new
                {
                    PersonalInfoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GateId = table.Column<int>(type: "int", nullable: false),
                    GenderId = table.Column<int>(type: "int", nullable: false),
                    PassportNumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PersonalName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    YearOfBirth = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalInfo", x => x.PersonalInfoId);
                });

            migrationBuilder.CreateTable(
                name: "TravelInformation",
                columns: table => new
                {
                    TravelInformationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartureDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DepartureLocation_ProvinceId = table.Column<int>(type: "int", nullable: false),
                    EntryDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OtherVehicles = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    PlaceOfDestination_ProvinceId = table.Column<int>(type: "int", nullable: false),
                    SeatsNumber = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    TravelHistory = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    VehicleNumber = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
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

            migrationBuilder.CreateIndex(
                name: "IX_InfomationVehicles_VehiclesId",
                table: "InfomationVehicles",
                column: "VehiclesId");

            migrationBuilder.AddForeignKey(
                name: "FK_InfomationVehicles_TravelInformation_TravelInformationId",
                table: "InfomationVehicles",
                column: "TravelInformationId",
                principalTable: "TravelInformation",
                principalColumn: "TravelInformationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InfomationVehicles_Vehicle_VehiclesId",
                table: "InfomationVehicles",
                column: "VehiclesId",
                principalTable: "Vehicle",
                principalColumn: "VehiclesId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
