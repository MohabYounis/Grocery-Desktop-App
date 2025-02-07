using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resturant.DataAcess;
using Resturant.DataAcess.Models;

namespace Resturant.Business
{
    public class ProductServices
    {
        RestContext Db;

        public ProductServices()
        {
            Db = new RestContext();
        }

        // View All Products
        public List<Product> GetAllProducts()
        {
            return Db.Products.ToList();
        }

        // Add Product
        public int AddProduct(string name, int price, int amount, int categoryId)
        {
            Product p = new Product()
            {
                Prod_Name = name,
                Prod_Price = price,
                Prod_Amount = amount,
                Cat_Id = categoryId
            };
            Db.Products.Add(p);
            return Db.SaveChanges();
        }

        // Update 
        public int UpdateProduct(int id, string name, int price, int amount, int categoryId)
        {
            Product p = Db.Products.Where(p=>p.Prod_Id == id).FirstOrDefault();
            p.Prod_Name = name;
            p.Prod_Price = price;
            p.Prod_Amount = amount;
            p.Cat_Id = categoryId;

            return Db.SaveChanges();
        }

        // Delete 
        public int DeleteProduct(int id)
        {
            Product p = Db.Products.Where(p => p.Prod_Id == id).FirstOrDefault();
            Db.Products.Remove(p);
            return Db.SaveChanges();
        }
    }
}
