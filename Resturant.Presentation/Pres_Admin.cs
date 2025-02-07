using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Resturant.Business;
using Resturant.DataAcess.Models;

namespace Resturant.Presentation
{
    public partial class Pres_Admin : Form
    {
        ProductServices productSercvices;
        CategoryServices categorySercvices;
        UserServices userSercvices;
        int LoginId { get; set; }
        string LoginName { get; set; }

        int ProdID { get; set; }
        int CatID { get; set; }
        int UserID { get; set; }

        string currentMode = "Product";
        public Pres_Admin(int id, string name)
        {
            InitializeComponent();
            LoginId = id;
            LoginName = name;
            productSercvices = new ProductServices();
            categorySercvices = new CategoryServices();
            userSercvices = new UserServices();
        }
        /* ------------------------------------ Methods -----------------------------------*/
        public void LoadProductsAndCategories()
        {
            dgv_prodAndUser.DataSource = productSercvices.GetAllProducts();
            dgv_prodAndUser.Columns["Prod_Id"].Visible = dgv_prodAndUser.Columns["Category"].Visible = false;

            dgv_prodAndUser.Columns["Prod_Name"].HeaderText = "Name";
            dgv_prodAndUser.Columns["Prod_Price"].HeaderText = "Price/Kg";
            dgv_prodAndUser.Columns["Prod_Amount"].HeaderText = "Amount(Kg)";
            dgv_prodAndUser.Columns["Cat_Id"].HeaderText = "Category";

            cb_category.DataSource = categorySercvices.GetAllCategories();
            cb_category.DisplayMember = "Cat_Name";
            cb_category.ValueMember = "Cat_ID";
            cb_category.SelectedIndex = 0;

            txt_name.Text = txt_price.Text = "";

            btn_products.BackColor = System.Drawing.Color.FromArgb(113, 199, 36);
            btn_categories.BackColor = System.Drawing.Color.FromArgb(181, 214, 139);
            btn_users.BackColor = System.Drawing.Color.FromArgb(181, 214, 139);
        }
        public void LoadUsers()
        {
            dgv_prodAndUser.DataSource = userSercvices.GetAllUsers();
            dgv_prodAndUser.Columns["U_Id"].Visible = /*dgv_prodAndUser.Columns["Category"].Visible =*/ false;

            dgv_prodAndUser.Columns["U_Name"].HeaderText = "Name";
            dgv_prodAndUser.Columns["U_Email"].HeaderText = "Email";
            dgv_prodAndUser.Columns["U_Password"].HeaderText = "Password";
            dgv_prodAndUser.Columns["U_Phone"].HeaderText = "Phone";
            dgv_prodAndUser.Columns["U_Address"].HeaderText = "Address";
            dgv_prodAndUser.Columns["U_BirthDate"].HeaderText = "B-Date";

            cb_role.Items.Clear();
            cb_role.Items.Add("user");
            cb_role.Items.Add("admin");
            cb_role.SelectedIndex = 0;

            txt_name.Text = txt_price.Text = "";

            btn_products.BackColor = System.Drawing.Color.FromArgb(181, 214, 139);
            btn_categories.BackColor = System.Drawing.Color.FromArgb(181, 214, 139);
            btn_users.BackColor = System.Drawing.Color.FromArgb(113, 199, 36);
        }

        public void LoadCategories()
        {
            dgv_prodAndUser.DataSource = categorySercvices.GetAllCategories();
            dgv_prodAndUser.Columns["Cat_Id"].Visible = false;
            dgv_prodAndUser.Columns["Cat_Name"].HeaderText = "Category";

            txt_name.Text = txt_price.Text = "";

            btn_products.BackColor = System.Drawing.Color.FromArgb(181, 214, 139);
            btn_categories.BackColor = System.Drawing.Color.FromArgb(113, 199, 36);
            btn_users.BackColor = System.Drawing.Color.FromArgb(181, 214, 139);
        }
        /* ------------------------------------ Methods -----------------------------------*/



        private void Pres_Admin_Load(object sender, EventArgs e)
        {
            lbl_name.Text = $"Welcome {LoginName}";

            LoadProductsAndCategories();

            txt_price.Visible = txt_amount.Visible = cb_category.Visible =
            lbl_amount.Visible = lbl_category.Visible = lbl_price.Visible =
            btn_add.Visible = btn_clear.Visible =
            btn_delete.Visible = btn_update.Visible = true;

            btn_addCat.Visible = btn_updateCat.Visible = btn_deleteCat.Visible =
            btn_deleteUser.Visible = btn_updateUser.Visible = cb_role.Visible = lbl_role.Visible = false;
        }

        private void dgv_prodAndUser_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgv_prodAndUser.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgv_prodAndUser.SelectedRows[0];

