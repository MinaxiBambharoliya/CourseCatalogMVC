using Microsoft.EntityFrameworkCore.Migrations;

namespace CourseCatalogMVC.Migrations
{
    public partial class CoursePocoRevised : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isFreeThisWeek",
                table: "Courses",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isFreeThisWeek",
                table: "Courses");
        }
    }
}
