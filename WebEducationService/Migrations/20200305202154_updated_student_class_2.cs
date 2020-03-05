using Microsoft.EntityFrameworkCore.Migrations;

namespace WebEducationService.Migrations
{
    public partial class updated_student_class_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "SAT",
                table: "Students",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "GPA",
                table: "Students",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "SAT",
                table: "Students",
                type: "int",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<int>(
                name: "GPA",
                table: "Students",
                type: "int",
                nullable: false,
                oldClrType: typeof(double));
        }
    }
}
