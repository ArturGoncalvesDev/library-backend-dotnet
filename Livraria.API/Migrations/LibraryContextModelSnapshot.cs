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
                .HasAnnotation("ProductVersion", "3.1.0");

            modelBuilder.Entity("Livraria.API.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Author")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Launch")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("PublisherId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TotalRented")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PublisherId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Juliano Santos",
                            Launch = new DateTime(2010, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Clear Code",
                            PublisherId = 2,
                            Quantity = 10,
                            TotalRented = 23
                        },
                        new
                        {
                            Id = 2,
                            Author = "Alex Santos",
                            Launch = new DateTime(2010, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Logica de Programação",
                            PublisherId = 1,
                            Quantity = 68,
                            TotalRented = 90
                        },
                        new
                        {
                            Id = 3,
                            Author = "Raquel Lovewood",
                            Launch = new DateTime(2010, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "PHP e Laravel",
                            PublisherId = 3,
                            Quantity = 10,
                            TotalRented = 36
                        },
                        new
                        {
                            Id = 4,
                            Author = "Ana Luana",
                            Launch = new DateTime(2010, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Dicionário do Programador",
                            PublisherId = 1,
                            Quantity = 3,
                            TotalRented = 23
                        });
                });

            modelBuilder.Entity("Livraria.API.Models.Publisher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Publishers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "São Paulo",
                            Name = "Informatica Lite"
                        },
                        new
                        {
                            Id = 2,
                            City = "Horizonte",
                            Name = "Expresso Tec"
                        },
                        new
                        {
                            Id = 3,
                            City = "São Paulo",
                            Name = "Nuvem Logica"
                        });
                });

            modelBuilder.Entity("Livraria.API.Models.Rental", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BookId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Forecast_Date")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Rental_Date")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Return_date")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("UserId");

                    b.ToTable("Rentals");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BookId = 4,
                            Forecast_Date = new DateTime(2010, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Rental_Date = new DateTime(2010, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Return_date = new DateTime(2010, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            BookId = 3,
                            Forecast_Date = new DateTime(2010, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Rental_Date = new DateTime(2010, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Return_date = new DateTime(2010, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 3
                        },
                        new
                        {
                            Id = 3,
                            BookId = 1,
                            Forecast_Date = new DateTime(2010, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Rental_Date = new DateTime(2010, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Return_date = new DateTime(2010, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 4
                        },
                        new
                        {
                            Id = 4,
                            BookId = 2,
                            Forecast_Date = new DateTime(2010, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Rental_Date = new DateTime(2010, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Return_date = new DateTime(2010, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1
                        },
                        new
                        {
                            Id = 5,
                            BookId = 3,
                            Forecast_Date = new DateTime(2010, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Rental_Date = new DateTime(2010, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Return_date = new DateTime(2010, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 2
                        });
                });

            modelBuilder.Entity("Livraria.API.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Rua A",
                            City = "Fortaleza",
                            Email = "Artur@gmail.com",
                            Name = "Artur"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Rua T",
                            City = "Caucaia",
                            Email = "Ana@gmail.com",
                            Name = "Ana"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Rua K",
                            City = "São Paulo",
                            Email = "Vilma@gmail.com",
                            Name = "Vilma"
                        },
                        new
                        {
                            Id = 4,
                            Address = "Rua E",
                            City = "Fortaleza",
                            Email = "Vitor@gmail.com",
                            Name = "Vitor"
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
