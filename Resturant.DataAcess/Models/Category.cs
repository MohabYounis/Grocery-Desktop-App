using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant.DataAcess.Models
{
    public class Category
    {
        [Key]
        public int Cat_Id { get; set; }
        public string Cat_Name { get; set; }
        public virtual List<Product> products { get; } = new List<Product>();
    }
}
