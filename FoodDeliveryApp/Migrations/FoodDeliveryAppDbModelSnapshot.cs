﻿// <auto-generated />
using System;
using FoodDeliveryApp.DataLayers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FoodDeliveryApp.Migrations
{
    [DbContext(typeof(FoodDeliveryAppDb))]
    partial class FoodDeliveryAppDbModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FoodDeliveryApp.DataLayers.Entities.AdaugaCos", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("CosId")
                        .HasColumnType("int");

                    b.Property<int>("ProdusId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "CosId", "ProdusId");

                    b.HasIndex("CosId");

                    b.HasIndex("ProdusId");

                    b.ToTable("AdaugaCos");
                });

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

                    b.Property<int>("PlataId")
                        .HasColumnType("int");

                    b.HasKey("BonId");

                    b.HasIndex("PlataId")
                        .IsUnique();

                    b.ToTable("BonFiscal");
                });

            modelBuilder.Entity("FoodDeliveryApp.DataLayers.Entities.Comanda", b =>
                {
                    b.Property<int>("ComandaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ComandaId"), 1L, 1);

                    b.Property<int>("CosId")
                        .HasColumnType("int");

                    b.Property<int>("LivratorId")
                        .HasColumnType("int");

                    b.Property<int>("PlataId")
                        .HasColumnType("int");

                    b.HasKey("ComandaId");

                    b.HasIndex("CosId")
                        .IsUnique();

                    b.HasIndex("LivratorId");

                    b.ToTable("Comenzi");
                });

            modelBuilder.Entity("FoodDeliveryApp.DataLayers.Entities.Cos", b =>
                {
                    b.Property<int>("CosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CosId"), 1L, 1);

                    b.Property<int>("ComandaId")
                        .HasColumnType("int");

                    b.Property<float>("PretTotal")
                        .HasColumnType("real");

                    b.HasKey("CosId");

                    b.ToTable("Cos");
                });

            modelBuilder.Entity("FoodDeliveryApp.DataLayers.Entities.faceComanda", b =>
                {
                    b.Property<int>("ComandaId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ComandaId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("faceComanda");
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

                    b.Property<int>("TaraId")
                        .HasColumnType("int");

                    b.HasKey("LocalitateId");

                    b.HasIndex("TaraId");

                    b.ToTable("Localitate");
                });

            modelBuilder.Entity("FoodDeliveryApp.DataLayers.Entities.Plata", b =>
                {
                    b.Property<int>("PlataId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PlataId"), 1L, 1);

                    b.Property<int>("BonId")
                        .HasColumnType("int");

                    b.Property<int>("ComandaId")
                        .HasColumnType("int");

                    b.Property<string>("MetodaPlata")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PlataId");

                    b.HasIndex("ComandaId")
                        .IsUnique();

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

                    b.Property<int>("RestaurantId")
                        .HasColumnType("int");

                    b.HasKey("ProdusId");

                    b.HasIndex("RestaurantId");

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

                    b.Property<int>("LocalitateId")
                        .HasColumnType("int");

                    b.Property<string>("Nume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipRestaurant")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RestaurantId");

                    b.HasIndex("LocalitateId");

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

            modelBuilder.Entity("FoodDeliveryApp.DataLayers.Entities.AdaugaCos", b =>
                {
                    b.HasOne("FoodDeliveryApp.DataLayers.Entities.Cos", "cos")
                        .WithMany("_adaugaCos")
                        .HasForeignKey("CosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FoodDeliveryApp.DataLayers.Entities.Produs", "produs")
                        .WithMany("_adaugaCos")
                        .HasForeignKey("ProdusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FoodDeliveryApp.DataLayers.Entities.User", "user")
                        .WithMany("_adaugaCos")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("cos");

                    b.Navigation("produs");

                    b.Navigation("user");
                });

            modelBuilder.Entity("FoodDeliveryApp.DataLayers.Entities.BonFiscal", b =>
                {
                    b.HasOne("FoodDeliveryApp.DataLayers.Entities.Plata", "plata")
                        .WithOne("bon")
                        .HasForeignKey("FoodDeliveryApp.DataLayers.Entities.BonFiscal", "PlataId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("plata");
                });

            modelBuilder.Entity("FoodDeliveryApp.DataLayers.Entities.Comanda", b =>
                {
                    b.HasOne("FoodDeliveryApp.DataLayers.Entities.Cos", "cos")
                        .WithOne("comanda")
                        .HasForeignKey("FoodDeliveryApp.DataLayers.Entities.Comanda", "CosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FoodDeliveryApp.DataLayers.Entities.Livrator", "livrator")
                        .WithMany("comenzi")
                        .HasForeignKey("LivratorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("cos");

                    b.Navigation("livrator");
                });

            modelBuilder.Entity("FoodDeliveryApp.DataLayers.Entities.faceComanda", b =>
                {
                    b.HasOne("FoodDeliveryApp.DataLayers.Entities.Comanda", "comanda")
                        .WithMany("_faceComanda")
                        .HasForeignKey("ComandaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FoodDeliveryApp.DataLayers.Entities.User", "user")
                        .WithMany("_faceComanda")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("comanda");

                    b.Navigation("user");
                });

            modelBuilder.Entity("FoodDeliveryApp.DataLayers.Entities.Localitate", b =>
                {
                    b.HasOne("FoodDeliveryApp.DataLayers.Entities.Tara", "tara")
                        .WithMany("localitati")
                        .HasForeignKey("TaraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("tara");
                });

            modelBuilder.Entity("FoodDeliveryApp.DataLayers.Entities.Plata", b =>
                {
                    b.HasOne("FoodDeliveryApp.DataLayers.Entities.Comanda", "comanda")
                        .WithOne("plata")
                        .HasForeignKey("FoodDeliveryApp.DataLayers.Entities.Plata", "ComandaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("comanda");
                });

            modelBuilder.Entity("FoodDeliveryApp.DataLayers.Entities.Produs", b =>
                {
                    b.HasOne("FoodDeliveryApp.DataLayers.Entities.Restaurant", "restaurant")
                        .WithMany("produse")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("restaurant");
                });

            modelBuilder.Entity("FoodDeliveryApp.DataLayers.Entities.Restaurant", b =>
                {
                    b.HasOne("FoodDeliveryApp.DataLayers.Entities.Localitate", "localitate")
                        .WithMany("restaurante")
                        .HasForeignKey("LocalitateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("localitate");
                });

            modelBuilder.Entity("FoodDeliveryApp.DataLayers.Entities.Comanda", b =>
                {
                    b.Navigation("_faceComanda");

                    b.Navigation("plata")
                        .IsRequired();
                });

            modelBuilder.Entity("FoodDeliveryApp.DataLayers.Entities.Cos", b =>
                {
                    b.Navigation("_adaugaCos");

                    b.Navigation("comanda")
                        .IsRequired();
                });

            modelBuilder.Entity("FoodDeliveryApp.DataLayers.Entities.Livrator", b =>
                {
                    b.Navigation("comenzi");
                });

            modelBuilder.Entity("FoodDeliveryApp.DataLayers.Entities.Localitate", b =>
                {
                    b.Navigation("restaurante");
                });

            modelBuilder.Entity("FoodDeliveryApp.DataLayers.Entities.Plata", b =>
                {
                    b.Navigation("bon")
                        .IsRequired();
                });

            modelBuilder.Entity("FoodDeliveryApp.DataLayers.Entities.Produs", b =>
                {
                    b.Navigation("_adaugaCos");
                });

            modelBuilder.Entity("FoodDeliveryApp.DataLayers.Entities.Restaurant", b =>
                {
                    b.Navigation("produse");
                });

            modelBuilder.Entity("FoodDeliveryApp.DataLayers.Entities.Tara", b =>
                {
                    b.Navigation("localitati");
                });

            modelBuilder.Entity("FoodDeliveryApp.DataLayers.Entities.User", b =>
                {
                    b.Navigation("_adaugaCos");

                    b.Navigation("_faceComanda");
                });
#pragma warning restore 612, 618
        }
    }
}
