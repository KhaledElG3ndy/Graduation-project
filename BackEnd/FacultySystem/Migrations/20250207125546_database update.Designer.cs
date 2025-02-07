﻿// <auto-generated />
using System;
using FacultySystem.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FacultySystem.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250207125546_database update")]
    partial class databaseupdate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FacultySystem.Models.AssignmentAns", b =>
                {
                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<int>("StudentEmail")
                        .HasColumnType("int");

                    b.Property<string>("StudentEmail1")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("QuestionId", "StudentEmail");

                    b.HasIndex("StudentEmail1");

                    b.ToTable("AssignmentAns");
                });

            modelBuilder.Entity("FacultySystem.Models.Choice", b =>
                {
                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<string>("choice")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("AddedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("QuestionId", "choice");

                    b.ToTable("Choice");
                });

            modelBuilder.Entity("FacultySystem.Models.Comment", b =>
                {
                    b.Property<int>("PostStaffEmail")
                        .HasColumnType("int");

                    b.Property<string>("PostSubjectDepartment")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PostSubjectLevel")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CommenterEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PostStaffEmail", "PostSubjectDepartment", "PostSubjectLevel", "Content");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("FacultySystem.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("FacultySystem.Models.Exam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<int>("Grade")
                        .HasColumnType("int");

                    b.Property<int>("StaffEmail")
                        .HasColumnType("int");

                    b.Property<string>("StaffEmail1")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SubjectDepartment")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SubjectLevel")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<byte>("type")
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.HasIndex("StaffEmail1");

                    b.HasIndex("SubjectDepartment", "SubjectLevel");

                    b.ToTable("Exams");
                });

            modelBuilder.Entity("FacultySystem.Models.Material", b =>
                {
                    b.Property<int>("StaffEmail")
                        .HasColumnType("int");

                    b.Property<string>("SubjectDepartment")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SubjectLevel")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("StaffEmail1")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("UploadedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("StaffEmail", "SubjectDepartment", "SubjectLevel");

                    b.HasIndex("StaffEmail1");

                    b.HasIndex("SubjectDepartment", "SubjectLevel");

                    b.ToTable("Material");
                });

            modelBuilder.Entity("FacultySystem.Models.News", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StaffEmail")
                        .HasColumnType("int");

                    b.Property<string>("StaffEmail1")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("StaffEmail1");

                    b.ToTable("News");
                });

            modelBuilder.Entity("FacultySystem.Models.Post", b =>
                {
                    b.Property<int>("StaffEmail")
                        .HasColumnType("int");

                    b.Property<string>("SubjectDepartment")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SubjectLevel")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StaffEmail1")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("UploadedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("StaffEmail", "SubjectDepartment", "SubjectLevel");

                    b.HasIndex("StaffEmail1");

                    b.HasIndex("SubjectDepartment", "SubjectLevel");

                    b.ToTable("Post");
                });

            modelBuilder.Entity("FacultySystem.Models.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CorrectAns")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ExamId")
                        .HasColumnType("int");

                    b.Property<int>("Grade")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("Type")
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.HasIndex("ExamId");

                    b.ToTable("Question");
                });

            modelBuilder.Entity("FacultySystem.Models.QuestionAns", b =>
                {
                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<int>("StudentEmail")
                        .HasColumnType("int");

                    b.Property<string>("StudentAns")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentEmail1")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("QuestionId", "StudentEmail");

                    b.HasIndex("StudentEmail1");

                    b.ToTable("QuestionAns");
                });

            modelBuilder.Entity("FacultySystem.Models.Registeration", b =>
                {
                    b.Property<int>("StaffEmail")
                        .HasColumnType("int");

                    b.Property<string>("SubjectDepartment")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SubjectLevel")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("StaffEmail1")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("StaffEmail", "SubjectDepartment", "SubjectLevel");

                    b.HasIndex("StaffEmail1");

                    b.HasIndex("SubjectDepartment", "SubjectLevel");

                    b.ToTable("Registeration");
                });

            modelBuilder.Entity("FacultySystem.Models.Staff", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("Gender")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NationalId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Email");

                    b.ToTable("Staffs");
                });

            modelBuilder.Entity("FacultySystem.Models.Student", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<bool>("Gender")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NationalId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Email");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("FacultySystem.Models.Subject", b =>
                {
                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Level")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Hours")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Department", "Level");

                    b.ToTable("Subject");
                });

            modelBuilder.Entity("FacultySystem.Models.AssignmentAns", b =>
                {
                    b.HasOne("FacultySystem.Models.Question", "Question")
                        .WithMany()
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FacultySystem.Models.Student", "Student")
                        .WithMany("AssignmentAnss")
                        .HasForeignKey("StudentEmail1");

                    b.Navigation("Question");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("FacultySystem.Models.Choice", b =>
                {
                    b.HasOne("FacultySystem.Models.Question", "Question")
                        .WithMany("Choices")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("FacultySystem.Models.Comment", b =>
                {
                    b.HasOne("FacultySystem.Models.Post", "Post")
                        .WithMany("Comments")
                        .HasForeignKey("PostStaffEmail", "PostSubjectDepartment", "PostSubjectLevel")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");
                });

            modelBuilder.Entity("FacultySystem.Models.Exam", b =>
                {
                    b.HasOne("FacultySystem.Models.Staff", "Staff")
                        .WithMany("Exams")
                        .HasForeignKey("StaffEmail1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FacultySystem.Models.Subject", "Subject")
                        .WithMany("Exams")
                        .HasForeignKey("SubjectDepartment", "SubjectLevel")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Staff");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("FacultySystem.Models.Material", b =>
                {
                    b.HasOne("FacultySystem.Models.Staff", "Staff")
                        .WithMany("Materials")
                        .HasForeignKey("StaffEmail1");

                    b.HasOne("FacultySystem.Models.Subject", "Subject")
                        .WithMany("Materials")
                        .HasForeignKey("SubjectDepartment", "SubjectLevel")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Staff");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("FacultySystem.Models.News", b =>
                {
                    b.HasOne("FacultySystem.Models.Staff", "Staff")
                        .WithMany("News")
                        .HasForeignKey("StaffEmail1");

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("FacultySystem.Models.Post", b =>
                {
                    b.HasOne("FacultySystem.Models.Staff", "Staff")
                        .WithMany("Posts")
                        .HasForeignKey("StaffEmail1");

                    b.HasOne("FacultySystem.Models.Subject", "Subject")
                        .WithMany("Posts")
                        .HasForeignKey("SubjectDepartment", "SubjectLevel")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Staff");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("FacultySystem.Models.Question", b =>
                {
                    b.HasOne("FacultySystem.Models.Exam", "Exam")
                        .WithMany("Questions")
                        .HasForeignKey("ExamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exam");
                });

            modelBuilder.Entity("FacultySystem.Models.QuestionAns", b =>
                {
                    b.HasOne("FacultySystem.Models.Question", "Question")
                        .WithMany("QuestionAnss")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FacultySystem.Models.Student", "Student")
                        .WithMany("QuestionAnss")
                        .HasForeignKey("StudentEmail1");

                    b.Navigation("Question");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("FacultySystem.Models.Registeration", b =>
                {
                    b.HasOne("FacultySystem.Models.Staff", "Staff")
                        .WithMany("Registerations")
                        .HasForeignKey("StaffEmail1");

                    b.HasOne("FacultySystem.Models.Subject", "Subject")
                        .WithMany("Registerations")
                        .HasForeignKey("SubjectDepartment", "SubjectLevel")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Staff");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("FacultySystem.Models.Student", b =>
                {
                    b.HasOne("FacultySystem.Models.Department", "Department")
                        .WithMany("Students")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("FacultySystem.Models.Department", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("FacultySystem.Models.Exam", b =>
                {
                    b.Navigation("Questions");
                });

            modelBuilder.Entity("FacultySystem.Models.Post", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("FacultySystem.Models.Question", b =>
                {
                    b.Navigation("Choices");

                    b.Navigation("QuestionAnss");
                });

            modelBuilder.Entity("FacultySystem.Models.Staff", b =>
                {
                    b.Navigation("Exams");

                    b.Navigation("Materials");

                    b.Navigation("News");

                    b.Navigation("Posts");

                    b.Navigation("Registerations");
                });

            modelBuilder.Entity("FacultySystem.Models.Student", b =>
                {
                    b.Navigation("AssignmentAnss");

                    b.Navigation("QuestionAnss");
                });

            modelBuilder.Entity("FacultySystem.Models.Subject", b =>
                {
                    b.Navigation("Exams");

                    b.Navigation("Materials");

                    b.Navigation("Posts");

                    b.Navigation("Registerations");
                });
#pragma warning restore 612, 618
        }
    }
}
