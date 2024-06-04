﻿// <auto-generated />
using System;
using EFDiyetProgramiProje_DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFDiyetProgramiProje_DAL.Migrations
{
    [DbContext(typeof(DiyetProgramiDbContext))]
    [Migration("20240604131712_mig2")]
    partial class mig2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EFDiyetProgramiProje_DAL.Entities.Kullanici", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("DataStatus")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("KullaniciBilgiId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("KullaniciBilgiId")
                        .IsUnique();

                    b.ToTable("Kullanicilar");
                });

            modelBuilder.Entity("EFDiyetProgramiProje_DAL.Entities.KullaniciBilgi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double?>("Boy")
                        .HasColumnType("float");

                    b.Property<string>("Cinsiyet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("DataStatus")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedTime")
                        .HasColumnType("datetime2");

                    b.Property<double?>("Kilo")
                        .HasColumnType("float");

                    b.Property<DateTime?>("ModifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Yas")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("KullaniciBilgiler");
                });

            modelBuilder.Entity("EFDiyetProgramiProje_DAL.Entities.KullaniciOgunYemek", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("DataStatus")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("KullaniciId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("OgunYemekId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KullaniciId");

                    b.ToTable("KullaniciOgunYemekler");
                });

            modelBuilder.Entity("EFDiyetProgramiProje_DAL.Entities.Ogun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("DataStatus")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("OgunAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ogunler");
                });

            modelBuilder.Entity("EFDiyetProgramiProje_DAL.Entities.OgunYemek", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BirimAdedi")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("DataStatus")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("KullaniciOgunYemekId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("OgunId")
                        .HasColumnType("int");

                    b.Property<DateOnly>("Tarih")
                        .HasColumnType("date");

                    b.Property<int>("YemekId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KullaniciOgunYemekId");

                    b.HasIndex("OgunId");

                    b.HasIndex("YemekId");

                    b.ToTable("OgunYemekler");
                });

            modelBuilder.Entity("EFDiyetProgramiProje_DAL.Entities.Yemek", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Birim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("DataStatus")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedTime")
                        .HasColumnType("datetime2");

                    b.Property<double>("Kalori")
                        .HasColumnType("float");

                    b.Property<int>("KategoriId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("YemekAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YemekKategoriId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("YemekKategoriId");

                    b.ToTable("Yemekler");
                });

            modelBuilder.Entity("EFDiyetProgramiProje_DAL.Entities.YemekKategori", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("DataStatus")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("KategoriAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("YemekKategoriler");
                });

            modelBuilder.Entity("EFDiyetProgramiProje_DAL.Entities.Kullanici", b =>
                {
                    b.HasOne("EFDiyetProgramiProje_DAL.Entities.KullaniciBilgi", "KullaniciBilgi")
                        .WithOne("Kullanici")
                        .HasForeignKey("EFDiyetProgramiProje_DAL.Entities.Kullanici", "KullaniciBilgiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KullaniciBilgi");
                });

            modelBuilder.Entity("EFDiyetProgramiProje_DAL.Entities.KullaniciOgunYemek", b =>
                {
                    b.HasOne("EFDiyetProgramiProje_DAL.Entities.Kullanici", "Kullanici")
                        .WithMany()
                        .HasForeignKey("KullaniciId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kullanici");
                });

            modelBuilder.Entity("EFDiyetProgramiProje_DAL.Entities.OgunYemek", b =>
                {
                    b.HasOne("EFDiyetProgramiProje_DAL.Entities.KullaniciOgunYemek", null)
                        .WithMany("OgunYemekler")
                        .HasForeignKey("KullaniciOgunYemekId");

                    b.HasOne("EFDiyetProgramiProje_DAL.Entities.Ogun", "Ogun")
                        .WithMany("OgunYemekler")
                        .HasForeignKey("OgunId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFDiyetProgramiProje_DAL.Entities.Yemek", "Yemek")
                        .WithMany("OgunYemekler")
                        .HasForeignKey("YemekId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ogun");

                    b.Navigation("Yemek");
                });

            modelBuilder.Entity("EFDiyetProgramiProje_DAL.Entities.Yemek", b =>
                {
                    b.HasOne("EFDiyetProgramiProje_DAL.Entities.YemekKategori", "YemekKategori")
                        .WithMany("Yemekler")
                        .HasForeignKey("YemekKategoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("YemekKategori");
                });

            modelBuilder.Entity("EFDiyetProgramiProje_DAL.Entities.KullaniciBilgi", b =>
                {
                    b.Navigation("Kullanici")
                        .IsRequired();
                });

            modelBuilder.Entity("EFDiyetProgramiProje_DAL.Entities.KullaniciOgunYemek", b =>
                {
                    b.Navigation("OgunYemekler");
                });

            modelBuilder.Entity("EFDiyetProgramiProje_DAL.Entities.Ogun", b =>
                {
                    b.Navigation("OgunYemekler");
                });

            modelBuilder.Entity("EFDiyetProgramiProje_DAL.Entities.Yemek", b =>
                {
                    b.Navigation("OgunYemekler");
                });

            modelBuilder.Entity("EFDiyetProgramiProje_DAL.Entities.YemekKategori", b =>
                {
                    b.Navigation("Yemekler");
                });
#pragma warning restore 612, 618
        }
    }
}
