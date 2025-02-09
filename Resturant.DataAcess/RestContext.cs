using Microsoft.EntityFrameworkCore;
using Resturant.DataAcess.Models;
using Microsoft.EntityFrameworkCore.Design;
using Dapper;
using Microsoft.Data.SqlClient;

namespace Resturant.DataAcess
{   
    public class RestContext : DbContext
    {
        private readonly SqlConnection _connection;

        public RestContext()
        {
            _connection = new SqlConnection("Server=.\\SQLExpress;Database=RestDB;Trusted_Connection=True;Trust Server Certificate=True;");
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Category> Categories { get; set; } 
        public virtual DbSet<Favourite> Favorites { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(_connection);
        }

        public SqlConnection GetConnection()
        {
            if (_connection.State != System.Data.ConnectionState.Open)
                _connection.Open();

            return _connection;
        }

    }
}
