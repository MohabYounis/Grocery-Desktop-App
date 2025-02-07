namespace Resturant.Presentation
{
    partial class Pres_User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pres_User));
            lbl_welcome = new Label();
            btn_profile = new Button();
            btn_product = new Button();
            button4 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // lbl_welcome
            // 
            lbl_welcome.BackColor = Color.Transparent;
            lbl_welcome.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            lbl_welcome.ForeColor = Color.White;
            lbl_welcome.Location = new Point(12, 54);
            lbl_welcome.Name = "lbl_welcome";
            lbl_welcome.Size = new Size(567, 65);
            lbl_welcome.TabIndex = 0;
            lbl_welcome.Text = "Welcome ";
            lbl_welcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_profile
            // 
            btn_profile.BackColor = Color.FromArgb(113, 199, 36);
            btn_profile.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_profile.ForeColor = Color.White;
            btn_profile.Location = new Point(170, 216);
            btn_profile.Name = "btn_profile";
            btn_profile.Size = new Size(248, 73);
            btn_profile.TabIndex = 1;
            btn_profile.Text = "Show Profile";
            btn_profile.UseVisualStyleBackColor = false;
            btn_profile.Click += btn_profile_Click;
            // 
            // btn_product
            // 
            btn_product.BackColor = Color.FromArgb(113, 199, 36);
            btn_product.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_product.ForeColor = Color.White;
            btn_product.Location = new Point(170, 332);
            btn_product.Name = "btn_product";
            btn_product.Size = new Size(248, 73);
            btn_product.TabIndex = 3;
            btn_product.Text = "Show Products";
            btn_product.UseVisualStyleBackColor = false;
            btn_product.Click += btn_product_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(113, 199, 36);
            button4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button4.ForeColor = Color.White;
            button4.Location = new Point(510, 12);
            button4.Name = "button4";
            button4.Size = new Size(69, 39);
            button4.TabIndex = 29;
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
            button3.TabIndex = 30;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Pres_User
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(600, 800);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(btn_product);
            Controls.Add(btn_profile);
            Controls.Add(lbl_welcome);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Pres_User";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pres_User";
            Load += Pres_User_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_welcome;
        private Button btn_profile;
        private Button btn_product;
        private Button button4;
        private Button button3;
    }
}