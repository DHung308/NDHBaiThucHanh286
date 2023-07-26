using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirstWebMVC.Migrations
{
    /// <inheritdoc />
    public partial class Creat_ForeignKey_Student : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FacultyName",
                table: "Student");

            migrationBuilder.CreateIndex(
                name: "IX_Student_FacultyID",
                table: "Student",
                column: "FacultyID");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Faculty_FacultyID",
                table: "Student",
                column: "FacultyID",
                principalTable: "Faculty",
                principalColumn: "FacultyID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Faculty_FacultyID",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Student_FacultyID",
                table: "Student");

            migrationBuilder.AddColumn<string>(
                name: "FacultyName",
                table: "Student",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
