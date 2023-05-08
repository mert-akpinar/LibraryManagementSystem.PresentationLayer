using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryManagementSystem.DataAccessLayer.Migrations
{
    public partial class update_category : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CayegoryName",
                table: "Categories",
                newName: "CategoryName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CategoryName",
                table: "Categories",
                newName: "CayegoryName");
        }
    }
}
