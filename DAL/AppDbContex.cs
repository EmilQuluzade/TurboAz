using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Turbo.az.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Turbo.az.DAL
{
    public class AppDbContex:IdentityDbContext<User>
    {
        public AppDbContex(DbContextOptions<AppDbContex> options) : base(options) { }

        public DbSet<Marka> Markas { get; set; }
        public DbSet<Models.Model> Models { get; set; }

        public DbSet<Year> Year { get; set; }

        public DbSet<City> City { get; set; }

        public DbSet<Unitoflength> Unitoflength { get; set; }

        public DbSet<Colors> Colors { get; set; }

        public DbSet<Currency> Currency { get; set; }

        public DbSet<Ownership> Ownership { get; set; }

        public DbSet<Status> Status { get; set; }
        
        public DbSet<Sits> Sits { get; set; }
        
        public DbSet<Fuel> Fuel { get; set; }

        public DbSet<Transmitter> Transmitter { get; set; }

        public DbSet<Gearbox> Gearbox { get; set; }

        public DbSet<EngineCapacity> EngineCapacity { get; set; }
        
        public DbSet<EnginePower> EnginePower { get; set; }

        public DbSet<Country> Country { get; set; }
        public DbSet<Equipment> Equipment { get; set; }
        public DbSet<Image> Image { get; set; }
        public DbSet<Premium> Premium { get; set; }
        public DbSet<Vip> Vip { get; set; }
        public DbSet<VipPayment> VipPayment { get; set; }
        public DbSet<Cars> Cars { get; set; }
        public DbSet<EquipmentCar> EquipmentCar { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure the model here
            modelBuilder.Entity<Premium>()
                .Property(p => p.Price)
                .HasColumnType("decimal(18, 2)");

            modelBuilder.Entity<Vip>()
       .Property(v => v.Price)
       .HasColumnType("decimal(18, 2)");

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Comment>()
    .HasOne(c => c.Cars)
    .WithMany() // Assuming Cars can have multiple comments
    .HasForeignKey(c => c.CarId)
    .OnDelete(DeleteBehavior.Restrict);

        }




    }
}
