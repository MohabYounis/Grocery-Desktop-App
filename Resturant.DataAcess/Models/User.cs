using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant.DataAcess.Models
{
    public class User
    {
        [Key]
        public int U_Id { get; set; }
        public string U_Name { get; set; }
        public string U_Email { get; set; }
        public string U_Password { get; set; }
        public string U_Phone { get; set; }
        public string U_Address { get; set; }
        public DateOnly U_BirthDate { get; set; }
        public string U_Role { get; set; } = "user";

        public virtual List<Favourite> favourites { get; } = new List<Favourite>();
    }
}
