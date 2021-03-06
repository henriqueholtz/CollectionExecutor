using CollectionExecutor.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CollectionExecutor.Persistence.Data
{
    public class CollectionExecutorDbContext : DbContext
    {
        public DbSet<Collection> Collections { get; set; }
        public DbSet<Request> Requests { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CollectionExecutorDbContext).Assembly);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Data Source=localhost,1433;Database=CollectionExecutor;User ID=sa;Password=@myPassword");
            //=> options.UseSqlServer("Data Source=localhost,1433;Initial Catalog=CollectionExecutor;User ID=sa;Password=@myPassword");
            //=> options.UseSqlServer("Data Source=localhost,1401;Initial Catalog=CollectionExecutor;User ID=sa;Password=@myPassword");
    }
}
