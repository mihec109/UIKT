﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using projekt.Models;

#nullable disable

namespace projekt.Migrations
{
    [DbContext(typeof(ContextDB))]
    partial class ContextDBModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.13");

            modelBuilder.Entity("projekt.Models.DokumentiModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Uporabnik")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("UporabnikModelId")
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("dodato")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<byte[]>("obrazec")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<byte[]>("pravnaPodlaga")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.HasKey("id");

                    b.HasIndex("UporabnikModelId");

                    b.ToTable("Dokumenti");
                });

            modelBuilder.Entity("projekt.Models.UporabnikModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Geslo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Geslo2")
                        .HasColumnType("TEXT");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Priimek")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Uporabniki");
                });

            modelBuilder.Entity("projekt.Models.DokumentiModel", b =>
                {
                    b.HasOne("projekt.Models.UporabnikModel", null)
                        .WithMany("Dokumenti")
                        .HasForeignKey("UporabnikModelId");
                });

            modelBuilder.Entity("projekt.Models.UporabnikModel", b =>
                {
                    b.Navigation("Dokumenti");
                });
#pragma warning restore 612, 618
        }
    }
}
