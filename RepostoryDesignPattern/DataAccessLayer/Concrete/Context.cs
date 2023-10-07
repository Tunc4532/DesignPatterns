using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=MONSTER2684TUNC\\SQLEXPRESS ; database=DesignPattern6 ; integrated security=true");
        }

        public DbSet<Catagory> Catagories { get; set; }
        public DbSet<Product> Products { get; set; }

    }
}
