namespace Resturant.Presentation
{
    partial class Pres_Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pres_Admin));
            pnl_main = new Panel();
            btn_categories = new Button();
            button4 = new Button();
            button3 = new Button();
            btn_users = new Button();
            btn_products = new Button();
            lbl_name = new Label();
            pnl_view = new Panel();
            lbl_role = new Label();
            cb_role = new ComboBox();
            btn_updateUser = new Button();
            btn_deleteUser = new Button();
            btn_updateCat = new Button();
            btn_deleteCat = new Button();
            btn_addCat = new Button();
            lbl_category = new Label();
            cb_category = new ComboBox();
            lbl_amount = new Label();
            txt_amount = new TextBox();
            lbl_price = new Label();
            txt_price = new TextBox();
            label2 = new Label();
            txt_name = new TextBox();
            btn_clear = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            btn_add = new Button();
            dgv_prodAndUser = new DataGridView();
            pnl_main.SuspendLayout();
            pnl_view.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_prodAndUser).BeginInit();
            SuspendLayout();
            // 
            // pnl_main
            // 
            pnl_main.BackColor = SystemColors.GradientInactiveCaption;
            pnl_main.BackgroundImage = (Image)resources.GetObject("pnl_main.BackgroundImage");
            pnl_main.BackgroundImageLayout = ImageLayout.Stretch;
            pnl_main.Controls.Add(btn_categories);
            pnl_main.Controls.Add(button4);
            pnl_main.Controls.Add(button3);
            pnl_main.Controls.Add(btn_users);
            pnl_main.Controls.Add(btn_products);
            pnl_main.Controls.Add(lbl_name);
            pnl_main.Dock = DockStyle.Left;
            pnl_main.Location = new Point(0, 0);
            pnl_main.Name = "pnl_main";
            pnl_main.Size = new Size(385, 800);
            pnl_main.TabIndex = 0;
            // 
            // btn_categories
            // 
            btn_categories.BackColor = Color.FromArgb(113, 199, 36);
            btn_categories.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_categories.ForeColor = Color.White;
            btn_categories.Location = new Point(95, 222);
            btn_categories.Name = "btn_categories";
            btn_categories.Size = new Size(182, 57);
            btn_categories.TabIndex = 29;
            btn_categories.Text = "Categories";
            btn_categories.UseVisualStyleBackColor = false;
            btn_categories.Click += btn_categories_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(113, 199, 36);
            button4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button4.ForeColor = Color.White;
            button4.Location = new Point(309, 12);
            button4.Name = "button4";
            button4.Size = new Size(69, 39);
            button4.TabIndex = 27;
            button4.Text = "X";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(113, 199, 36);
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Center;
            button3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button3.Location = new Point(12, 12);
            button3.Name = "button3";
            button3.Size = new Size(69, 39);
            button3.TabIndex = 28;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btn_users
            // 
            btn_users.BackColor = Color.FromArgb(113, 199, 36);
            btn_users.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_users.ForeColor = Color.White;
            btn_users.Location = new Point(95, 301);
            btn_users.Name = "btn_users";
            btn_users.Size = new Size(182, 57);
            btn_users.TabIndex = 2;
            btn_users.Text = "Users";
            btn_users.UseVisualStyleBackColor = false;
            btn_users.Click += btn_users_Click;
            // 
            // btn_products
            // 
            btn_products.BackColor = Color.FromArgb(113, 199, 36);
            btn_products.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_products.ForeColor = Color.White;
            btn_products.Location = new Point(95, 145);
            btn_products.Name = "btn_products";
            btn_products.Size = new Size(182, 57);
            btn_products.TabIndex = 1;
            btn_products.Text = "Products";
            btn_products.UseVisualStyleBackColor = false;
            btn_products.Click += btn_products_Click;
            // 
            // lbl_name
            // 
            lbl_name.BackColor = Color.Transparent;
            lbl_name.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lbl_name.ForeColor = Color.FromArgb(64, 64, 64);
            lbl_name.Location = new Point(3, 61);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(379, 61);
            lbl_name.TabIndex = 0;
            lbl_name.Text = "Welcome";
            lbl_name.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnl_view
            // 
            pnl_view.BackColor = Color.FromArgb(220, 210, 198);
            pnl_view.Controls.Add(lbl_role);
            pnl_view.Controls.Add(cb_role);
            pnl_view.Controls.Add(btn_updateUser);
            pnl_view.Controls.Add(btn_deleteUser);
            pnl_view.Controls.Add(btn_updateCat);
            pnl_view.Controls.Add(btn_deleteCat);
            pnl_view.Controls.Add(btn_addCat);
            pnl_view.Controls.Add(lbl_category);
            pnl_view.Controls.Add(cb_category);
            pnl_view.Controls.Add(lbl_amount);
            pnl_view.Controls.Add(txt_amount);
            pnl_view.Controls.Add(lbl_price);
            pnl_view.Controls.Add(txt_price);
            pnl_view.Controls.Add(label2);
            pnl_view.Controls.Add(txt_name);
            pnl_view.Controls.Add(btn_clear);
            pnl_view.Controls.Add(btn_update);
            pnl_view.Controls.Add(btn_delete);
            pnl_view.Controls.Add(btn_add);
            pnl_view.Controls.Add(dgv_prodAndUser);
            pnl_view.Dock = DockStyle.Right;
            pnl_view.Location = new Point(384, 0);
            pnl_view.Name = "pnl_view";
            pnl_view.Size = new Size(616, 800);
            pnl_view.TabIndex = 1;
            // 
            // lbl_role
            // 
            lbl_role.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbl_role.ForeColor = Color.FromArgb(64, 64, 64);
            lbl_role.Location = new Point(86, 116);
            lbl_role.Name = "lbl_role";
            lbl_role.Size = new Size(92, 25);
            lbl_role.TabIndex = 52;
            lbl_role.Text = "Role";
            lbl_role.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cb_role
            // 
            cb_role.FormattingEnabled = true;
            cb_role.Location = new Point(196, 113);
            cb_role.Name = "cb_role";
            cb_role.Size = new Size(218, 28);
            cb_role.TabIndex = 51;
            // 
            // btn_updateUser
            // 
            btn_updateUser.BackColor = Color.FromArgb(173, 122, 1);
            btn_updateUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_updateUser.ForeColor = Color.White;
            btn_updateUser.Location = new Point(241, 272);
            btn_updateUser.Name = "btn_updateUser";
            btn_updateUser.Size = new Size(140, 57);
            btn_updateUser.TabIndex = 50;
            btn_updateUser.Text = "Update";
            btn_updateUser.UseVisualStyleBackColor = false;
            btn_updateUser.Click += btn_updateUser_Click;
            // 
            // btn_deleteUser
            // 
            btn_deleteUser.BackColor = Color.FromArgb(173, 122, 1);
            btn_deleteUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_deleteUser.ForeColor = Color.White;
            btn_deleteUser.Location = new Point(393, 272);
            btn_deleteUser.Name = "btn_deleteUser";
            btn_deleteUser.Size = new Size(140, 57);
            btn_deleteUser.TabIndex = 49;
            btn_deleteUser.Text = "Delete";
            btn_deleteUser.UseVisualStyleBackColor = false;
            btn_deleteUser.Click += btn_deleteUser_Click;
            // 
            // btn_updateCat
            // 
            btn_updateCat.BackColor = Color.FromArgb(173, 122, 1);
            btn_updateCat.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_updateCat.ForeColor = Color.White;
            btn_updateCat.Location = new Point(241, 272);
            btn_updateCat.Name = "btn_updateCat";
            btn_updateCat.Size = new Size(140, 57);
            btn_updateCat.TabIndex = 48;
            btn_updateCat.Text = "Update";
            btn_updateCat.UseVisualStyleBackColor = false;
            btn_updateCat.Click += btn_updateCat_Click;
            // 
            // btn_deleteCat
            // 
            btn_deleteCat.BackColor = Color.FromArgb(173, 122, 1);
            btn_deleteCat.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_deleteCat.ForeColor = Color.White;
            btn_deleteCat.Location = new Point(393, 272);
            btn_deleteCat.Name = "btn_deleteCat";
            btn_deleteCat.Size = new Size(140, 57);
            btn_deleteCat.TabIndex = 47;
            btn_deleteCat.Text = "Delete";
            btn_deleteCat.UseVisualStyleBackColor = false;
            btn_deleteCat.Click += btn_deleteCat_Click;
            // 
            // btn_addCat
            // 
            btn_addCat.BackColor = Color.FromArgb(173, 122, 1);
            btn_addCat.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_addCat.ForeColor = Color.White;
            btn_addCat.Location = new Point(86, 272);
            btn_addCat.Name = "btn_addCat";
            btn_addCat.Size = new Size(140, 57);
            btn_addCat.TabIndex = 46;
            btn_addCat.Text = "Add";
            btn_addCat.UseVisualStyleBackColor = false;
            btn_addCat.Click += btn_addCat_Click;
            // 
            // lbl_category
            // 
            lbl_category.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbl_category.ForeColor = Color.FromArgb(64, 64, 64);
            lbl_category.Location = new Point(86, 205);
            lbl_category.Name = "lbl_category";
            lbl_category.Size = new Size(92, 25);
            lbl_category.TabIndex = 45;
            lbl_category.Text = "Category";
            lbl_category.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cb_category
            // 
            cb_category.FormattingEnabled = true;
            cb_category.Location = new Point(196, 205);
            cb_category.Name = "cb_category";
            cb_category.Size = new Size(218, 28);
            cb_category.TabIndex = 44;
            // 
            // lbl_amount
            // 
            lbl_amount.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbl_amount.ForeColor = Color.FromArgb(64, 64, 64);
            lbl_amount.Location = new Point(86, 157);
            lbl_amount.Name = "lbl_amount";
            lbl_amount.Size = new Size(92, 25);
            lbl_amount.TabIndex = 43;
            lbl_amount.Text = "Amount";
            lbl_amount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_amount
            // 
            txt_amount.Location = new Point(196, 157);
            txt_amount.Name = "txt_amount";
            txt_amount.Size = new Size(218, 27);
            txt_amount.TabIndex = 42;
            // 
            // lbl_price
            // 
            lbl_price.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbl_price.ForeColor = Color.FromArgb(64, 64, 64);
            lbl_price.Location = new Point(86, 116);
            lbl_price.Name = "lbl_price";
            lbl_price.Size = new Size(92, 25);
            lbl_price.TabIndex = 41;
            lbl_price.Text = "Price";
            lbl_price.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_price
            // 
            txt_price.Location = new Point(196, 114);
            txt_price.Name = "txt_price";
            txt_price.Size = new Size(218, 27);
            txt_price.TabIndex = 40;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(86, 70);
            label2.Name = "label2";
            label2.Size = new Size(92, 25);
            label2.TabIndex = 39;
            label2.Text = "Name";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(196, 70);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(218, 27);
            txt_name.TabIndex = 38;
            // 
            // btn_clear
            // 
            btn_clear.BackColor = Color.FromArgb(173, 122, 1);
            btn_clear.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_clear.ForeColor = Color.White;
            btn_clear.Location = new Point(443, 70);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(90, 163);
            btn_clear.TabIndex = 37;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.FromArgb(173, 122, 1);
            btn_update.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_update.ForeColor = Color.White;
            btn_update.Location = new Point(241, 272);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(140, 57);
            btn_update.TabIndex = 36;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.FromArgb(173, 122, 1);
            btn_delete.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_delete.ForeColor = Color.White;
            btn_delete.Location = new Point(393, 272);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(140, 57);
            btn_delete.TabIndex = 35;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.FromArgb(173, 122, 1);
            btn_add.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_add.ForeColor = Color.White;
            btn_add.Location = new Point(86, 272);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(140, 57);
            btn_add.TabIndex = 34;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // dgv_prodAndUser
            // 
            dgv_prodAndUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_prodAndUser.BackgroundColor = SystemColors.ButtonFace;
            dgv_prodAndUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_prodAndUser.Dock = DockStyle.Bottom;
            dgv_prodAndUser.Location = new Point(0, 431);
            dgv_prodAndUser.Name = "dgv_prodAndUser";
            dgv_prodAndUser.RowHeadersWidth = 51;
            dgv_prodAndUser.Size = new Size(616, 369);
            dgv_prodAndUser.TabIndex = 15;
            dgv_prodAndUser.RowHeaderMouseDoubleClick += dgv_prodAndUser_RowHeaderMouseDoubleClick;
            // 
            // Pres_Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 800);
            Controls.Add(pnl_view);
            Controls.Add(pnl_main);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Pres_Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pres_Admin";
            Load += Pres_Admin_Load;
            pnl_main.ResumeLayout(false);
            pnl_view.ResumeLayout(false);
            pnl_view.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_prodAndUser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_main;
        private Label lbl_name;
        private Panel pnl_view;
        private Button btn_users;
        private Button btn_products;
        private DataGridView dgv_prodAndUser;
        private Button button4;
        private Button button3;
        private Button btn_categories;
        private Button btn_updateUser;
        private Button btn_deleteUser;
        private Button btn_updateCat;
        private Button btn_deleteCat;
        private Button btn_addCat;
        private Label lbl_category;
        private ComboBox cb_category;
        private Label lbl_amount;
        private TextBox txt_amount;
        private Label lbl_price;
        private TextBox txt_price;
        private Label label2;
        private TextBox txt_name;
        private Button btn_clear;
        private Button btn_update;
        private Button btn_delete;
        private Button btn_add;
        private Label lbl_role;
        private ComboBox cb_role;
    }
}