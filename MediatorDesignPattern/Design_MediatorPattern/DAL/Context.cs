using Microsoft.EntityFrameworkCore;

namespace Design_MediatorPattern.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer("server=monster2684tunc\\SQLEXPRESS;initial catalog=DesignPattern8;integrated security=true");
        }

        public DbSet<Product>? Products { get; set; }


    }
}
