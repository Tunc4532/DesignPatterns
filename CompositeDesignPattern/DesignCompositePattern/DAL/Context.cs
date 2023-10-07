using Microsoft.EntityFrameworkCore;

namespace DesignCompositePattern.DAL
{
    public class Context : DbContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=monster2684tunc\\SQLEXPRESS;initial catalog=DesignPattern7;integrated security=true");
          
        }

        public DbSet<Catagory>? Catagories { get; set; }
        public DbSet<Product>? Products { get; set; }

    }
}
