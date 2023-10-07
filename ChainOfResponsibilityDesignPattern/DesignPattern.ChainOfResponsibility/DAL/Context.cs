using Microsoft.EntityFrameworkCore;

namespace DesignPattern.ChainOfResponsibility.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=monster2684tunc\\SQLEXPRESS;initial catalog=DesignPattern1;integrated security=true");
        }

        public DbSet<CoustemerProcess> coustemerProcesses { get; set; }
    }
}
