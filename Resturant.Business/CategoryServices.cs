using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resturant.DataAcess;
using Resturant.DataAcess.Models;

namespace Resturant.Business
{
    public class CategoryServices
    {
        RestContext Db;

        public CategoryServices()
        {
            Db = new RestContext();
        }

        // Get All Categories 
        public List<Category> GetAllCategories()
        {
            return Db.Categories.ToList();
        }

        // Add
        public int AddCategory(string name)
        {
            Category c = new Category()
            {
                Cat_Name = name
            };

            Db.Categories.Add(c);
            return Db.SaveChanges();
        }

        // Delete
        public int DeleteCategory(int id)
        {
            Category c = Db.Categories.Where(c=>c.Cat_Id == id).FirstOrDefault();
            Db.Categories.Remove(c);
            return Db.SaveChanges();
        }

        // Update
        public int UpdateCategory(int id, string name)
        {
            Category c = Db.Categories.Where(c=>c.Cat_Id==id).FirstOrDefault();
            c.Cat_Name = name;
            return Db.SaveChanges();
        }
    }
}
