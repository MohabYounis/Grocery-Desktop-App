using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Resturant.Business;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Resturant.Presentation
{
    public partial class Pres_Login : Form
    {
        UserServices userServices;
        public Pres_Login()
        {
            InitializeComponent();
            userServices = new UserServices();
            txt_pass.UseSystemPasswordChar = true;
        }


        private void btn_start_Click(object sender, EventArgs e)
        {
            string email = txt_email.Text.Trim();
            string pass = txt_pass.Text.Trim();

            var user = userServices.UserAuthontication(email, pass);

            if (user != null)
            {
                if (user.U_Role == "user")
                {
                    this.Hide();
                    Pres_User pres_user = new Pres_User(user.U_Id, user.U_Name);
                    pres_user.Show();
                }
                else
                {
                    this.Hide();
                    Pres_Admin pres_admin = new Pres_Admin(user.U_Id, user.U_Name);
                    pres_admin.Show();
                }
            }
            else
            {
                MessageBox.Show("Wrong Email or Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            txt_pass.UseSystemPasswordChar = !checkBox.Checked;
        }
        private void Pres_Login_Load(object sender, EventArgs e)
        {
            lbl_email.Visible = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Show();
            Pres_Signup pres_signup = new Pres_Signup();
            pres_signup.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pres_Start pres_start = new Pres_Start();
            pres_start.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are You Sure You Want To Exit The Program?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void txt_email_Leave(object sender, EventArgs e)
        {
            string email = txt_email.Text.Trim();

            // Regular Expression for Email Validation
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            if (!Regex.IsMatch(email, pattern))
            {
                lbl_email.Text = "❌ Invalid Email!";
                lbl_email.ForeColor = System.Drawing.Color.Red;
                lbl_email.Visible = true;
            }
            else
                lbl_email.Visible = false;
        }
    }
}
