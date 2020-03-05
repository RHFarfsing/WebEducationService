using Microsoft.EntityFrameworkCore.Migrations;

namespace WebEducationService.Migrations
{
    public partial class added_StudentClassRel_class : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "studentClassRels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(nullable: false),
                    ClassId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_studentClassRels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_studentClassRels_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_studentClassRels_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_studentClassRels_ClassId",
                table: "studentClassRels",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_studentClassRels_StudentId",
                table: "studentClassRels",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "studentClassRels");
        }
    }
}
