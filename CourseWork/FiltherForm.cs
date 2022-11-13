namespace CourseWork
{
    public partial class FiltherForm : Form
    {
        public int AreaMin;
        public int AreaMax;

        public FiltherForm()
        { 
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbMin.Text, out AreaMin))
            {
                MessageBox.Show("Неправильно введено число!", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                tbMin.Focus(); return;
            }
            if (!int.TryParse(tbMax.Text, out AreaMax))
            {
                MessageBox.Show("Неправильно введено число!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbMin.Focus(); return;
            }

            DialogResult = DialogResult.OK;


        }

        private void FiltherForm_Load(object sender, EventArgs e)
        {
            tbMin.Text = AreaMin.ToString("0"); 
        }
    }
}
