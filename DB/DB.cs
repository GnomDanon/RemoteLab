using DB.Entities;
using Microsoft.EntityFrameworkCore;

namespace DB
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Scheduler> Schedulers { get; set; }
        public DbSet<Shedule_Stand> Shedule_Stands { get; set; }
        public DbSet<Stand> Stands { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<HardwarePlatform> HardwarePlatforms { get; set; }
        public DbSet<HardwareFeature> HardwareFeatures { get; set; }
        public DbSet<ServiceType> ServiceTypes { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Organization_Stand> Organization_Stands { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost:5433;Username=postgres;Password=etk;Database=RemoteLab_DB");
        }
    }
}