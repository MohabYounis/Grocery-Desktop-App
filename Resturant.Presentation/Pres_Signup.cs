using Microsoft.VisualBasic.ApplicationServices;
using Resturant.Business;
using Resturant.Presentation.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Resturant.Presentation
{
    public partial class Pres_Signup : Form
    {
        UserServices userServices;
        public Pres_Signup()
        {
            InitializeComponent();
            userServices = new UserServices();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text.Trim();
            string email = txt_email.Text.Trim();
            string password = txt_pass.Text;
            string passConfirm = txt_passConfirm.Text;
            string address = txt_address.Text;
            string phone = txt_phone.Text.Trim();
            DateOnly birthDate = DateOnly.FromDateTime(dateTimePicker.Value);

            var isUser = userServices.UserAuthonticationByEmail(email);

            if (string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(passConfirm))
            {
                MessageBox.Show("Please, enter a password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Regular Expression for Email Validation
            string patternEmail = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            // Regular Expression for Phone Validation
            string patternPhone = @"^(010|011|012|015)[0-9]{8}$";


            if (password != passConfirm)
            {
                MessageBox.Show("Password does not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (isUser != null)
            {
                MessageBox.Show("This email is already exist!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!Regex.IsMatch(email, patternEmail))
            {
                MessageBox.Show("Enter the email correctly", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!Regex.IsMatch(phone, patternPhone))
            {
                MessageBox.Show("Enter the phone number correctly", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                userServices.AddNewUser(name, email, password, address, phone, birthDate);
                txt_address.Text = txt_email.Text = txt_name.Text = txt_pass.Text = txt_passConfirm.Text = txt_phone.Text = "";
                dateTimePicker.Value = DateTime.Now;

                MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                Pres_Login pres_login = new Pres_Login();
                pres_login.Show();
            }
        }
        private void Pres_Signup_Load(object sender, EventArgs e)
        {
            lbl_email.Visible = lbl_phone.Visible = false;
        }

        private void txt_email_Leave(object sender, EventArgs e)
        {
            string email = txt_email.Text.Trim();

            // Regular Expression for Email Validation
            string patternEmail = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            if (!Regex.IsMatch(email, patternEmail))
            {
                lbl_email.Text = "❌ Invalid Email!";
                lbl_email.ForeColor = System.Drawing.Color.Red;
                lbl_email.Visible = true;
            }
            else
                lbl_email.Visible = false;
        }

        private void txt_phone_Leave(object sender, EventArgs e)
        {
            string phone = txt_phone.Text.Trim();

            // Regular Expression for Phone Validation
            string patternPhone = @"^(010|011|012|015)[0-9]{8}$";

            if (!Regex.IsMatch(phone, patternPhone))
            {
                lbl_phone.Text = "❌ Invalid Email!";
                lbl_phone.ForeColor = System.Drawing.Color.Red;
                lbl_phone.Visible = true;
            }
            else
                lbl_phone.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pres_Login pres_login = new Pres_Login();
            pres_login.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Pres_Login pres_login = new Pres_Login();
            pres_login.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are You Sure You Want To Exit The Program?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }
    }
}
