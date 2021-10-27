using Microsoft.EntityFrameworkCore.Migrations;

namespace ClassroomDBLab.Migrations
{
    public partial class CreateClassroomLabforce : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Food",
                table: "Students",
                newName: "favFood");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "favFood",
                table: "Students",
                newName: "Food");
        }
    }
}
