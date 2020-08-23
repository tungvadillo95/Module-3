using Microsoft.EntityFrameworkCore.Migrations;

namespace WBD_Demo.Migrations
{
    public partial class SeedingEmployeeData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "ID", "Avatarpath", "Department", "Email", "Name" },
                values: new object[] { 1, "~/images/avatar_torres.png", 0, "lfc.torres@gmail.com", "Fernando Torres" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "ID", "Avatarpath", "Department", "Email", "Name" },
                values: new object[] { 2, "~/images/avatar_gerrard.png", 2, "lfc.gerrard@gmail.com", "Steven Gerrard" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 2);
        }
    }
}
