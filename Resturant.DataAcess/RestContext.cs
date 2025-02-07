using Microsoft.EntityFrameworkCore;
using Resturant.DataAcess.Models;
using Microsoft.EntityFrameworkCore.Design;

namespace Resturant.DataAcess
{   
    public class RestContext : DbContext
    {
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Category> Categories { get; set; } 
        public virtual DbSet<Favourite> Favorites { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLexpress;Database=RestDB;Trusted_Connection=True;Trust Server Certificate=True;");
        }
    }
}
