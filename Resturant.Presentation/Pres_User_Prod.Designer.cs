namespace Resturant.Presentation
{
    partial class Pres_User_Prod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pres_User_Prod));
            panel1 = new Panel();
            button4 = new Button();
            button3 = new Button();
            btn_add = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 192);
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(409, 800);
            panel1.TabIndex = 0;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(113, 199, 36);
            button4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button4.ForeColor = Color.White;
            button4.Location = new Point(327, 12);
            button4.Name = "button4";
            button4.Size = new Size(69, 39);
            button4.TabIndex = 31;
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
            button3.TabIndex = 32;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.FromArgb(113, 199, 36);
            btn_add.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_add.ForeColor = Color.White;
            btn_add.Location = new Point(602, 204);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(187, 62);
            btn_add.TabIndex = 35;
            btn_add.Text = "Add to Favorite";
            btn_add.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(409, 454);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(591, 346);
            dataGridView1.TabIndex = 0;
            // 
            // Pres_User_Prod
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 800);
            Controls.Add(dataGridView1);
            Controls.Add(btn_add);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Pres_User_Prod";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pres_User_Prod";
            Load += Pres_User_Prod_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button4;
        private Button button3;
        private Button btn_add;
        private DataGridView dataGridView1;
    }
}