using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab_One.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_courses_Dept_id",
                table: "Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Departments_Crs_id",
                table: "Instructors");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_courses_Crs_id",
                table: "Instructors",
                column: "Crs_id",
                principalTable: "courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Departments_Dept_id",
                table: "Instructors",
                column: "Dept_id",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_courses_Crs_id",
                table: "Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Departments_Dept_id",
                table: "Instructors");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_courses_Dept_id",
                table: "Instructors",
                column: "Dept_id",
                principalTable: "courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Departments_Crs_id",
                table: "Instructors",
                column: "Crs_id",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
