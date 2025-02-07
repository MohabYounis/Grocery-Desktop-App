using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Resturant.Business;

namespace Resturant.Presentation
{
    public partial class Pres_User_Profile : Form
    {
        int UserId;
        string userName;

        UserServices userServices;
        public Pres_User_Profile(int id, string name)
        {
            InitializeComponent();
            userName = name;
            UserId = id;
            userServices = new UserServices();
            txt_pass.UseSystemPasswordChar = true;
        }

        public void LoadProfile(int id)
        {
            var user = userServices.GetUserById(id);
            txt_name.Text = user.U_Name;
            txt_email.Text = user.U_Email;
            txt_pass.Text = user.U_Password;
            txt_phone.Text = user.U_Phone;
            txt_address.Text = user.U_Address;
            dateTimePicker.Value = user.U_BirthDate.ToDateTime(TimeOnly.MinValue);

            dateTimePicker.Enabled = txt_name.Enabled = txt_address.Enabled =
            txt_pass.Enabled = txt_phone.Enabled = btn_saveChanges.Visible = checkBox1.Visible = false;

            lbl_name.Text = $"Welcome {userName}";
        }

        /*----------------------------------------------------------------------*/
        private void Pres_User_Profile_Load(object sender, EventArgs e)
        {
            LoadProfile(UserId);
        }
        private void btn_edit_Click(object sender, EventArgs e)
        {
            dateTimePicker.Enabled = txt_name.Enabled = txt_email.Enabled = txt_address.Enabled =
            txt_pass.Enabled = txt_phone.Enabled = checkBox1.Visible = btn_saveChanges.Visible = true;
        }
        private void btn_saveChanges_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text;
            string address = txt_address.Text;
            string pass = txt_pass.Text;
            string phone = txt_phone.Text;
            DateOnly birthDate = DateOnly.FromDateTime(dateTimePicker.Value);

            var user = userServices.GetUserById(UserId);

            if (string.IsNullOrWhiteSpace(pass))
                MessageBox.Show("Please, enter a password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                int rowsAffected = userServices.UpdateUserById(UserId, name, address, phone, birthDate, pass);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Updated successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            LoadProfile(UserId);
            txt_pass.UseSystemPasswordChar = true;
            checkBox1.Checked = false;
        }
        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            txt_pass.UseSystemPasswordChar = !checkBox1.Checked;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Pres_User pres_user = new Pres_User(UserId, userName);
            pres_user.Show();
            this.Hide();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are You Sure You Want To Exit The Program?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void btn_deleteAcc_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show($"Are You Sure You Want To Delte Account?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int rowsAffected = userServices.DeleteUser(UserId);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("See you Soon");
                    Pres_Start pres_start = new Pres_Start();
                    pres_start.Show();
                    this.Close();
                }
            }
        }
    }
}
