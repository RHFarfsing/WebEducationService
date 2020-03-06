using Microsoft.EntityFrameworkCore.Migrations;

namespace WebEducationService.Migrations
{
    public partial class added_ClassGrade_class_and_added_Fk_in_StudentClassRel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CLassGradeValue",
                table: "studentClassRels",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClassGradeGrade",
                table: "studentClassRels",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ClassGrade",
                columns: table => new
                {
                    Grade = table.Column<string>(maxLength: 10, nullable: false),
                    GPA = table.Column<double>(nullable: false)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
