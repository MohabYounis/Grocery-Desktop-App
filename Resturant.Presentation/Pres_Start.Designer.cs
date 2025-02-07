namespace Resturant.Presentation
{
    partial class Pres_Start
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pres_Start));
            btn_start = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btn_start
            // 
            btn_start.BackColor = Color.FromArgb(113, 199, 36);
            btn_start.FlatAppearance.BorderColor = Color.FromArgb(158, 215, 105);
            btn_start.FlatAppearance.BorderSize = 0;
            btn_start.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_start.ForeColor = Color.White;
            btn_start.Location = new Point(60, 688);
            btn_start.Name = "btn_start";
            btn_start.Size = new Size(475, 68);
            btn_start.TabIndex = 0;
            btn_start.Text = "Get Started";
            btn_start.UseVisualStyleBackColor = false;
            btn_start.Click += btn_start_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(113, 199, 36);
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.Location = new Point(519, 12);
            button1.Name = "button1";
            button1.Size = new Size(69, 39);
            button1.TabIndex = 1;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Pres_Start
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(600, 800);
            Controls.Add(button1);
            Controls.Add(btn_start);
            DoubleBuffered = true;
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Pres_Start";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_start;
        private Button button1;
    }
}
