﻿// <auto-generated />
using Lab_One.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Lab_One.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    [Migration("20220716112554_v3")]
    partial class v3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Lab_One.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Degree")
                        .HasColumnType("int");

                    b.Property<int>("Dep_id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PassDegree")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Dep_id");

                    b.ToTable("courses");
                });

            modelBuilder.Entity("Lab_One.Models.CrsResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Crs_id")
                        .HasColumnType("int");

                    b.Property<int>("Trainee_id")
                        .HasColumnType("int");

                    b.Property<float>("degree")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("Crs_id");

                    b.HasIndex("Trainee_id");

                    b.ToTable("CrsResults");
                });

            modelBuilder.Entity("Lab_One.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Manager")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("Lab_One.Models.Instructor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Crs_id")
                        .HasColumnType("int");

                    b.Property<int>("Dept_id")
                        .HasColumnType("int");

                    b.Property<string>("Img")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Salary")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("Crs_id");

                    b.HasIndex("Dept_id");

                    b.ToTable("Instructors");
                });

            modelBuilder.Entity("Lab_One.Models.Trainee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Dept_id")
                        .HasColumnType("int");

                    b.Property<float>("Level")
                        .HasColumnType("real");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Dept_id");

                    b.ToTable("Trainees");
                });

            modelBuilder.Entity("Lab_One.Models.Course", b =>
                {
                    b.HasOne("Lab_One.Models.Department", "department")
                        .WithMany("Courses")
                        .HasForeignKey("Dep_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("department");
                });

            modelBuilder.Entity("Lab_One.Models.CrsResult", b =>
                {
                    b.HasOne("Lab_One.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("Crs_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lab_One.Models.Trainee", "trainee")
                        .WithMany()
                        .HasForeignKey("Trainee_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("trainee");
                });

            modelBuilder.Entity("Lab_One.Models.Instructor", b =>
                {
                    b.HasOne("Lab_One.Models.Course", "course")
                        .WithMany("Instructors")
                        .HasForeignKey("Crs_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lab_One.Models.Department", "department")
                        .WithMany("Instructors")
                        .HasForeignKey("Dept_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("course");

                    b.Navigation("department");
                });

            modelBuilder.Entity("Lab_One.Models.Trainee", b =>
                {
                    b.HasOne("Lab_One.Models.Department", "department")
                        .WithMany("Trainees")
                        .HasForeignKey("Dept_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("department");
                });

            modelBuilder.Entity("Lab_One.Models.Course", b =>
                {
                    b.Navigation("Instructors");
                });

            modelBuilder.Entity("Lab_One.Models.Department", b =>
                {
                    b.Navigation("Courses");

                    b.Navigation("Instructors");

                    b.Navigation("Trainees");
                });
#pragma warning restore 612, 618
        }
    }
}
