namespace CourseWork
{
    public partial class StartForm : Form
    {
        private MainForm mainForm = new MainForm();
        private CompanyForm compForm = new CompanyForm();
        private ModelForm modelForm = new ModelForm();
        public StartForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            mainForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            compForm.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            modelForm.Show();
            this.Hide();
        }
    }
}
