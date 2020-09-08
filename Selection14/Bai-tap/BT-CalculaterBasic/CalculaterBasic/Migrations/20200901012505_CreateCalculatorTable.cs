using Microsoft.EntityFrameworkCore.Migrations;

namespace CalculaterBasic.Migrations
{
    public partial class CreateCalculatorTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "calculators",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    valueA = table.Column<double>(nullable: false),
                    valueB = table.Column<double>(nullable: false),
                    Operator = table.Column<string>(nullable: true),
                    result = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_calculators", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "calculators");
        }
    }
}
