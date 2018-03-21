using Microsoft.EntityFrameworkCore;
using Vega.Models;

namespace Vega.Persistence
{
    public class VegaDbContext : DbContext
    {
        public DbSet<Make> Makes { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public VegaDbContext(DbContextOptions<VegaDbContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vehicle>()
                .HasOne(v => v.Contact)
                .WithMany(c => c.Vehicles)
                .HasForeignKey(v => v.ContactId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Vehicle>()
                .HasOne(v => v.Make)
                .WithMany(m => m.Vehicles)
                .HasForeignKey(v => v.MakeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Vehicle>()
                .HasOne(v => v.Model)
                .WithMany(m => m.Vehicles)
                .HasForeignKey(v => v.ModelId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<VehicleFeature>()
                .HasKey(vf => new { vf.VehicleId, vf.FeatureId });

            modelBuilder.Entity<VehicleFeature>()
                .HasOne(vf => vf.Vehicle)
                .WithMany(v => v.VehicleFeatures)
                .HasForeignKey(vf => vf.VehicleId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<VehicleFeature>()
                .HasOne(vf => vf.Feature)
                .WithMany(f => f.VehicleFeatures)
                .HasForeignKey(vf => vf.FeatureId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}