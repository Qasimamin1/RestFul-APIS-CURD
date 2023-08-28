﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VillaRestFulAPI.Data;

#nullable disable

namespace VillaRestFulAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("VillaRestFulAPI.Models.Villa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Amenity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Occupancy")
                        .HasColumnType("int");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.Property<int>("Sqft")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Villas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amenity = "",
                            CreatedDate = new DateTime(2023, 8, 22, 14, 9, 31, 724, DateTimeKind.Local).AddTicks(2472),
                            Details = "This villa is available for now",
                            ImageUrl = "https://images.unsplash.com/photo-1586106195724-b1a1e3857559?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80",
                            Name = "Royal Villa",
                            Occupancy = 5,
                            Rate = 200.0,
                            Sqft = 500,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Amenity = "",
                            CreatedDate = new DateTime(2023, 8, 22, 14, 9, 31, 724, DateTimeKind.Local).AddTicks(2566),
                            Details = "Sea facing beauty",
                            ImageUrl = "https://example.com/oceanvilla.jpg",
                            Name = "Ocean Villa",
                            Occupancy = 4,
                            Rate = 250.0,
                            Sqft = 550,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            Amenity = "",
                            CreatedDate = new DateTime(2023, 8, 22, 14, 9, 31, 724, DateTimeKind.Local).AddTicks(2570),
                            Details = "Mountain view",
                            ImageUrl = "https://example.com/mountainvilla.jpg",
                            Name = "Mountain Villa",
                            Occupancy = 6,
                            Rate = 180.0,
                            Sqft = 620,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            Amenity = "",
                            CreatedDate = new DateTime(2023, 8, 22, 14, 9, 31, 724, DateTimeKind.Local).AddTicks(2573),
                            Details = "City center location",
                            ImageUrl = "https://example.com/urbanvilla.jpg",
                            Name = "Urban Villa",
                            Occupancy = 4,
                            Rate = 220.0,
                            Sqft = 480,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            Amenity = "",
                            CreatedDate = new DateTime(2023, 8, 22, 14, 9, 31, 724, DateTimeKind.Local).AddTicks(2577),
                            Details = "Located in the serene desert",
                            ImageUrl = "https://example.com/desertvilla.jpg",
                            Name = "Desert Villa",
                            Occupancy = 3,
                            Rate = 210.0,
                            Sqft = 460,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
