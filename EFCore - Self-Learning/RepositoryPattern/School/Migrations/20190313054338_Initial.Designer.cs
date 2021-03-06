﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SoftUni.Data;

namespace SoftUni.Migrations
{
    [DbContext(typeof(SoftUniDbContext))]
    [Migration("20190313054338_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SoftUni.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1500);

                    b.Property<decimal>("FullPrice");

                    b.Property<int>("Level");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("TeacherId");

                    b.HasKey("Id");

                    b.HasIndex("TeacherId");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Description for C# Basics",
                            FullPrice = 49m,
                            Level = 1,
                            Name = "C# Basics",
                            TeacherId = 1
                        },
                        new
                        {
                            Id = 2,
                            Description = "Description for C# Intermediate",
                            FullPrice = 49m,
                            Level = 2,
                            Name = "C# Intermediate",
                            TeacherId = 4
                        },
                        new
                        {
                            Id = 3,
                            Description = "Description for C# Advanced",
                            FullPrice = 69m,
                            Level = 3,
                            Name = "C# Advanced",
                            TeacherId = 5
                        },
                        new
                        {
                            Id = 4,
                            Description = "Description for Javascript",
                            FullPrice = 149m,
                            Level = 2,
                            Name = "Javascript: Understanding the Weird Parts",
                            TeacherId = 1
                        },
                        new
                        {
                            Id = 5,
                            Description = "Description for AngularJS",
                            FullPrice = 99m,
                            Level = 2,
                            Name = "Learn and Understand AngularJS",
                            TeacherId = 3
                        },
                        new
                        {
                            Id = 6,
                            Description = "Description for NodeJS",
                            FullPrice = 149m,
                            Level = 2,
                            Name = "Learn and Understand NodeJS",
                            TeacherId = 2
                        },
                        new
                        {
                            Id = 7,
                            Description = "Description for Programming for Beginners",
                            FullPrice = 45m,
                            Level = 1,
                            Name = "Programming for Complete Beginners",
                            TeacherId = 1
                        },
                        new
                        {
                            Id = 8,
                            Description = "Description 16 Hour Course",
                            FullPrice = 150m,
                            Level = 1,
                            Name = "A 16 Hour C# Course with Visual Studio 2013",
                            TeacherId = 3
                        },
                        new
                        {
                            Id = 9,
                            Description = "Description Learn Javascript",
                            FullPrice = 20m,
                            Level = 1,
                            Name = "Learn JavaScript Through Visual Studio 2013",
                            TeacherId = 4
                        });
                });

            modelBuilder.Entity("SoftUni.Models.CourseTag", b =>
                {
                    b.Property<int>("TagId");

                    b.Property<int>("CourseId");

                    b.HasKey("TagId", "CourseId");

                    b.HasIndex("CourseId");

                    b.ToTable("CourseTag");
                });

            modelBuilder.Entity("SoftUni.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Tags");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "c#"
                        },
                        new
                        {
                            Id = 2,
                            Name = "angularjs"
                        },
                        new
                        {
                            Id = 3,
                            Name = "javascript"
                        },
                        new
                        {
                            Id = 4,
                            Name = "nodejs"
                        },
                        new
                        {
                            Id = 5,
                            Name = "oop"
                        },
                        new
                        {
                            Id = 6,
                            Name = "linq"
                        });
                });

            modelBuilder.Entity("SoftUni.Models.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.ToTable("Teachers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Mosh Hamedani"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Anthony Alicea"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Eric Wise"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Tom Owsiak"
                        },
                        new
                        {
                            Id = 5,
                            Name = "John Smith"
                        });
                });

            modelBuilder.Entity("SoftUni.Models.Course", b =>
                {
                    b.HasOne("SoftUni.Models.Teacher", "Teacher")
                        .WithMany("Courses")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SoftUni.Models.CourseTag", b =>
                {
                    b.HasOne("SoftUni.Models.Course", "Course")
                        .WithMany("CourseTags")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SoftUni.Models.Tag", "Tag")
                        .WithMany("CourseTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
