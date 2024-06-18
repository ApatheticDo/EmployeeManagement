﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Models;

#nullable disable

namespace EmployeeManagement.Migrations
{
    [DbContext(typeof(EmployeeMngDbContext))]
    [Migration("20240522073955_ReCreate_NewTables")]
    partial class ReCreate_NewTables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EmployeeManagement.Models.Admin", b =>
                {
                    b.Property<int>("Admin_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Admin_Id"));

                    b.Property<string>("Admin_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedOn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Divi_Id")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdateBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdateOn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Admin_Id");

                    b.HasIndex("Divi_Id");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("EmployeeManagement.Models.Department", b =>
                {
                    b.Property<int>("Depa_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Depa_id"));

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedOn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Depa_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Divi_Id")
                        .HasColumnType("int");

                    b.Property<string>("UpdateBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdateOn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Depa_id");

                    b.HasIndex("Divi_Id");

                    b.ToTable("Deparments");
                });

            modelBuilder.Entity("EmployeeManagement.Models.Division", b =>
                {
                    b.Property<int>("Divi_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Divi_Id"));

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedOn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Divi_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdateBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdateOn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Divi_Id");

                    b.ToTable("Divisions");
                });

            modelBuilder.Entity("EmployeeManagement.Models.Section", b =>
                {
                    b.Property<int>("Sec_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Sec_id"));

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedOn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Depa_id")
                        .HasColumnType("int");

                    b.Property<string>("Sec_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdateBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdateOn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Sec_id");

                    b.HasIndex("Depa_id");

                    b.ToTable("Sections");
                });

            modelBuilder.Entity("WebApplication1.Models.Education", b =>
                {
                    b.Property<int>("Edu_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Edu_Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Edu_Id");

                    b.ToTable("Educations");
                });

            modelBuilder.Entity("WebApplication1.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedOn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dob")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Edu_Id")
                        .HasColumnType("int");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Sec_id")
                        .HasColumnType("int");

                    b.Property<string>("Sex")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdateBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdateOn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Edu_Id");

                    b.HasIndex("Sec_id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("EmployeeManagement.Models.Admin", b =>
                {
                    b.HasOne("EmployeeManagement.Models.Division", "Division")
                        .WithMany("Admin")
                        .HasForeignKey("Divi_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Division");
                });

            modelBuilder.Entity("EmployeeManagement.Models.Department", b =>
                {
                    b.HasOne("EmployeeManagement.Models.Division", "Division")
                        .WithMany("Deparment")
                        .HasForeignKey("Divi_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Division");
                });

            modelBuilder.Entity("EmployeeManagement.Models.Section", b =>
                {
                    b.HasOne("EmployeeManagement.Models.Department", "Deparment")
                        .WithMany("Section")
                        .HasForeignKey("Depa_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Deparment");
                });

            modelBuilder.Entity("WebApplication1.Models.Employee", b =>
                {
                    b.HasOne("WebApplication1.Models.Education", "Education")
                        .WithMany("Employee")
                        .HasForeignKey("Edu_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EmployeeManagement.Models.Section", "Section")
                        .WithMany("Employee")
                        .HasForeignKey("Sec_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Education");

                    b.Navigation("Section");
                });

            modelBuilder.Entity("EmployeeManagement.Models.Department", b =>
                {
                    b.Navigation("Section");
                });

            modelBuilder.Entity("EmployeeManagement.Models.Division", b =>
                {
                    b.Navigation("Admin");

                    b.Navigation("Deparment");
                });

            modelBuilder.Entity("EmployeeManagement.Models.Section", b =>
                {
                    b.Navigation("Employee");
                });

            modelBuilder.Entity("WebApplication1.Models.Education", b =>
                {
                    b.Navigation("Employee");
                });
#pragma warning restore 612, 618
        }
    }
}
