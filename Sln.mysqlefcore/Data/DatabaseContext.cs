using Microsoft.EntityFrameworkCore;
using Data.Model;


namespace Data
{
    public class DatabaseContext : DbContext
    {
        public DbSet<PersonalInfo> PersonalInfo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=InfoDB;user=root;password=root");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PersonalInfo>(entity =>
            {
                entity.HasKey(e => e.ID);
                entity.Property(e => e.ID).ValueGeneratedOnAdd();
            });

        }
    }
}
