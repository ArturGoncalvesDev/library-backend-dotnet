﻿// <auto-generated />
using System;
using Livraria.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Livraria.API.Migrations
{
    [DbContext(typeof(LibraryContext))]
    [Migration("20220904213323_initMySQL")]
    partial class initMySQL
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            Name = "Banco de Dados",
                            PublisherId = 2,
                            Quantity = 98,
                            TotalRented = 2
                        },
                        new
                        {
                            Id = 2,
                            Author = "Deitel",
                            Launch = new DateTime(2005, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Redes de Computadores",
                            PublisherId = 1,
                            Quantity = 99,
                            TotalRented = 1
                        },
                        new
                        {
                            Id = 3,
                            Author = "Deitel",
                            Launch = new DateTime(2004, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Java Prático",
                            PublisherId = 3,
                            Quantity = 99,
                            TotalRented = 1
                        },
                        new
                        {
                            Id = 4,
                            Author = "Cormen",
                            Launch = new DateTime(2006, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Sistemas Operacionais",
                            PublisherId = 2,
                            Quantity = 99,
                            TotalRented = 1
                        },
                        new
                        {
                            Id = 5,
                            Author = "Cormen",
                            Launch = new DateTime(2005, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Algoritmos",
                            PublisherId = 1,
                            Quantity = 99,
                            TotalRented = 1
                        },
                        new
                        {
                            Id = 6,
                            Author = "Deitel",
                            Launch = new DateTime(2006, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Programando em C++",
                            PublisherId = 2,
                            Quantity = 100,
                            TotalRented = 0
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
                        },
                        new
                        {
                            Id = 2,
                            City = "Rio de Janeiro",
                            Name = "Campus"
                        },
                        new
                        {
                            Id = 3,
                            City = "São Paulo",
                            Name = "Pearson"
                        },
                        new
                        {
                            Id = 4,
                            City = "São Paulo",
                            Name = "Bookman"
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

                    b.Property<DateTime>("Return_date")
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
                            Forecast_Date = new DateTime(2022, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Rental_Date = new DateTime(2022, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Return_date = new DateTime(2022, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Returned_Book = false,
                            UserId = 2
                        },
                        new
                        {
                            Id = 2,
                            BookId = 2,
                            Forecast_Date = new DateTime(2022, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Rental_Date = new DateTime(2022, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Return_date = new DateTime(2022, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Returned_Book = false,
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            BookId = 5,
                            Forecast_Date = new DateTime(2022, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Rental_Date = new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Return_date = new DateTime(2022, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Returned_Book = false,
                            UserId = 4
                        },
                        new
                        {
                            Id = 4,
                            BookId = 3,
                            Forecast_Date = new DateTime(2022, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Rental_Date = new DateTime(2022, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Return_date = new DateTime(2022, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Returned_Book = false,
                            UserId = 1
                        },
                        new
                        {
                            Id = 5,
                            BookId = 1,
                            Forecast_Date = new DateTime(2022, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Rental_Date = new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Return_date = new DateTime(2022, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Returned_Book = false,
                            UserId = 3
                        },
                        new
                        {
                            Id = 6,
                            BookId = 2,
                            Forecast_Date = new DateTime(2022, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Rental_Date = new DateTime(2022, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Return_date = new DateTime(2022, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Returned_Book = false,
                            UserId = 3
                        },
                        new
                        {
                            Id = 7,
                            BookId = 4,
                            Forecast_Date = new DateTime(2022, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Rental_Date = new DateTime(2022, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Return_date = new DateTime(2022, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Returned_Book = false,
                            UserId = 4
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
                        },
                        new
                        {
                            Id = 2,
                            Address = "Av. B, 1200",
                            City = "Caucaia",
                            Email = "ms@gmail",
                            Name = "Marcelo Silva"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Rua C, 87",
                            City = "São Paulo",
                            Email = "aguiar@ig",
                            Name = "Carlos Aguiar"
                        },
                        new
                        {
                            Id = 4,
                            Address = "Rua D, 120",
                            City = "Fortaleza",
                            Email = "rporto@bol",
                            Name = "Roberto Porto"
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