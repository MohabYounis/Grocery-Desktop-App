namespace Resturant.Presentation
{
    partial class Pres_Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pres_Signup));
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            btn_signup = new Button();
            button1 = new Button();
            button2 = new Button();
            txt_name = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            txt_pass = new TextBox();
            groupBox3 = new GroupBox();
            txt_email = new TextBox();
            groupBox4 = new GroupBox();
            txt_passConfirm = new TextBox();
            groupBox5 = new GroupBox();
            txt_address = new TextBox();
            groupBox6 = new GroupBox();
            txt_phone = new TextBox();
            dateTimePicker = new DateTimePicker();
            groupBox7 = new GroupBox();
            lbl_email = new Label();
            lbl_phone = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox7.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(78, 9);
            label2.Name = "label2";
            label2.Size = new Size(440, 61);
            label2.TabIndex = 18;
            label2.Text = "Signup";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // linkLabel1
            // 
            linkLabel1.Cursor = Cursors.Hand;
            linkLabel1.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel1.LinkColor = Color.FromArgb(108, 197, 29);
            linkLabel1.Location = new Point(355, 731);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(161, 25);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Login";
            linkLabel1.TextAlign = ContentAlignment.MiddleLeft;
            linkLabel1.VisitedLinkColor = Color.Black;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(76, 732);
            label1.Name = "label1";
            label1.Size = new Size(283, 25);
            label1.TabIndex = 15;
            label1.Text = "Already have an account?";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btn_signup
            // 
            btn_signup.BackColor = Color.FromArgb(113, 199, 36);
            btn_signup.FlatAppearance.BorderColor = Color.FromArgb(158, 215, 105);
            btn_signup.FlatAppearance.BorderSize = 0;
            btn_signup.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_signup.ForeColor = Color.White;
            btn_signup.Location = new Point(76, 654);
            btn_signup.Name = "btn_signup";
            btn_signup.Size = new Size(440, 51);
            btn_signup.TabIndex = 7;
            btn_signup.Text = "Signup";
            btn_signup.UseVisualStyleBackColor = false;
            btn_signup.Click += btn_login_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(113, 199, 36);
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(60, 39);
            button1.TabIndex = 9;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(113, 199, 36);
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(519, 12);
            button2.Name = "button2";
            button2.Size = new Size(69, 39);
            button2.TabIndex = 10;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // txt_name
            // 
            txt_name.Font = new Font("Segoe UI", 12F);
            txt_name.Location = new Point(15, 23);
            txt_name.Margin = new Padding(0);
            txt_name.Name = "txt_name";
            txt_name.PlaceholderText = "mohab younis";
            txt_name.Size = new Size(412, 34);
            txt_name.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_name);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox1.ForeColor = Color.FromArgb(113, 199, 36);
            groupBox1.Location = new Point(78, 73);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(438, 69);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Name";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txt_pass);
            groupBox2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox2.ForeColor = Color.FromArgb(113, 199, 36);
            groupBox2.Location = new Point(78, 246);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(438, 66);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "Password";
            // 
            // txt_pass
            // 
            txt_pass.Font = new Font("Segoe UI", 12F);
            txt_pass.Location = new Point(15, 23);
            txt_pass.Margin = new Padding(0);
            txt_pass.Name = "txt_pass";
            txt_pass.Size = new Size(412, 34);
            txt_pass.TabIndex = 2;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txt_email);
            groupBox3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox3.ForeColor = Color.FromArgb(113, 199, 36);
            groupBox3.Location = new Point(78, 148);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(438, 67);
            groupBox3.TabIndex = 20;
            groupBox3.TabStop = false;
            groupBox3.Text = "Email";
            // 
            // txt_email
            // 
            txt_email.Font = new Font("Segoe UI", 12F);
            txt_email.Location = new Point(15, 23);
            txt_email.Margin = new Padding(0);
            txt_email.Name = "txt_email";
            txt_email.PlaceholderText = "example@email.com";
            txt_email.Size = new Size(412, 34);
            txt_email.TabIndex = 1;
            txt_email.Leave += txt_email_Leave;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txt_passConfirm);
            groupBox4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox4.ForeColor = Color.FromArgb(113, 199, 36);
            groupBox4.Location = new Point(78, 318);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(438, 66);
            groupBox4.TabIndex = 21;
            groupBox4.TabStop = false;
            groupBox4.Text = "Confirm Password";
            // 
            // txt_passConfirm
            // 
            txt_passConfirm.Font = new Font("Segoe UI", 12F);
            txt_passConfirm.Location = new Point(15, 23);
            txt_passConfirm.Margin = new Padding(0);
            txt_passConfirm.Name = "txt_passConfirm";
            txt_passConfirm.Size = new Size(412, 34);
            txt_passConfirm.TabIndex = 3;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(txt_address);
            groupBox5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox5.ForeColor = Color.FromArgb(113, 199, 36);
            groupBox5.Location = new Point(78, 390);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(438, 68);
            groupBox5.TabIndex = 21;
            groupBox5.TabStop = false;
            groupBox5.Text = "Address";
            // 
            // txt_address
            // 
            txt_address.Font = new Font("Segoe UI", 12F);
            txt_address.Location = new Point(15, 23);
            txt_address.Margin = new Padding(0);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(412, 34);
            txt_address.TabIndex = 4;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(txt_phone);
            groupBox6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox6.ForeColor = Color.FromArgb(113, 199, 36);
            groupBox6.Location = new Point(78, 464);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(438, 72);
            groupBox6.TabIndex = 22;
            groupBox6.TabStop = false;
            groupBox6.Text = "Phone";
            // 
            // txt_phone
            // 
            txt_phone.Font = new Font("Segoe UI", 12F);
            txt_phone.Location = new Point(15, 23);
            txt_phone.Margin = new Padding(0);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(412, 34);
            txt_phone.TabIndex = 5;
            txt_phone.Leave += txt_phone_Leave;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(15, 29);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(412, 30);
            dateTimePicker.TabIndex = 6;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(dateTimePicker);
            groupBox7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox7.ForeColor = Color.FromArgb(113, 199, 36);
            groupBox7.Location = new Point(78, 564);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(438, 74);
            groupBox7.TabIndex = 23;
            groupBox7.TabStop = false;
            groupBox7.Text = "Birth Date";
            // 
            // lbl_email
            // 
            lbl_email.Font = new Font("Segoe UI", 10F);
            lbl_email.Location = new Point(398, 218);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(118, 25);
            lbl_email.TabIndex = 24;
            lbl_email.Text = "label3";
            lbl_email.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_phone
            // 
            lbl_phone.Font = new Font("Segoe UI", 10F);
            lbl_phone.Location = new Point(398, 539);
            lbl_phone.Name = "lbl_phone";
            lbl_phone.Size = new Size(118, 25);
            lbl_phone.TabIndex = 25;
            lbl_phone.Text = "label3";
            lbl_phone.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Pres_Signup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(600, 800);
            Controls.Add(lbl_phone);
            Controls.Add(lbl_email);
            Controls.Add(groupBox7);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Controls.Add(btn_signup);
            Controls.Add(button1);
            Controls.Add(button2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Pres_Signup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pres_Signup";
            Load += Pres_Signup_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private LinkLabel linkLabel1;
        private Label label1;
        private Button btn_signup;
        private Button button1;
        private Button button2;
        private TextBox txt_name;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txt_pass;
        private GroupBox groupBox3;
        private TextBox txt_email;
        private GroupBox groupBox4;
        private TextBox txt_passConfirm;
        private GroupBox groupBox5;
        private TextBox txt_address;
        private GroupBox groupBox6;
        private TextBox txt_phone;
        private DateTimePicker dateTimePicker;
        private GroupBox groupBox7;
        private Label lbl_email;
        private Label lbl_phone;
    }
}