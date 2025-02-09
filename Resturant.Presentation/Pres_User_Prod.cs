using Microsoft.VisualBasic.Devices;
using Resturant.Business;
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
        private readonly ProductServices _productService;
        public Pres_User_Prod(int id, string name)
        {
            InitializeComponent();
            UserID = id;
            UserName = name;
            _productService = new ProductServices();
        }

        private void Pres_User_Prod_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _productService.GetProductsByDapper();
            dataGridView1.Columns["Prod_Id"].Visible = false;
            //dataGridView1.DataSource = con.Query<Topic>("select * from topic");
            //dataGridView1.DisplayMember = "Top_Name";
            //dataGridView1.ValueMember = "Top_Id"; 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are You Sure You Want To Exit The Program?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pres_User pres_user = new Pres_User(UserID, UserName);
            pres_user.Show();
        }
    }
}
