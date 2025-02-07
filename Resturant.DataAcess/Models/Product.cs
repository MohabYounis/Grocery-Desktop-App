using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant.DataAcess.Models
{
    public class Product
    {
        [Key]
        public int Prod_Id { get; set; }
        public string Prod_Name { get; set; }
        public int Prod_Price { get; set; }
        public int Prod_Amount { get; set; }
        [ForeignKey("category")]
        public int Cat_Id { get; set; }
        public virtual List<Favourite> favourites { get; } = new List<Favourite>();
        public virtual Category category { get; set; }
    }
}
