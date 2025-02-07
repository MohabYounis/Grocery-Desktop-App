using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant.Presentation
{
    public partial class Pres_User_Prod : Form
    {
        int UserID;
        string UserName;
        public Pres_User_Prod(int id, string name)
        {
            InitializeComponent();
            UserID = id;
            UserName = name;
        }
    }
}
