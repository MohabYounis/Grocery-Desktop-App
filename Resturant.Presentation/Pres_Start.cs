namespace Resturant.Presentation
{
    public partial class Pres_Start : Form
    {
        public Pres_Start()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are You Sure You Want To Exit The Program?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pres_Login pres_login = new Pres_Login();
            pres_login.Show();
        }
    }
}
