using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogManagement.Migrations
{
    public partial class AddColumnDateUploadToPostsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DateUpload",
                table: "Posts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateUpload",
                table: "Posts");
        }
    }
}
