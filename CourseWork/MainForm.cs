using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class MainForm : Form
    {
        public List<Ploter> ploter { get; set; }
        
        public MainForm()
        {
            ploter = GetPloter("Jum", "Japan", "Mda3", 4, 10, 1000, true, false);
            InitializeComponent();
        }
        public List<Ploter> GetPloter(string name, string country, string model, int countcolors, int weight, double price, bool winSup, bool macSup)
        {
            var list = new List<Ploter>();
            list.Add(new Ploter()
            {
                Name = name,
                Country = country,
                Model = model,
                CountColors = countcolors,
                Weight = weight,
                Price = price,
                WinSupport = winSup,
                MacSupport = macSup
            });
            return list;
        }
        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PloterForm add_form = new PloterForm();
            add_form.ShowDialog();

            if (add_form.ShowDialog() == DialogResult.OK)
            {
                ploter = GetPloter("Jgfrum", "Japan", "Mda3", 4, 10, 1000, true, false);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DataGridViewColumn column = new DataGridViewTextBoxColumn(); 
            column.DataPropertyName = "Name";
            column.HeaderText = "Назва"; dataGridView1.Columns.Add(column);

            column = new DataGridViewTextBoxColumn(); 
            column.DataPropertyName = "Country"; 
            column.HeaderText = "Країна"; dataGridView1.Columns.Add(column);

            column = new DataGridViewTextBoxColumn(); 
            column.DataPropertyName = "Model"; 
            column.HeaderText = "Модель"; dataGridView1.Columns.Add(column);

            column = new DataGridViewTextBoxColumn(); 
            column.DataPropertyName = "CountColors"; 
            column.HeaderText = "К-сть кольорів"; dataGridView1.Columns.Add(column);

            column = new DataGridViewTextBoxColumn(); 
            column.DataPropertyName = "Weight"; 
            column.HeaderText = "Вага"; dataGridView1.Columns.Add(column);

            column = new DataGridViewTextBoxColumn(); 
            column.DataPropertyName = "Price"; 
            column.HeaderText = "Ціна";
            column.Width = 80; dataGridView1.Columns.Add(column);


            column = new DataGridViewCheckBoxColumn(); 
            column.DataPropertyName = "WinSupport"; 
            column.HeaderText = "Підтримка Windows";
            column.Width = 60; dataGridView1.Columns.Add(column);

            column = new DataGridViewCheckBoxColumn(); 
            column.DataPropertyName = "MacSupport"; 
            column.HeaderText = "Підтримка Mac"; 
            column.Width = 60; dataGridView1.Columns.Add(column);

            EventArgs args = new EventArgs(); OnResize(args);


            var ploter = this.ploter;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = ploter;
        }
    }
}