using Microsoft.EntityFrameworkCore.Migrations;

namespace GraduateStudent.Dal.Migrations
{
    public partial class TCAndSchoolNumberColumnsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SchoolNumber",
                table: "Students",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TC",
                table: "Students",
                maxLength: 20,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SchoolNumber",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "TC",
                table: "Students");
        }
    }
}
