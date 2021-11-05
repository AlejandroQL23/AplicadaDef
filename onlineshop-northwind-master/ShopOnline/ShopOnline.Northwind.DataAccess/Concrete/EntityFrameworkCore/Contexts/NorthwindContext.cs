using Microsoft.EntityFrameworkCore;
using ShopOnline.Northwind.Entities.Concrete;

namespace ShopOnline.Northwind.DataAccess.Concrete.EntityFrameworkCore.Contexts
{
    public class NorthwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // "Server=163.178.107.10;Initial Catalog=ALDIFA_SOFT_MVC_IF4101;User ID=laboratorios;Password=KmZpo.2796"
            optionsBuilder.UseSqlServer("Server=servertestuno.database.windows.net;Initial Catalog=Northwind;User ID=admintestuno;Password=admin2000%");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
