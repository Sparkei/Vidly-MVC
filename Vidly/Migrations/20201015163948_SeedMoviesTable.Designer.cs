﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Vidly.Data;

namespace Vidly.Migrations
{
    [DbContext(typeof(VidlyMovieContext))]
    [Migration("20201015163948_SeedMoviesTable")]
    partial class SeedMoviesTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Vidly.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Genre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Movie");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Genre = "Romantic Comedy",
                            Price = 7.99m,
                            ReleaseDate = new DateTime(1989, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "When Harry Met Sally"
                        },
                        new
                        {
                            Id = 2,
                            Genre = "Comedy",
                            Price = 8.99m,
                            ReleaseDate = new DateTime(1984, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Ghostbusters "
                        },
                        new
                        {
                            Id = 3,
                            Genre = "Comedy",
                            Price = 9.99m,
                            ReleaseDate = new DateTime(1986, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Ghostbusters 2"
                        },
                        new
                        {
                            Id = 4,
                            Genre = "Western",
                            Price = 3.99m,
                            ReleaseDate = new DateTime(1959, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Rio Bravo"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
