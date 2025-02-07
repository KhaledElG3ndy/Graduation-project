using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FacultySystem.Migrations
{
    /// <inheritdoc />
    public partial class effinished : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssignmentAns_Students_StudentId",
                table: "AssignmentAns");

            migrationBuilder.DropForeignKey(
                name: "FK_Exams_Staffs_StaffId",
                table: "Exams");

            migrationBuilder.DropForeignKey(
                name: "FK_News_Staffs_StaffId",
                table: "News");

            migrationBuilder.DropForeignKey(
                name: "FK_QuestionAns_Students_StudentId",
                table: "QuestionAns");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Staffs",
                table: "Staffs");

            migrationBuilder.DropIndex(
                name: "IX_QuestionAns_StudentId",
                table: "QuestionAns");

            migrationBuilder.DropIndex(
                name: "IX_News_StaffId",
                table: "News");

            migrationBuilder.DropIndex(
                name: "IX_Exams_StaffId",
                table: "Exams");

            migrationBuilder.DropIndex(
                name: "IX_AssignmentAns_StudentId",
                table: "AssignmentAns");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Staffs");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "QuestionAns",
                newName: "StudentEmail");

            migrationBuilder.RenameColumn(
                name: "StaffId",
                table: "News",
                newName: "StaffEmail");

            migrationBuilder.RenameColumn(
                name: "StaffId",
                table: "Exams",
                newName: "StaffEmail");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "AssignmentAns",
                newName: "StudentEmail");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Students",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Staffs",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "StudentEmail1",
                table: "QuestionAns",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StaffEmail1",
                table: "News",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StaffEmail1",
                table: "Exams",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "StudentEmail1",
                table: "AssignmentAns",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "Email");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Staffs",
                table: "Staffs",
                column: "Email");

            migrationBuilder.CreateTable(
                name: "Choice",
                columns: table => new
                {
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    choice = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AddedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Choice", x => new { x.QuestionId, x.choice });
                    table.ForeignKey(
                        name: "FK_Choice_Question_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Question",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Material",
                columns: table => new
                {
                    StaffEmail = table.Column<int>(type: "int", nullable: false),
                    SubjectDepartment = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SubjectLevel = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UploadedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StaffEmail1 = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Material", x => new { x.StaffEmail, x.SubjectDepartment, x.SubjectLevel });
                    table.ForeignKey(
                        name: "FK_Material_Staffs_StaffEmail1",
                        column: x => x.StaffEmail1,
                        principalTable: "Staffs",
                        principalColumn: "Email");
                    table.ForeignKey(
                        name: "FK_Material_Subject_SubjectDepartment_SubjectLevel",
                        columns: x => new { x.SubjectDepartment, x.SubjectLevel },
                        principalTable: "Subject",
                        principalColumns: new[] { "Department", "Level" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Post",
                columns: table => new
                {
                    StaffEmail = table.Column<int>(type: "int", nullable: false),
                    SubjectDepartment = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SubjectLevel = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UploadedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StaffEmail1 = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post", x => new { x.StaffEmail, x.SubjectDepartment, x.SubjectLevel });
                    table.ForeignKey(
                        name: "FK_Post_Staffs_StaffEmail1",
                        column: x => x.StaffEmail1,
                        principalTable: "Staffs",
                        principalColumn: "Email");
                    table.ForeignKey(
                        name: "FK_Post_Subject_SubjectDepartment_SubjectLevel",
                        columns: x => new { x.SubjectDepartment, x.SubjectLevel },
                        principalTable: "Subject",
                        principalColumns: new[] { "Department", "Level" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Registeration",
                columns: table => new
                {
                    StaffEmail = table.Column<int>(type: "int", nullable: false),
                    SubjectDepartment = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SubjectLevel = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StaffEmail1 = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registeration", x => new { x.StaffEmail, x.SubjectDepartment, x.SubjectLevel });
                    table.ForeignKey(
                        name: "FK_Registeration_Staffs_StaffEmail1",
                        column: x => x.StaffEmail1,
                        principalTable: "Staffs",
                        principalColumn: "Email");
                    table.ForeignKey(
                        name: "FK_Registeration_Subject_SubjectDepartment_SubjectLevel",
                        columns: x => new { x.SubjectDepartment, x.SubjectLevel },
                        principalTable: "Subject",
                        principalColumns: new[] { "Department", "Level" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    PostStaffEmail = table.Column<int>(type: "int", nullable: false),
                    PostSubjectDepartment = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PostSubjectLevel = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CommenterEmail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => new { x.PostStaffEmail, x.PostSubjectDepartment, x.PostSubjectLevel, x.Content });
                    table.ForeignKey(
                        name: "FK_Comment_Post_PostStaffEmail_PostSubjectDepartment_PostSubjectLevel",
                        columns: x => new { x.PostStaffEmail, x.PostSubjectDepartment, x.PostSubjectLevel },
                        principalTable: "Post",
                        principalColumns: new[] { "StaffEmail", "SubjectDepartment", "SubjectLevel" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_QuestionAns_StudentEmail1",
                table: "QuestionAns",
                column: "StudentEmail1");

            migrationBuilder.CreateIndex(
                name: "IX_News_StaffEmail1",
                table: "News",
                column: "StaffEmail1");

            migrationBuilder.CreateIndex(
                name: "IX_Exams_StaffEmail1",
                table: "Exams",
                column: "StaffEmail1");

            migrationBuilder.CreateIndex(
                name: "IX_AssignmentAns_StudentEmail1",
                table: "AssignmentAns",
                column: "StudentEmail1");

            migrationBuilder.CreateIndex(
                name: "IX_Material_StaffEmail1",
                table: "Material",
                column: "StaffEmail1");

            migrationBuilder.CreateIndex(
                name: "IX_Material_SubjectDepartment_SubjectLevel",
                table: "Material",
                columns: new[] { "SubjectDepartment", "SubjectLevel" });

            migrationBuilder.CreateIndex(
                name: "IX_Post_StaffEmail1",
                table: "Post",
                column: "StaffEmail1");

            migrationBuilder.CreateIndex(
                name: "IX_Post_SubjectDepartment_SubjectLevel",
                table: "Post",
                columns: new[] { "SubjectDepartment", "SubjectLevel" });

            migrationBuilder.CreateIndex(
                name: "IX_Registeration_StaffEmail1",
                table: "Registeration",
                column: "StaffEmail1");

            migrationBuilder.CreateIndex(
                name: "IX_Registeration_SubjectDepartment_SubjectLevel",
                table: "Registeration",
                columns: new[] { "SubjectDepartment", "SubjectLevel" });

            migrationBuilder.AddForeignKey(
                name: "FK_AssignmentAns_Students_StudentEmail1",
                table: "AssignmentAns",
                column: "StudentEmail1",
                principalTable: "Students",
                principalColumn: "Email");

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_Staffs_StaffEmail1",
                table: "Exams",
                column: "StaffEmail1",
                principalTable: "Staffs",
                principalColumn: "Email",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_News_Staffs_StaffEmail1",
                table: "News",
                column: "StaffEmail1",
                principalTable: "Staffs",
                principalColumn: "Email");

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionAns_Students_StudentEmail1",
                table: "QuestionAns",
                column: "StudentEmail1",
                principalTable: "Students",
                principalColumn: "Email");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssignmentAns_Students_StudentEmail1",
                table: "AssignmentAns");

            migrationBuilder.DropForeignKey(
                name: "FK_Exams_Staffs_StaffEmail1",
                table: "Exams");

            migrationBuilder.DropForeignKey(
                name: "FK_News_Staffs_StaffEmail1",
                table: "News");

            migrationBuilder.DropForeignKey(
                name: "FK_QuestionAns_Students_StudentEmail1",
                table: "QuestionAns");

            migrationBuilder.DropTable(
                name: "Choice");

            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "Material");

            migrationBuilder.DropTable(
                name: "Registeration");

            migrationBuilder.DropTable(
                name: "Post");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Staffs",
                table: "Staffs");

            migrationBuilder.DropIndex(
                name: "IX_QuestionAns_StudentEmail1",
                table: "QuestionAns");

            migrationBuilder.DropIndex(
                name: "IX_News_StaffEmail1",
                table: "News");

            migrationBuilder.DropIndex(
                name: "IX_Exams_StaffEmail1",
                table: "Exams");

            migrationBuilder.DropIndex(
                name: "IX_AssignmentAns_StudentEmail1",
                table: "AssignmentAns");

            migrationBuilder.DropColumn(
                name: "StudentEmail1",
                table: "QuestionAns");

            migrationBuilder.DropColumn(
                name: "StaffEmail1",
                table: "News");

            migrationBuilder.DropColumn(
                name: "StaffEmail1",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "StudentEmail1",
                table: "AssignmentAns");

            migrationBuilder.RenameColumn(
                name: "StudentEmail",
                table: "QuestionAns",
                newName: "StudentId");

            migrationBuilder.RenameColumn(
                name: "StaffEmail",
                table: "News",
                newName: "StaffId");

            migrationBuilder.RenameColumn(
                name: "StaffEmail",
                table: "Exams",
                newName: "StaffId");

            migrationBuilder.RenameColumn(
                name: "StudentEmail",
                table: "AssignmentAns",
                newName: "StudentId");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Staffs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Staffs",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Staffs",
                table: "Staffs",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionAns_StudentId",
                table: "QuestionAns",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_News_StaffId",
                table: "News",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_Exams_StaffId",
                table: "Exams",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_AssignmentAns_StudentId",
                table: "AssignmentAns",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_AssignmentAns_Students_StudentId",
                table: "AssignmentAns",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_Staffs_StaffId",
                table: "Exams",
                column: "StaffId",
                principalTable: "Staffs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_News_Staffs_StaffId",
                table: "News",
                column: "StaffId",
                principalTable: "Staffs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionAns_Students_StudentId",
                table: "QuestionAns",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
