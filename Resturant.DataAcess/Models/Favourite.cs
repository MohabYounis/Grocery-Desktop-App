using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant.DataAcess.Models
{
    [PrimaryKey(nameof(U_Id), nameof(Prod_Id))]
    public class Favourite
    {
        [ForeignKey("user")]
        public int U_Id { get; set; }
        [ForeignKey("product")]
        public int Prod_Id { get; set; }
        public virtual User user { get; set; }
        public virtual Product product { get; set; }
    }
}
