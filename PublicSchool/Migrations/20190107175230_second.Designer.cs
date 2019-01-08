﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PublicSchool.Database;

namespace PublicSchool.Migrations
{
    [DbContext(typeof(PublicSchoolDbContext))]
    [Migration("20190107175230_second")]
    partial class second
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PublicSchool.Models.Assignment", b =>
                {
                    b.Property<int>("AssignmentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AssignmentType");

                    b.Property<int?>("CourseId");

                    b.Property<int?>("GradeId");

                    b.Property<bool>("Submitted");

                    b.HasKey("AssignmentId");

                    b.HasIndex("CourseId");

                    b.HasIndex("GradeId");

                    b.ToTable("Assignments");
                });

            modelBuilder.Entity("PublicSchool.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Subject");

                    b.Property<int?>("TeacherId1");

                    b.HasKey("CourseId");

                    b.HasIndex("TeacherId1");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("PublicSchool.Models.Enrollment", b =>
                {
                    b.Property<int>("EnrollmentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseId");

                    b.Property<int>("StudentId");

                    b.HasKey("EnrollmentId");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("Enrollments");
                });

            modelBuilder.Entity("PublicSchool.Models.Grade", b =>
                {
                    b.Property<int>("GradeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("NumGrade");

                    b.HasKey("GradeId");

                    b.ToTable("Grades");
                });

            modelBuilder.Entity("PublicSchool.Models.Parent", b =>
                {
                    b.Property<int>("ParentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmergencyContact");

                    b.Property<string>("FirstName");

                    b.Property<string>("HomePhone");

                    b.Property<string>("LastName");

                    b.Property<int>("StudentId");

                    b.HasKey("ParentId");

                    b.HasIndex("StudentId")
                        .IsUnique();

                    b.ToTable("Parents");
                });

            modelBuilder.Entity("PublicSchool.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<int>("Year");

                    b.HasKey("StudentId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("PublicSchool.Models.Teacher", b =>
                {
                    b.Property<int>("TeacherId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("TeacherId");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("PublicSchool.Models.Assignment", b =>
                {
                    b.HasOne("PublicSchool.Models.Course", "Course")
                        .WithMany("Assignments")
                        .HasForeignKey("CourseId");

                    b.HasOne("PublicSchool.Models.Grade", "Grade")
                        .WithMany()
                        .HasForeignKey("GradeId");
                });

            modelBuilder.Entity("PublicSchool.Models.Course", b =>
                {
                    b.HasOne("PublicSchool.Models.Teacher", "TeacherId")
                        .WithMany("Courses")
                        .HasForeignKey("TeacherId1");
                });

            modelBuilder.Entity("PublicSchool.Models.Enrollment", b =>
                {
                    b.HasOne("PublicSchool.Models.Course", "Course")
                        .WithMany("Enrollments")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PublicSchool.Models.Student", "Student")
                        .WithMany("Enrollments")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PublicSchool.Models.Parent", b =>
                {
                    b.HasOne("PublicSchool.Models.Student", "Student")
                        .WithOne("Parent")
                        .HasForeignKey("PublicSchool.Models.Parent", "StudentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
