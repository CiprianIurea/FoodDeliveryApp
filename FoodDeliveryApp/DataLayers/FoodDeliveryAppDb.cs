using FoodDeliveryApp.DataLayers.Entities;
using Microsoft.EntityFrameworkCore;

namespace FoodDeliveryApp.DataLayers
{
    public class FoodDeliveryAppDb : DbContext
    {
        public FoodDeliveryAppDb(DbContextOptions<FoodDeliveryAppDb> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Comanda> Comenzi { get; set; }
        public DbSet<Produs> Produse { get; set; }
        public DbSet<Restaurant> Restaurante { get; set; }
        public DbSet<Localitate> Localitate { get; set; }
        public DbSet<Tara> Tara { get; set; }
        public DbSet<Plata> Plata { get; set; }
        public DbSet<BonFiscal> BonFiscal { get; set; }
        public DbSet<Cos> Cos { get; set; }
        public DbSet<Livrator> Livrator { get; set;}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure relationships here
            modelBuilder.Entity<Plata>()
                .HasOne(p => p.bon)
                .WithOne(b => b.plata)
                .HasForeignKey<BonFiscal>(b => b.PlataId);
            modelBuilder.Entity<Cos>()
                .HasOne(cos => cos.comanda)
                .WithOne(com => com.cos)
                .HasForeignKey<Comanda>(c => c.CosId);
            modelBuilder.Entity<Comanda>()
                .HasOne(c => c.plata)
                .WithOne(p => p.comanda)
                .HasForeignKey<Plata>(p => p.ComandaId);
            modelBuilder.Entity<faceComanda>()
                .HasKey(fc => new { fc.ComandaId, fc.UserId }); // Define composite primary key

            modelBuilder.Entity<faceComanda>()
                .HasOne(fc => fc.comanda)
                .WithMany(c => c._faceComanda)
                .HasForeignKey(fc => fc.ComandaId);

            modelBuilder.Entity<faceComanda>()
                .HasOne(fc => fc.user)
                .WithMany(u => u._faceComanda)
                .HasForeignKey(fc => fc.UserId);

            modelBuilder.Entity<AdaugaCos>()
                .HasKey(ac => new { ac.UserId, ac.CosId, ac.ProdusId });

            modelBuilder.Entity<AdaugaCos>()
                .HasOne(ac => ac.user)
                .WithMany(u => u._adaugaCos)
                .HasForeignKey(ac => ac.UserId);

            modelBuilder.Entity<AdaugaCos>()
                .HasOne(ac => ac.produs)
                .WithMany(p => p._adaugaCos)
                .HasForeignKey(ac => ac.ProdusId);

            modelBuilder.Entity<AdaugaCos>()
                .HasOne(ac => ac.cos)
                .WithMany(c => c._adaugaCos)
                .HasForeignKey(ac => ac.CosId);
        }
    }
}
