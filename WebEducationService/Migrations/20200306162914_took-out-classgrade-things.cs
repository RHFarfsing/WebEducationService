using Microsoft.EntityFrameworkCore.Migrations;

namespace WebEducationService.Migrations
{
    public partial class tookoutclassgradethings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_studentClassRels_ClassGrade_ClassGradeGrade",
                table: "studentClassRels");

            migrationBuilder.DropTable(
                name: "ClassGrade");

            migrationBuilder.DropIndex(
                name: "IX_studentClassRels_ClassGradeGrade",
                table: "studentClassRels");

            migrationBuilder.DropColumn(
                name: "CLassGradeValue",
                table: "studentClassRels");

            migrationBuilder.DropColumn(
                name: "ClassGradeGrade",
                table: "studentClassRels");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CLassGradeValue",
                table: "studentClassRels",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClassGradeGrade",
                table: "studentClassRels",
                type: "nvarchar(10)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ClassGrade",
                columns: table => new
                {
                    Grade = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    GPA = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassGrade", x => x.Grade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_studentClassRels_ClassGradeGrade",
                table: "studentClassRels",
                column: "ClassGradeGrade");

            migrationBuilder.AddForeignKey(
                name: "FK_studentClassRels_ClassGrade_ClassGradeGrade",
                table: "studentClassRels",
                column: "ClassGradeGrade",
                principalTable: "ClassGrade",
                principalColumn: "Grade",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
