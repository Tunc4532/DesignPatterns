using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DessignPattern.ObServer.DAL
{
    public class Context : IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=monster2684tunc\\SQLEXPRESS;initial catalog=DesignPattern4;integrated security=true");
        }

        public DbSet<Discount> Discounts { get; set; }
        public DbSet<WelcomeMessage> WelcomeMessages { get; set; }
        public DbSet<UserProcese> UserProceses { get; set; }

    }
}
