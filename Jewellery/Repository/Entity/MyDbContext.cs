using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;


namespace Repository.Entity
{
    public class MyDbContext : DbContext
    {
        public MyDbContext()
        {

        }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
            try
            {
                var databaseCreator = Database.GetService<IDatabaseCreator>() as RelationalDatabaseCreator;
                if (databaseCreator != null)
                {
                    if (!databaseCreator.CanConnect()) databaseCreator.Create();
                    if (!databaseCreator.HasTables()) databaseCreator.CreateTables();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public virtual DbSet<Blog> Blogs { get; set; }

        public virtual DbSet<Design> Designs { get; set; }

        public virtual DbSet<Have> Haves { get; set; }

        public virtual DbSet<MasterGemstone> MasterGemstones { get; set; }

        public virtual DbSet<Material> Materials { get; set; }

        public virtual DbSet<Payment> Payments { get; set; }

        public virtual DbSet<Requirement> Requirements { get; set; }

        public virtual DbSet<Role> Roles { get; set; }

        public virtual DbSet<Stones> Stones { get; set; }

        public virtual DbSet<TypeOfJewellry> TypeOfJewelries { get; set; }

        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<WarrantyCard> WarrantyCards { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Have>()
            .HasKey(e => new { e.WarrantyCardId, e.RequirementsId });

            base.OnModelCreating(modelBuilder);
        }
    }
}

