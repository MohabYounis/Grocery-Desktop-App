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
    public partial class Pres_User : Form
    {
        int UserId;
        string UserName;
        public Pres_User(int id, string name)
        {
            InitializeComponent();
            this.UserId = id;
            this.UserName = name;
        }

        private void btn_profile_Click(object sender, EventArgs e)
        {
            Pres_User_Profile pres_use_prof = new Pres_User_Profile(UserId, UserName);
            pres_use_prof.Show();
            this.Hide();
        }

        private void btn_product_Click(object sender, EventArgs e)
        {
            Pres_User_Prod pres_User_Prod = new Pres_User_Prod(UserId, UserName);
            pres_User_Prod.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are You Sure You Want To Logout?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Pres_Login pres_login = new Pres_Login();
                pres_login.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are You Sure You Want To Exit The Program?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void Pres_User_Load(object sender, EventArgs e)
        {
            lbl_welcome.Text = $"Welcome {UserName.ToUpper()}";
        }
    }
}
