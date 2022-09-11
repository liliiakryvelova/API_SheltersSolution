﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Shelters.Models;

namespace Shelters.Migrations
{
    [DbContext(typeof(ShelterContext))]
    [Migration("20220911005837_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Shelters.Models.Shelter", b =>
                {
                    b.Property<int>("ShelterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("ShelterName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("ShelterId");

                    b.ToTable("Shelters");

                    b.HasData(
                        new
                        {
                            ShelterId = 1,
                            Date = new DateTime(2022, 9, 10, 17, 58, 37, 647, DateTimeKind.Local).AddTicks(1883),
                            ShelterName = "Hope"
                        },
                        new
                        {
                            ShelterId = 2,
                            Date = new DateTime(2022, 9, 10, 17, 58, 37, 647, DateTimeKind.Local).AddTicks(2516),
                            ShelterName = "Life"
                        },
                        new
                        {
                            ShelterId = 3,
                            Date = new DateTime(2022, 9, 10, 17, 58, 37, 647, DateTimeKind.Local).AddTicks(2527),
                            ShelterName = "Clean the room"
                        },
                        new
                        {
                            ShelterId = 4,
                            Date = new DateTime(2022, 9, 10, 17, 58, 37, 647, DateTimeKind.Local).AddTicks(2530),
                            ShelterName = "Four paws"
                        },
                        new
                        {
                            ShelterId = 5,
                            Date = new DateTime(2022, 9, 10, 17, 58, 37, 647, DateTimeKind.Local).AddTicks(2532),
                            ShelterName = "My friend"
                        },
                        new
                        {
                            ShelterId = 6,
                            Date = new DateTime(2022, 9, 10, 17, 58, 37, 647, DateTimeKind.Local).AddTicks(2534),
                            ShelterName = "Last tear"
                        });
                });

            modelBuilder.Entity("Shelters.Models.ShelterData", b =>
                {
                    b.Property<int>("ShelterDataId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CatsNumber")
                        .HasColumnType("int");

                    b.Property<int>("DogsNumber")
                        .HasColumnType("int");

                    b.Property<int>("ShelterId")
                        .HasColumnType("int");

                    b.HasKey("ShelterDataId");

                    b.ToTable("ShelterData");

                    b.HasData(
                        new
                        {
                            ShelterDataId = 1,
                            CatsNumber = 4,
                            DogsNumber = 3,
                            ShelterId = 1
                        },
                        new
                        {
                            ShelterDataId = 2,
                            CatsNumber = 5,
                            DogsNumber = 8,
                            ShelterId = 2
                        },
                        new
                        {
                            ShelterDataId = 3,
                            CatsNumber = 1,
                            DogsNumber = 7,
                            ShelterId = 3
                        },
                        new
                        {
                            ShelterDataId = 4,
                            CatsNumber = 17,
                            DogsNumber = 5,
                            ShelterId = 4
                        },
                        new
                        {
                            ShelterDataId = 5,
                            CatsNumber = 7,
                            DogsNumber = 3,
                            ShelterId = 5
                        },
                        new
                        {
                            ShelterDataId = 6,
                            CatsNumber = 6,
                            DogsNumber = 10,
                            ShelterId = 6
                        });
                });
#pragma warning restore 612, 618
        }
    }
}