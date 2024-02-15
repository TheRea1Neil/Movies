﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Movies.Models;

#nullable disable

namespace Movies.Migrations
{
    [DbContext(typeof(MovieContext))]
    [Migration("20240215063618_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.2");

            modelBuilder.Entity("Movies.Models.Movie", b =>
                {
                    b.Property<int>("Mission06_MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Mission06_Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Mission06_Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Mission06_Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Mission06_Lent_To")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Mission06_Notes")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("TEXT");

                    b.Property<string>("Mission06_Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Mission06_Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Mission06_Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("Mission06_MovieId");

                    b.ToTable("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}
