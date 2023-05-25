﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VirtualDj.Data;

#nullable disable

namespace VirtualDj.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230525122435_User")]
    partial class User
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("VirtualDj.Models.Pjesma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Izvodjac")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("NazivPjesme")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Tip")
                        .HasColumnType("int");

                    b.Property<int>("Trending")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Pjesme");
                });

            modelBuilder.Entity("VirtualDj.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("longblob");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("longblob");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
