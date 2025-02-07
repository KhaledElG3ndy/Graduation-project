using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FacultySystem.Migrations
{
    /// <inheritdoc />
    public partial class fifthRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SubjectDepartment",
                table: "Exams",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SubjectLevel",
                table: "Exams",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Exams_SubjectDepartment_SubjectLevel",
                table: "Exams",
                columns: new[] { "SubjectDepartment", "SubjectLevel" });

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_Subject_SubjectDepartment_SubjectLevel",
                table: "Exams",
                columns: new[] { "SubjectDepartment", "SubjectLevel" },
                principalTable: "Subject",
                principalColumns: new[] { "Department", "Level" },
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exams_Subject_SubjectDepartment_SubjectLevel",
                table: "Exams");

            migrationBuilder.DropIndex(
                name: "IX_Exams_SubjectDepartment_SubjectLevel",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "SubjectDepartment",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "SubjectLevel",
                table: "Exams");
        }
    }
}
