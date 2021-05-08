
using CodigoPenalApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CodigoPenalApi.Data
{

    public class ApiContext : DbContext
    {
        public DbSet<User> Users;
        public DbSet<CriminalCode> CriminalCodes;
        public DbSet<Status> Statuses;
        public ApiContext(DbContextOptions<ApiContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging(true);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasIndex(user => user.UserName)
                .IsUnique();
            modelBuilder.ApplyConfiguration(new CriminalCodeCfg());
            modelBuilder.ApplyConfiguration(new UserCfg());
            modelBuilder.ApplyConfiguration(new StatusCfg());
        }
    }
}
