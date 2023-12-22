﻿// <auto-generated />
using System;
using Labb3.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Labb3.Migrations
{
    [DbContext(typeof(SchoolLabb2Context))]
    partial class SchoolLabb2ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Labb3.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CourseID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseId"));

                    b.Property<string>("CourseDescription")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("CourseName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CourseId")
                        .HasName("PK__Course__C92D718746CA3F48");

                    b.ToTable("Course", (string)null);
                });

            modelBuilder.Entity("Labb3.Models.CourseTeacher", b =>
                {
                    b.Property<int?>("FkCourseId")
                        .HasColumnType("int")
                        .HasColumnName("FK_CourseID");

                    b.Property<int?>("FkTeacherId")
                        .HasColumnType("int")
                        .HasColumnName("FK_TeacherID");

                    b.HasIndex("FkCourseId");

                    b.HasIndex("FkTeacherId");

                    b.ToTable("Course_Teacher", (string)null);
                });

            modelBuilder.Entity("Labb3.Models.Enrollment", b =>
                {
                    b.Property<int?>("FkCourseId")
                        .HasColumnType("int")
                        .HasColumnName("FK_CourseID");

                    b.Property<int?>("FkGradeId")
                        .HasColumnType("int")
                        .HasColumnName("FK_GradeID");

                    b.Property<int?>("FkStudentId")
                        .HasColumnType("int")
                        .HasColumnName("FK_StudentID");

                    b.HasIndex("FkCourseId");

                    b.HasIndex("FkGradeId");

                    b.HasIndex("FkStudentId");

                    b.ToTable("Enrollment", (string)null);
                });

            modelBuilder.Entity("Labb3.Models.Grade", b =>
                {
                    b.Property<int>("GradeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("GradeID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GradeId"));

                    b.Property<int?>("FkStudentId")
                        .HasColumnType("int")
                        .HasColumnName("FK_StudentID");

                    b.Property<string>("Grade1")
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("char(1)")
                        .HasColumnName("Grade")
                        .IsFixedLength();

                    b.HasKey("GradeId")
                        .HasName("PK__Grade__54F87A3719E7AF82");

                    b.HasIndex("FkStudentId");

                    b.ToTable("Grade", (string)null);
                });

            modelBuilder.Entity("Labb3.Models.GradeDetail", b =>
                {
                    b.Property<int>("GradeDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("GradeDetailID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GradeDetailId"));

                    b.Property<int?>("FkGradeId")
                        .HasColumnType("int")
                        .HasColumnName("FK_GradeID");

                    b.Property<int?>("FkStudentId")
                        .HasColumnType("int")
                        .HasColumnName("FK_StudentID");

                    b.Property<DateTime?>("SetDate")
                        .HasColumnType("date");

                    b.HasKey("GradeDetailId")
                        .HasName("PK__GradeDet__41C6FC3EBE843C97");

                    b.HasIndex("FkGradeId");

                    b.HasIndex("FkStudentId");

                    b.ToTable("GradeDetails");
                });

            modelBuilder.Entity("Labb3.Models.Profession", b =>
                {
                    b.Property<int>("ProfessionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ProfessionID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProfessionId"));

                    b.Property<string>("StaffRole")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ProfessionId")
                        .HasName("PK__Professi__3F309E1F67BA9BD9");

                    b.ToTable("Professions");
                });

            modelBuilder.Entity("Labb3.Models.Staff", b =>
                {
                    b.Property<int>("StaffId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("StaffID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StaffId"));

                    b.Property<string>("FirstName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("ProfessionId")
                        .HasColumnType("int")
                        .HasColumnName("ProfessionID");

                    b.Property<long?>("SocialSecurityNumber")
                        .HasColumnType("bigint");

                    b.HasKey("StaffId")
                        .HasName("PK__Staff__96D4AAF7FB4158AA");

                    b.ToTable("Staff");
                });

            modelBuilder.Entity("Labb3.Models.StaffProfession", b =>
                {
                    b.Property<int?>("FkProfessionId")
                        .HasColumnType("int")
                        .HasColumnName("FK_ProfessionID");

                    b.Property<int?>("FkStaffId")
                        .HasColumnType("int")
                        .HasColumnName("FK_StaffID");

                    b.HasIndex("FkProfessionId");

                    b.HasIndex("FkStaffId");

                    b.ToTable("Staff_Professions", (string)null);
                });

            modelBuilder.Entity("Labb3.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("StudentID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"));

                    b.Property<string>("Class")
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Gender")
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<long?>("SocialSecurityNumber")
                        .HasColumnType("bigint");

                    b.HasKey("StudentId")
                        .HasName("PK__Students__32C52A7911F00921");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Labb3.Models.CourseTeacher", b =>
                {
                    b.HasOne("Labb3.Models.Course", "FkCourse")
                        .WithMany()
                        .HasForeignKey("FkCourseId")
                        .HasConstraintName("Course_Teacher_CourseID");

                    b.HasOne("Labb3.Models.Staff", "FkTeacher")
                        .WithMany()
                        .HasForeignKey("FkTeacherId")
                        .HasConstraintName("Course_Teacher_TeacherID");

                    b.Navigation("FkCourse");

                    b.Navigation("FkTeacher");
                });

            modelBuilder.Entity("Labb3.Models.Enrollment", b =>
                {
                    b.HasOne("Labb3.Models.Course", "FkCourse")
                        .WithMany()
                        .HasForeignKey("FkCourseId")
                        .HasConstraintName("FK_CourseID_Enrollment");

                    b.HasOne("Labb3.Models.Grade", "FkGrade")
                        .WithMany()
                        .HasForeignKey("FkGradeId")
                        .HasConstraintName("FK_Grade_Enrollment");

                    b.HasOne("Labb3.Models.Student", "FkStudent")
                        .WithMany()
                        .HasForeignKey("FkStudentId")
                        .HasConstraintName("FK_StudentID_Enrollment");

                    b.Navigation("FkCourse");

                    b.Navigation("FkGrade");

                    b.Navigation("FkStudent");
                });

            modelBuilder.Entity("Labb3.Models.Grade", b =>
                {
                    b.HasOne("Labb3.Models.Student", "FkStudent")
                        .WithMany("Grades")
                        .HasForeignKey("FkStudentId")
                        .HasConstraintName("Grade_StudentID");

                    b.Navigation("FkStudent");
                });

            modelBuilder.Entity("Labb3.Models.GradeDetail", b =>
                {
                    b.HasOne("Labb3.Models.Grade", "FkGrade")
                        .WithMany("GradeDetails")
                        .HasForeignKey("FkGradeId")
                        .HasConstraintName("GradeDetails_FK_Grade");

                    b.HasOne("Labb3.Models.Student", "FkStudent")
                        .WithMany("GradeDetails")
                        .HasForeignKey("FkStudentId")
                        .HasConstraintName("GradeDetails_StudentID");

                    b.Navigation("FkGrade");

                    b.Navigation("FkStudent");
                });

            modelBuilder.Entity("Labb3.Models.StaffProfession", b =>
                {
                    b.HasOne("Labb3.Models.Profession", "FkProfession")
                        .WithMany()
                        .HasForeignKey("FkProfessionId")
                        .HasConstraintName("FK_Staff_Professions_ProfessionID");

                    b.HasOne("Labb3.Models.Staff", "FkStaff")
                        .WithMany()
                        .HasForeignKey("FkStaffId")
                        .HasConstraintName("FK_Staff_Professions_StaffID");

                    b.Navigation("FkProfession");

                    b.Navigation("FkStaff");
                });

            modelBuilder.Entity("Labb3.Models.Grade", b =>
                {
                    b.Navigation("GradeDetails");
                });

            modelBuilder.Entity("Labb3.Models.Student", b =>
                {
                    b.Navigation("GradeDetails");

                    b.Navigation("Grades");
                });
#pragma warning restore 612, 618
        }
    }
}
