using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Labb3.Models;

public partial class SchoolLabb2Context : DbContext
{
    public SchoolLabb2Context()
    {
    }

    public SchoolLabb2Context(DbContextOptions<SchoolLabb2Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<CourseTeacher> CourseTeachers { get; set; }

    public virtual DbSet<Enrollment> Enrollments { get; set; }

    public virtual DbSet<Grade> Grades { get; set; }

    public virtual DbSet<GradeDetail> GradeDetails { get; set; }

    public virtual DbSet<Profession> Professions { get; set; }

    public virtual DbSet<Staff> Staff { get; set; }

    public virtual DbSet<StaffProfession> StaffProfessions { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog= SchoolLabb2;Integrated Security=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Course>(entity =>
        {
            entity.HasKey(e => e.CourseId).HasName("PK__Course__C92D718746CA3F48");

            entity.ToTable("Course");

            entity.Property(e => e.CourseId).HasColumnName("CourseID");
            entity.Property(e => e.CourseDescription).HasMaxLength(150);
            entity.Property(e => e.CourseName).HasMaxLength(50);
        });

        modelBuilder.Entity<CourseTeacher>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Course_Teacher");

            entity.Property(e => e.FkCourseId).HasColumnName("FK_CourseID");
            entity.Property(e => e.FkTeacherId).HasColumnName("FK_TeacherID");

            entity.HasOne(d => d.FkCourse).WithMany()
                .HasForeignKey(d => d.FkCourseId)
                .HasConstraintName("Course_Teacher_CourseID");

            entity.HasOne(d => d.FkTeacher).WithMany()
                .HasForeignKey(d => d.FkTeacherId)
                .HasConstraintName("Course_Teacher_TeacherID");
        });

        modelBuilder.Entity<Enrollment>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Enrollment");

            entity.Property(e => e.FkCourseId).HasColumnName("FK_CourseID");
            entity.Property(e => e.FkGradeId).HasColumnName("FK_GradeID");
            entity.Property(e => e.FkStudentId).HasColumnName("FK_StudentID");

            entity.HasOne(d => d.FkCourse).WithMany()
                .HasForeignKey(d => d.FkCourseId)
                .HasConstraintName("FK_CourseID_Enrollment");

            entity.HasOne(d => d.FkGrade).WithMany()
                .HasForeignKey(d => d.FkGradeId)
                .HasConstraintName("FK_Grade_Enrollment");

            entity.HasOne(d => d.FkStudent).WithMany()
                .HasForeignKey(d => d.FkStudentId)
                .HasConstraintName("FK_StudentID_Enrollment");
        });

        modelBuilder.Entity<Grade>(entity =>
        {
            entity.HasKey(e => e.GradeId).HasName("PK__Grade__54F87A3719E7AF82");

            entity.ToTable("Grade");

            entity.Property(e => e.GradeId).HasColumnName("GradeID");
            entity.Property(e => e.FkStudentId).HasColumnName("FK_StudentID");
            entity.Property(e => e.Grade1)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Grade");

            entity.HasOne(d => d.FkStudent).WithMany(p => p.Grades)
                .HasForeignKey(d => d.FkStudentId)
                .HasConstraintName("Grade_StudentID");
        });

        modelBuilder.Entity<GradeDetail>(entity =>
        {
            entity.HasKey(e => e.GradeDetailId).HasName("PK__GradeDet__41C6FC3EBE843C97");

            entity.Property(e => e.GradeDetailId).HasColumnName("GradeDetailID");
            entity.Property(e => e.FkGradeId).HasColumnName("FK_GradeID");
            entity.Property(e => e.FkStudentId).HasColumnName("FK_StudentID");
            entity.Property(e => e.SetDate).HasColumnType("date");

            entity.HasOne(d => d.FkGrade).WithMany(p => p.GradeDetails)
                .HasForeignKey(d => d.FkGradeId)
                .HasConstraintName("GradeDetails_FK_Grade");

            entity.HasOne(d => d.FkStudent).WithMany(p => p.GradeDetails)
                .HasForeignKey(d => d.FkStudentId)
                .HasConstraintName("GradeDetails_StudentID");
        });

        modelBuilder.Entity<Profession>(entity =>
        {
            entity.HasKey(e => e.ProfessionId).HasName("PK__Professi__3F309E1F67BA9BD9");

            entity.Property(e => e.ProfessionId).HasColumnName("ProfessionID");
            entity.Property(e => e.StaffRole).HasMaxLength(50);
        });

        modelBuilder.Entity<Staff>(entity =>
        {
            entity.HasKey(e => e.StaffId).HasName("PK__Staff__96D4AAF7FB4158AA");

            entity.Property(e => e.StaffId).HasColumnName("StaffID");
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.ProfessionId).HasColumnName("ProfessionID");
        });

        modelBuilder.Entity<StaffProfession>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Staff_Professions");

            entity.Property(e => e.FkProfessionId).HasColumnName("FK_ProfessionID");
            entity.Property(e => e.FkStaffId).HasColumnName("FK_StaffID");

            entity.HasOne(d => d.FkProfession).WithMany()
                .HasForeignKey(d => d.FkProfessionId)
                .HasConstraintName("FK_Staff_Professions_ProfessionID");

            entity.HasOne(d => d.FkStaff).WithMany()
                .HasForeignKey(d => d.FkStaffId)
                .HasConstraintName("FK_Staff_Professions_StaffID");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.StudentId).HasName("PK__Students__32C52A7911F00921");

            entity.Property(e => e.StudentId).HasColumnName("StudentID");
            entity.Property(e => e.Class).HasMaxLength(5);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.Gender).HasMaxLength(1);
            entity.Property(e => e.LastName).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
