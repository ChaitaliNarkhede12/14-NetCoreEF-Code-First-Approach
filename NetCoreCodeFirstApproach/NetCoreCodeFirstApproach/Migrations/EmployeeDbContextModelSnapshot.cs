﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetCoreCodeFirstApproach.Context;

namespace NetCoreCodeFirstApproach.Migrations
{
    [DbContext(typeof(EmployeeDbContext))]
    partial class EmployeeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NetCoreCodeFirstApproach.Context.Department", b =>
                {
                    b.Property<int>("DeptId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DeptLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeptName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DeptId");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            DeptId = 1,
                            DeptName = "IT"
                        });
                });

            modelBuilder.Entity("NetCoreCodeFirstApproach.Context.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Designation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Salary")
                        .HasColumnType("int");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            Address = "New York",
                            CompanyName = "XYZ Inc",
                            Designation = "Developer",
                            Name = "John",
                            Salary = 0
                        },
                        new
                        {
                            EmployeeId = 2,
                            Address = "New York",
                            CompanyName = "ABC Inc",
                            Designation = "Manager",
                            Name = "Chris",
                            Salary = 0
                        },
                        new
                        {
                            EmployeeId = 3,
                            Address = "New Delhi",
                            CompanyName = "XYZ Inc",
                            Designation = "Consultant",
                            Name = "Mukesh",
                            Salary = 0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}