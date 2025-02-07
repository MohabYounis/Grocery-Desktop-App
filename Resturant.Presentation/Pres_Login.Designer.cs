namespace Resturant.Presentation
{
    partial class Pres_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pres_Login));
            txt_email = new TextBox();
            button2 = new Button();
            button1 = new Button();
            btn_login = new Button();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            txt_pass = new TextBox();
            checkBox = new CheckBox();
            label2 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            lbl_email = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txt_email
            // 
            txt_email.BackColor = Color.White;
            txt_email.Font = new Font("Segoe UI", 17F);
            txt_email.Location = new Point(134, 443);
            txt_email.Margin = new Padding(0);
            txt_email.Name = "txt_email";
            txt_email.PlaceholderText = " Email Address";
            txt_email.Size = new Size(379, 45);
            txt_email.TabIndex = 0;
            txt_email.Leave += txt_email_Leave;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(113, 199, 36);
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(519, 12);
            button2.Name = "button2";
            button2.Size = new Size(69, 39);
            button2.TabIndex = 5;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(113, 199, 36);
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(69, 39);
            button1.TabIndex = 6;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.FromArgb(113, 199, 36);
            btn_login.Cursor = Cursors.Hand;
            btn_login.FlatAppearance.BorderColor = Color.FromArgb(158, 215, 105);
            btn_login.FlatAppearance.BorderSize = 0;
            btn_login.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(78, 632);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(435, 51);
            btn_login.TabIndex = 3;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_start_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(78, 714);
            label1.Name = "label1";
            label1.Size = new Size(263, 25);
            label1.TabIndex = 6;
            label1.Text = "Don't have an account?";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.FromArgb(108, 197, 29);
            linkLabel1.Cursor = Cursors.Hand;
            linkLabel1.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel1.LinkColor = Color.FromArgb(108, 197, 29);
            linkLabel1.Location = new Point(338, 714);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(180, 25);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Sign up";
            linkLabel1.TextAlign = ContentAlignment.MiddleLeft;
            linkLabel1.VisitedLinkColor = Color.Black;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // txt_pass
            // 
            txt_pass.Font = new Font("Segoe UI", 17F);
            txt_pass.Location = new Point(134, 537);
            txt_pass.Margin = new Padding(0);
            txt_pass.Name = "txt_pass";
            txt_pass.PlaceholderText = " Password";
            txt_pass.Size = new Size(379, 45);
            txt_pass.TabIndex = 1;
            // 
            // checkBox
            // 
            checkBox.AutoSize = true;
            checkBox.Cursor = Cursors.Hand;
            checkBox.Location = new Point(384, 585);
            checkBox.Name = "checkBox";
            checkBox.Size = new Size(134, 24);
            checkBox.TabIndex = 2;
            checkBox.Text = "Show password";
            checkBox.UseVisualStyleBackColor = true;
            checkBox.CheckedChanged += checkBox_CheckedChanged;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(87, 370);
            label2.Name = "label2";
            label2.Size = new Size(426, 61);
            label2.TabIndex = 10;
            label2.Text = "Login";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Location = new Point(87, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(426, 366);
            panel1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(78, 443);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 45);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.Control;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Location = new Point(78, 537);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(53, 45);
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // lbl_email
            // 
            lbl_email.Font = new Font("Segoe UI", 10F);
            lbl_email.Location = new Point(354, 488);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(159, 25);
            lbl_email.TabIndex = 15;
            lbl_email.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Pres_Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(600, 800);
            Controls.Add(lbl_email);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(checkBox);
            Controls.Add(txt_pass);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Controls.Add(btn_login);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(txt_email);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Pres_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pres_Login";
            Load += Pres_Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_email;
        private Button button2;
        private Button button1;
        private Button btn_login;
        private Label label1;
        private LinkLabel linkLabel1;
        private TextBox txt_pass;
        private CheckBox checkBox;
        private Label label2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label lbl_email;
    }
}