using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant.Presentation.Models
{
    internal class UserSignupData
    {
        public string name { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public DateOnly birthDate { get; set; }
    }
}
