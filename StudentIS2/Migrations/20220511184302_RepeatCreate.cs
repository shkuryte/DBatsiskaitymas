using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentIS2.Migrations
{
    public partial class RepeatCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lectures_Departments_DepartmentId",
                table: "Lectures");

            migrationBuilder.DropIndex(
                name: "IX_Lectures_DepartmentId",
                table: "Lectures");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Lectures");

            migrationBuilder.CreateTable(
                name: "DepartmentLecture",
                columns: table => new
                {
                    DepartmentsId = table.Column<int>(type: "int", nullable: false),
                    LecturesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentLecture", x => new { x.DepartmentsId, x.LecturesId });
                    table.ForeignKey(
                        name: "FK_DepartmentLecture_Departments_DepartmentsId",
                        column: x => x.DepartmentsId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepartmentLecture_Lectures_LecturesId",
                        column: x => x.LecturesId,
                        principalTable: "Lectures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentLecture_LecturesId",
                table: "DepartmentLecture",
                column: "LecturesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DepartmentLecture");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "Lectures",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Lectures_DepartmentId",
                table: "Lectures",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lectures_Departments_DepartmentId",
                table: "Lectures",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id");
        }
    }
}
