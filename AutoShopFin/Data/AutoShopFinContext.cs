using Microsoft.EntityFrameworkCore;
using AutoShopFin.Models;

namespace AutoShopFin.Data
{
    public class AutoShopFinContext : DbContext
    {
        public AutoShopFinContext(DbContextOptions<AutoShopFinContext> options)
            : base(options)
        {
        }

        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Vehiculos> Vehiculos { get; set; }
        public DbSet<Reparaciones> Reparaciones { get; set; }
        public DbSet<Partes> Partes { get; set; }
        public DbSet<Citas> Citas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Citas>()
                .HasOne(c => c.Vehiculo)
                .WithMany()
                .HasForeignKey(c => c.IdVehiculo)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Citas>()
                .HasOne(c => c.Cliente)
                .WithMany()
                .HasForeignKey(c => c.IdCliente)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
