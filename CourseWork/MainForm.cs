using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml;

namespace CourseWork
{
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }
    public partial class MainForm : Form
    {
        DataBase database = new DataBase();
        int selectedRow;
       public MainForm()
        {
            InitializeComponent();
        }
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("Name", "Назва");
            dataGridView1.Columns.Add("Country", "Країна");
            dataGridView1.Columns.Add("Model", "Модель");
            dataGridView1.Columns.Add("CountColors", "К-сть Кольорів");
            dataGridView1.Columns.Add("Weight", "Вага");
            dataGridView1.Columns.Add("Price", "Ціна");

            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "WinSupport";
            column.HeaderText = "Підтримка Windows";
            column.Width = 60; dataGridView1.Columns.Add(column);

            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "MacSupport";
            column.HeaderText = "Підтримка Mac";
            column.Width = 60; dataGridView1.Columns.Add(column);

            dataGridView1.Columns.Add("id", "ID");
            dataGridView1.Columns.Add("IsNew", String.Empty);
            
            EventArgs args = new EventArgs(); OnResize(args);


            dataGridView1.AutoGenerateColumns = false;
        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(
                record.GetString(0), 
                record.GetString(1), 
                record.GetString(2), 
                record.GetInt32(3), 
                record.GetInt32(4), 
                record.GetInt32(5), 
                record.GetBoolean(6), 
                record.GetBoolean(7),
                record.GetInt32(8),
                RowState.ModifiedNew
                );
            
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select * from Products";

            SqlCommand command = new SqlCommand(queryString, database.getConnection());
            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchString = $"select * from Products where concat (Name, Country, Model, CountColors, Weight, Price, WinSup, MacSup) like '%" + tstbSearch.Text + "%'";

            SqlCommand com = new SqlCommand(searchString, database.getConnection());

            database.openConnection();

            SqlDataReader read = com.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRow(dgw, read);
            }

            read.Close();
        }

        private void deleteRow()
        {
            int index;
            if (dataGridView1.CurrentCell.RowIndex != null) 
                index = dataGridView1.CurrentCell.RowIndex;
            else 
                index = dataGridView1.RowCount; 

            dataGridView1.Rows[index].Visible = false;

            if (dataGridView1.Rows[index].Cells[0].Value == string.Empty)
            {
                dataGridView1.Rows[index].Cells[9].Value = RowState.Deleted;
                return;
            }

            dataGridView1.Rows[index].Cells[9].Value = RowState.Deleted;
        }

        private void Update()
        {
            database.openConnection();

            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[9].Value;

                if (rowState == RowState.Existed)
                {
                    continue;
                }
                    

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[8].Value);
                    var deleteQuery = $"delete from Products where id = {id} ";

                    var command = new SqlCommand(deleteQuery, database.getConnection());
                    command.ExecuteNonQuery();

                }

                if (rowState == RowState.Modified)
                {
                    var name = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var country = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var model = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var countColors = dataGridView1.Rows[index].Cells[3].Value.ToString();
                    var weight = dataGridView1.Rows[index].Cells[4].Value.ToString();
                    var price = dataGridView1.Rows[index].Cells[5].Value.ToString();
                    var winSup = dataGridView1.Rows[index].Cells[6].Value;
                    var macSup = dataGridView1.Rows[index].Cells[7].Value;
                    var id = dataGridView1.Rows[index].Cells[8].Value;

                    var changeQuery = $"update Products set Name='{name}', Country='{country}', Model='{model}', CountColors='{countColors}', Weight='{weight}', Price='{price}', WinSup='{winSup}', MacSup='{macSup}' where id = '{id}' ";

                    var command = new SqlCommand(changeQuery,database.getConnection());

                    command.ExecuteNonQuery();
                }
            }
            database.closeConnection();
        }

        private void Change()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

            var name = tb_Name.Text;
            var country = tb_Country.Text;
            var model = tb_Model.Text;
            int countColors;
            int weight;
            int price;
            var winSup = checkBox1.Checked;
            var macSup = checkBox2.Checked;

            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != String.Empty)
            {
                if (int.TryParse(tb_CountColors.Text, out countColors) && int.TryParse(tb_Weight.Text, out weight) && int.TryParse(tb_Price.Text, out price))
                {
                    dataGridView1.Rows[selectedRow].SetValues(name, country, model, countColors, weight, price, winSup, macSup);
                    dataGridView1.Rows[selectedRow].Cells[9].Value = RowState.Modified;
                }
                else
                {
                    MessageBox.Show("Перевірте правильність значень", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ClearFields()
        {
            tb_Name.Text = "";
            tb_Country.Text = "";
            tb_Model.Text = "";
            tb_CountColors.Text = "";
            tb_Weight.Text = "";
            tb_Price.Text = "";

            checkBox1.Checked = false;
            checkBox2.Checked = false;

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

            if (add_form.ShowDialog() == DialogResult.OK)
            {
           
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
            ClearFields();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (selectedRow > 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];
                tb_Name.Text = row.Cells[0].Value.ToString();
                tb_Country.Text = row.Cells[1].Value.ToString();
                tb_Model.Text = row.Cells[2].Value.ToString();
                tb_CountColors.Text = row.Cells[3].Value.ToString();
                tb_Weight.Text = row.Cells[4].Value.ToString();
                tb_Price.Text = row.Cells[5].Value.ToString();
                checkBox1.Checked = Boolean.Parse(row.Cells[6].Value.ToString());
                checkBox2.Checked = Boolean.Parse(row.Cells[7].Value.ToString());
            }
            
        }


        private void tstbSearch_Click(object sender, EventArgs e)
        {

        }

        private void tstbSearch_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }

        private void btnSaveAsBinary_Click(object sender, EventArgs e)
        {

        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            deleteRow();
            ClearFields();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Change();
            ClearFields();
        }
    }
}