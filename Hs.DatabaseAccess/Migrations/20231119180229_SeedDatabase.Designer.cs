﻿// <auto-generated />
using System;
using Hs.DatabaseAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hs.DatabaseAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231119180229_SeedDatabase")]
    partial class SeedDatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Hs.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDateTime = new DateTime(2023, 11, 19, 22, 2, 29, 282, DateTimeKind.Local).AddTicks(1224),
                            DisplayOrder = 1,
                            Name = "Home Interiors"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDateTime = new DateTime(2023, 11, 19, 22, 2, 29, 282, DateTimeKind.Local).AddTicks(1240),
                            DisplayOrder = 2,
                            Name = "Clothes & wears"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDateTime = new DateTime(2023, 11, 19, 22, 2, 29, 282, DateTimeKind.Local).AddTicks(1242),
                            DisplayOrder = 3,
                            Name = "Computer & tech"
                        });
                });

            modelBuilder.Entity("Hs.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Brandname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Prices")
                        .HasColumnType("float");

                    b.Property<string>("Productname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Quantities")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brandname = "Ibanez",
                            Description = "This Guiter is electric",
                            Prices = 1250.0,
                            Productname = "Guitar",
                            Quantities = 20.0
                        },
                        new
                        {
                            Id = 2,
                            Brandname = "Fender",
                            Description = "This Guiter is from Fender",
                            Prices = 2550.0,
                            Productname = "Piano",
                            Quantities = 13.0
                        },
                        new
                        {
                            Id = 3,
                            Brandname = "Gibson Brand, Inc",
                            Description = "This Guiter is from Gibson Brand, Inc",
                            Prices = 3450.0,
                            Productname = "Drum",
                            Quantities = 4.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}