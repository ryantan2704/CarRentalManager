﻿// <auto-generated />
using System;
using CarRentalManager.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarRentalManager.Migrations
{
    [DbContext(typeof(CarRentalManagerContext))]
    [Migration("20241118085752_SeedData")]
    partial class SeedData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CarRentalManager.Domain.Bookings", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateIn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOut")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VehicleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("CarRentalManager.Domain.Colours", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Colours");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2024, 11, 18, 16, 57, 51, 475, DateTimeKind.Local).AddTicks(1092),
                            DateUpdated = new DateTime(2024, 11, 18, 16, 57, 51, 475, DateTimeKind.Local).AddTicks(1106),
                            Name = "Black",
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2024, 11, 18, 16, 57, 51, 475, DateTimeKind.Local).AddTicks(1108),
                            DateUpdated = new DateTime(2024, 11, 18, 16, 57, 51, 475, DateTimeKind.Local).AddTicks(1109),
                            Name = "Blue",
                            UpdatedBy = "System"
                        });
                });

            modelBuilder.Entity("CarRentalManager.Domain.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("DrivingLicense")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("CarRentalManager.Domain.Make", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Make");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "Syntax",
                            DateCreated = new DateTime(2024, 11, 18, 16, 57, 51, 475, DateTimeKind.Local).AddTicks(1350),
                            DateUpdated = new DateTime(2024, 11, 18, 16, 57, 51, 475, DateTimeKind.Local).AddTicks(1351),
                            Name = "BMW",
                            UpdatedBy = "Syntax"
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "Syntax",
                            DateCreated = new DateTime(2024, 11, 18, 16, 57, 51, 475, DateTimeKind.Local).AddTicks(1353),
                            DateUpdated = new DateTime(2024, 11, 18, 16, 57, 51, 475, DateTimeKind.Local).AddTicks(1354),
                            Name = "Toyota",
                            UpdatedBy = "Syntax"
                        });
                });

            modelBuilder.Entity("CarRentalManager.Domain.Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Model");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "Syntax",
                            DateCreated = new DateTime(2024, 11, 18, 16, 57, 51, 475, DateTimeKind.Local).AddTicks(1442),
                            DateUpdated = new DateTime(2024, 11, 18, 16, 57, 51, 475, DateTimeKind.Local).AddTicks(1443),
                            Name = "i4",
                            UpdatedBy = "Syntax"
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "Syntax",
                            DateCreated = new DateTime(2024, 11, 18, 16, 57, 51, 475, DateTimeKind.Local).AddTicks(1445),
                            DateUpdated = new DateTime(2024, 11, 18, 16, 57, 51, 475, DateTimeKind.Local).AddTicks(1445),
                            Name = "X5",
                            UpdatedBy = "Syntax"
                        },
                        new
                        {
                            Id = 3,
                            CreatedBy = "Syntax",
                            DateCreated = new DateTime(2024, 11, 18, 16, 57, 51, 475, DateTimeKind.Local).AddTicks(1447),
                            DateUpdated = new DateTime(2024, 11, 18, 16, 57, 51, 475, DateTimeKind.Local).AddTicks(1447),
                            Name = "Prius",
                            UpdatedBy = "Syntax"
                        },
                        new
                        {
                            Id = 4,
                            CreatedBy = "Syntax",
                            DateCreated = new DateTime(2024, 11, 18, 16, 57, 51, 475, DateTimeKind.Local).AddTicks(1449),
                            DateUpdated = new DateTime(2024, 11, 18, 16, 57, 51, 475, DateTimeKind.Local).AddTicks(1449),
                            Name = "C-HR",
                            UpdatedBy = "Syntax"
                        });
                });

            modelBuilder.Entity("CarRentalManager.Domain.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("LicensePlateNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MakeId")
                        .HasColumnType("int");

                    b.Property<int>("ModelId")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.Property<int>("colourId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Vehicle");
                });
#pragma warning restore 612, 618
        }
    }
}