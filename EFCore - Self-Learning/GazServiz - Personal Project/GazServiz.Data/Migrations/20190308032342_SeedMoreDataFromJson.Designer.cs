﻿// <auto-generated />
using System;
using GazServiz.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GazServiz.Data.Migrations
{
    [DbContext(typeof(GarageDbContext))]
    [Migration("20190308032342_SeedMoreDataFromJson")]
    partial class SeedMoreDataFromJson
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GazServiz.Models.Car", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LicensePlate")
                        .IsRequired();

                    b.Property<double>("Millage");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(true);

                    b.Property<int>("OwnerId");

                    b.HasKey("id")
                        .HasName("CarId");

                    b.HasAlternateKey("LicensePlate");

                    b.HasIndex("OwnerId");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            id = 1,
                            LicensePlate = "�� 1016 ��",
                            Millage = 100000.2,
                            Model = "Fiat",
                            OwnerId = 1
                        },
                        new
                        {
                            id = 2,
                            LicensePlate = "A 7777 ��",
                            Millage = 15000.0,
                            Model = "Aston Martin",
                            OwnerId = 3
                        },
                        new
                        {
                            id = 3,
                            LicensePlate = "�� 1515 ��",
                            Millage = 150000.98999999999,
                            Model = "BMW",
                            OwnerId = 1
                        });
                });

            modelBuilder.Entity("GazServiz.Models.Employee", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(32)
                        .IsUnicode(true);

                    b.Property<string>("Speciality")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue("Windows");

                    b.HasKey("id")
                        .HasName("EmployeeId");

                    b.ToTable("Emoloyees");

                    b.HasData(
                        new
                        {
                            id = 1,
                            Name = "Bai Ivan",
                            Speciality = "Windows"
                        },
                        new
                        {
                            id = 2,
                            Name = "Todor",
                            Speciality = "Engine"
                        },
                        new
                        {
                            id = 3,
                            Name = "The Master",
                            Speciality = "GearBox"
                        });
                });

            modelBuilder.Entity("GazServiz.Models.Owner", b =>
                {
                    b.Property<int>("ownerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("MiddleName");

                    b.Property<string>("Mobile")
                        .IsRequired();

                    b.HasKey("ownerId")
                        .HasName("OWNERID");

                    b.HasAlternateKey("Mobile");

                    b.ToTable("Owners");

                    b.HasData(
                        new
                        {
                            ownerId = 1,
                            FirstName = "Sara",
                            LastName = "Strom",
                            Mobile = "+01999345890"
                        },
                        new
                        {
                            ownerId = 2,
                            FirstName = "Panaiot",
                            LastName = "Minkov",
                            Mobile = "0887200159"
                        },
                        new
                        {
                            ownerId = 3,
                            FirstName = "Vanq",
                            LastName = "Kamburova",
                            Mobile = "0292393291"
                        });
                });

            modelBuilder.Entity("GazServiz.Models.Repair", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal?>("Bill");

                    b.Property<int>("CarId");

                    b.Property<DateTime>("DateIn");

                    b.Property<DateTime?>("DateOut");

                    b.Property<int>("EmployeeId");

                    b.Property<string>("IsFixed")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 4)))
                        .HasDefaultValue("Nope");

                    b.Property<string>("ProblemDescription")
                        .HasMaxLength(1000)
                        .IsUnicode(true);

                    b.HasKey("id")
                        .HasName("RepairId");

                    b.HasIndex("CarId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Repairs");

                    b.HasData(
                        new
                        {
                            id = 1,
                            CarId = 2,
                            DateIn = new DateTime(2019, 3, 8, 5, 23, 38, 183, DateTimeKind.Local).AddTicks(1829),
                            EmployeeId = 3,
                            IsFixed = "Nope",
                            ProblemDescription = "����� �� ����� - ��������� �����!"
                        },
                        new
                        {
                            id = 2,
                            CarId = 1,
                            DateIn = new DateTime(2019, 3, 8, 5, 23, 38, 193, DateTimeKind.Local).AddTicks(3866),
                            EmployeeId = 1,
                            IsFixed = "Nope",
                            ProblemDescription = "��������� ������� �� ��. ���������"
                        },
                        new
                        {
                            id = 3,
                            CarId = 3,
                            DateIn = new DateTime(2019, 3, 8, 5, 23, 38, 193, DateTimeKind.Local).AddTicks(4066),
                            EmployeeId = 2,
                            IsFixed = "Nope",
                            ProblemDescription = "��������� �� ������"
                        });
                });

            modelBuilder.Entity("GazServiz.Models.Car", b =>
                {
                    b.HasOne("GazServiz.Models.Owner", "Owner")
                        .WithMany("Cars")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GazServiz.Models.Repair", b =>
                {
                    b.HasOne("GazServiz.Models.Car", "Car")
                        .WithMany("Repairs")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GazServiz.Models.Employee", "Employee")
                        .WithMany("Repairs")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
