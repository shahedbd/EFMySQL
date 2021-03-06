# Entity Framework Core with MySQL

``` 
Install-Package Microsoft.EntityFrameworkCore -Version 2.1.4
Install-Package MySql.Data.EntityFrameworkCore -Version 8.0.15
```


```C#
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
```

