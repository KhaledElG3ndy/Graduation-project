using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FacultySystem.Migrations
{
    /// <inheritdoc />
    public partial class fourthRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StaffId",
                table: "Exams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Exams_StaffId",
                table: "Exams",
                column: "StaffId");

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_Staffs_StaffId",
                table: "Exams",
                column: "StaffId",
                principalTable: "Staffs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exams_Staffs_StaffId",
                table: "Exams");

            migrationBuilder.DropIndex(
                name: "IX_Exams_StaffId",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "StaffId",
                table: "Exams");
        }
    }
}
