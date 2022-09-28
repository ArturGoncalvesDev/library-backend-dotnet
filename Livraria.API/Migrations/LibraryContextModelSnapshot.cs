﻿// <auto-generated />
using System;
using Livraria.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Livraria.API.Migrations
{
    [DbContext(typeof(LibraryContext))]
    partial class LibraryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Livraria.API.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Author")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("Launch")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("MaxRented")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("PublisherId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("TotalRented")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PublisherId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Navathe",
                            Launch = new DateTime(2002, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MaxRented = 1,
                            Name = "Banco de Dados",
                            PublisherId = 1,
                            Quantity = 49,
                            TotalRented = 1
                        });
                });

            modelBuilder.Entity("Livraria.API.Models.Publisher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Publishers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "São Paulo",
                            Name = "Makron"
                        });
                });

            modelBuilder.Entity("Livraria.API.Models.Rental", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Forecast_Date")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Rental_Date")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Return_Date")
                        .HasColumnType("datetime(6)");

                    b.Property<bool?>("Returned_Book")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("UserId");

                    b.ToTable("Rentals");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BookId = 1,
                            Forecast_Date = new DateTime(2022, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Rental_Date = new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Return_Date = new DateTime(2022, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Returned_Book = true,
                            UserId = 2
                        });
                });

            modelBuilder.Entity("Livraria.API.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("City")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Rua A,190",
                            City = "Fortaleza",
                            Email = "joão@bol",
                            Name = "João Lopes"
                        });
                });

            modelBuilder.Entity("Livraria.API.Models.Book", b =>
                {
                    b.HasOne("Livraria.API.Models.Publisher", "Publisher")
                        .WithMany()
                        .HasForeignKey("PublisherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Livraria.API.Models.Rental", b =>
                {
                    b.HasOne("Livraria.API.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Livraria.API.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
