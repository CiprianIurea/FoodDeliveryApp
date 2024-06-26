﻿// <auto-generated />
using System;
using FoodDeliveryApp.DataLayers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FoodDeliveryApp.Migrations
{
    [DbContext(typeof(FoodDeliveryAppDb))]
    [Migration("20240424152846_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FoodDeliveryApp.DataLayers.Entities.BonFiscal", b =>
                {
                    b.Property<int>("BonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BonId"), 1L, 1);

                    b.Property<int>("Cod")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataTranzactie")
                        .HasColumnType("datetime2");

                    b.HasKey("BonId");

                    b.ToTable("BonFiscal");
                });

            modelBuilder.Entity("FoodDeliveryApp.DataLayers.Entities.Comanda", b =>
                {
                    b.Property<int>("ComandaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ComandaId"), 1L, 1);

                    b.HasKey("ComandaId");

                    b.ToTable("Comenzi");
                });

            modelBuilder.Entity("FoodDeliveryApp.DataLayers.Entities.Cos", b =>
                {
                    b.Property<int>("CosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CosId"), 1L, 1);

                    b.Property<float>("PretTotal")
                        .HasColumnType("real");

                    b.HasKey("CosId");

                    b.ToTable("Cos");
                });

            modelBuilder.Entity("FoodDeliveryApp.DataLayers.Entities.Livrator", b =>
                {
                    b.Property<int>("LivratorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LivratorId"), 1L, 1);

                    b.Property<string>("Nume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SerieNumarCI")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.HasKey("LivratorId");

                    b.ToTable("Livrator");
                });

            modelBuilder.Entity("FoodDeliveryApp.DataLayers.Entities.Localitate", b =>
                {
                    b.Property<int>("LocalitateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LocalitateId"), 1L, 1);

                    b.Property<string>("Denumire")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LocalitateId");

                    b.ToTable("Localitate");
                });

            modelBuilder.Entity("FoodDeliveryApp.DataLayers.Entities.Plata", b =>
                {
                    b.Property<int>("PlataId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PlataId"), 1L, 1);

                    b.Property<string>("MetodaPlata")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PlataId");

                    b.ToTable("Plata");
                });

            modelBuilder.Entity("FoodDeliveryApp.DataLayers.Entities.Produs", b =>
                {
                    b.Property<int>("ProdusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProdusId"), 1L, 1);

                    b.Property<int>("Cantitate")
                        .HasColumnType("int");

                    b.Property<string>("Denumire")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ingrediente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Pret")
                        .HasColumnType("real");

                    b.HasKey("ProdusId");

                    b.ToTable("Produse");
                });

            modelBuilder.Entity("FoodDeliveryApp.DataLayers.Entities.Restaurant", b =>
                {
                    b.Property<int>("RestaurantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RestaurantId"), 1L, 1);

                    b.Property<string>("Adresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipRestaurant")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RestaurantId");

                    b.ToTable("Restaurante");
                });

            modelBuilder.Entity("FoodDeliveryApp.DataLayers.Entities.Tara", b =>
                {
                    b.Property<int>("TaraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TaraId"), 1L, 1);

                    b.Property<string>("Denumire")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TaraId");

                    b.ToTable("Tara");
                });

            modelBuilder.Entity("FoodDeliveryApp.DataLayers.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<string>("Adresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