                if (currentMode == "Product")
                {
                    ProdID = (int)row.Cells["Prod_Id"].Value;

                    txt_name.Text = row.Cells["Prod_Name"].Value.ToString();
                    txt_price.Text = row.Cells["Prod_Price"].Value.ToString();
                    txt_amount.Text = row.Cells["Prod_Amount"].Value.ToString();
                    cb_category.SelectedValue = row.Cells["Cat_Id"].Value;
                }
                else if (currentMode == "User")
                {
                    UserID = (int)row.Cells["U_Id"].Value;
                    txt_name.Text = row.Cells["U_Name"].Value.ToString();
                    cb_role.SelectedItem = row.Cells["U_Role"].Value.ToString();
                }
                else if (currentMode == "Category")
                {
                    CatID = (int)row.Cells["Cat_Id"].Value;
                    txt_name.Text = row.Cells["Cat_Name"].Value.ToString();
                }
            }


        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_name.Text = txt_price.Text = txt_amount.Text = "";
            cb_category.SelectedIndex = 0;
            cb_role.SelectedIndex = 0;
        }

        /* --------------------------- Products CRUD Operations -----------------------------*/
        private void btn_products_Click(object sender, EventArgs e)
        {
            currentMode = "Product";

            LoadProductsAndCategories();

            txt_price.Visible = txt_amount.Visible = cb_category.Visible =
            lbl_amount.Visible = lbl_category.Visible = lbl_price.Visible = btn_clear.Visible =
            btn_add.Visible = btn_delete.Visible = btn_update.Visible = true;

            btn_addCat.Visible = btn_updateCat.Visible = btn_deleteCat.Visible =
            btn_deleteUser.Visible = btn_updateUser.Visible = cb_role.Visible = lbl_role.Visible = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text;
            int price = int.Parse(txt_price.Text);
            int amount = int.Parse(txt_amount.Text);
            int catID = (int)cb_category.SelectedValue;

            int rowsAffected = productSercvices.AddProduct(name, price, amount, catID);
            if (rowsAffected > 0)
            {
                MessageBox.Show("Added Successfully");
                txt_name.Text = txt_price.Text = txt_amount.Text = "";
                cb_category.SelectedIndex = 0;
                LoadProductsAndCategories();
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text;
            int price = int.Parse(txt_price.Text);
            int amount = int.Parse(txt_amount.Text);
            int catID = (int)cb_category.SelectedValue;

            int rowsAffected = productSercvices.UpdateProduct(ProdID, name, price, amount, catID);
            if (rowsAffected > 0)
            {
                MessageBox.Show("Updated Successfully");
                txt_name.Text = txt_price.Text = txt_amount.Text = "";
                cb_category.SelectedIndex = 0;
                LoadProductsAndCategories();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int rowsAffected = productSercvices.DeleteProduct(ProdID);
            if (rowsAffected > 0)
            {
                MessageBox.Show("Deleted Successfully");
                txt_name.Text = txt_price.Text = txt_amount.Text = "";
                cb_category.SelectedIndex = 0;
                LoadProductsAndCategories();
            }
        }
        /* --------------------------- Products CRUD Operations -----------------------------*/

        /* --------------------------- Categories CRUD Operations -----------------------------*/
        private void btn_categories_Click(object sender, EventArgs e)
        {
            currentMode = "Category";

            txt_price.Visible = txt_amount.Visible = cb_category.Visible =
            lbl_amount.Visible = lbl_category.Visible = lbl_price.Visible = false;

            btn_add.Visible = btn_update.Visible = btn_delete.Visible =
            btn_deleteUser.Visible = btn_updateUser.Visible = cb_role.Visible = lbl_role.Visible = false;

            btn_addCat.Visible = btn_updateCat.Visible = btn_deleteCat.Visible = true;

            LoadCategories();
        }

        private void btn_addCat_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text;

            int rowsAffected = categorySercvices.AddCategory(name);
            if (rowsAffected > 0)
            {
                MessageBox.Show("Added Successfully");
                txt_name.Text = "";
                LoadCategories();
            }
        }

        private void btn_deleteCat_Click(object sender, EventArgs e)
        {
            int rowsAffected = categorySercvices.DeleteCategory(CatID);
            if (rowsAffected > 0)
            {
                MessageBox.Show("Deleted Successfully");
                txt_name.Text = "";
                LoadCategories();
            }
        }

        private void btn_updateCat_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text;

            int rowsAffected = categorySercvices.UpdateCategory(CatID, name);
            if (rowsAffected > 0)
            {
                MessageBox.Show("Updated Successfully");
                txt_name.Text = "";
                LoadCategories();
            }
        }
        /* --------------------------- Categories CRUD Operations -----------------------------*/

        /* --------------------------- Users CRUD Operations -----------------------------*/
        private void btn_users_Click(object sender, EventArgs e)
        {
            currentMode = "User";

            btn_deleteUser.Visible = btn_updateUser.Visible = cb_role.Visible = lbl_role.Visible = true;

            btn_add.Visible = btn_update.Visible = btn_delete.Visible =
            btn_addCat.Visible = btn_updateCat.Visible = btn_deleteCat.Visible =
            lbl_price.Visible = lbl_category.Visible = lbl_amount.Visible =
            txt_price.Visible = txt_amount.Visible = cb_category.Visible = false;

            LoadUsers();
        }

        private void btn_deleteUser_Click(object sender, EventArgs e)
        {
            int rowsAffected = userSercvices.DeleteUser(UserID);
            if (rowsAffected > 0)
            {
                MessageBox.Show("Deleted Successfully");
                txt_name.Text = "";
                cb_role.SelectedIndex = 0;
                LoadUsers();
            }
        }

        private void btn_updateUser_Click(object sender, EventArgs e)
        {
            string role = cb_role.SelectedItem.ToString();
            int rowsAffected = userSercvices.UpdateUserRole(UserID, role);
            if (rowsAffected > 0)
            {
                MessageBox.Show("Updated Successfully");
                txt_name.Text = "";
                cb_role.SelectedIndex = 0;
                LoadUsers();
            }
        }
        /* --------------------------- Users CRUD Operations -----------------------------*/
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
    }
}
