using System.Data.SqlClient;
using System.Data;

namespace CourseWork
{
    public partial class CompanyForm : Form
    {
       DataBase database = new DataBase();
       string TableDB = "dbo.company";
       int selectedRow;
       public CompanyForm()
        {
            InitializeComponent();
        }
        private void CompanyForm_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }

        private void AddFormOpen()
        {
            PloterForm add_form = new PloterForm();
            add_form.ShowDialog();
        }// FORMS
        private void ExportForm()
        {
        }// FORMS 
        private void ImportForm()
        {
            ImportForm iForm = new ImportForm();
            if (iForm.ShowDialog() == DialogResult.OK)
            {
                iForm.Close();
               
                List<Ploter> importData = importData = iForm.importData;
                addPlotersFromFile(importData, (dataImportState)iForm.dImportState);
            }
        }// FORMS 

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("Name", "Назва");
            dataGridView1.Columns.Add("Country", "Країна");
            dataGridView1.Columns.Add("CountColors", "Опис");
            dataGridView1.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.Columns[2].Width = 300;

            dataGridView1.Columns.Add("id", "ID");
            dataGridView1.Columns.Add("IsNew", String.Empty);
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;

            dataGridView1.RowTemplate.Height = 80;

            EventArgs args = new EventArgs(); OnResize(args);


            dataGridView1.AutoGenerateColumns = false;
        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(
                record.GetString(0),
                record.IsDBNull(1) ? "Пусто" : record.GetString(1),
                record.IsDBNull(2) ? "Пусто" : record.GetString(2),
                record.GetInt32(3),
                RowState.ModifiedNew
                );
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select * from {TableDB}";

            SqlCommand command = new SqlCommand(queryString, database.getConnection());
            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
            database.closeConnection();
        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchString = $"select * from {TableDB} where concat (Name, Country, Description) like '%" + tstbSearch.Text + "%'";

            SqlCommand com = new SqlCommand(searchString, database.getConnection());

            database.openConnection();

            SqlDataReader read = com.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRow(dgw, read);
            }

            read.Close();
        }// SEARCH IN DataGridView
        private void tstbSearch_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }// SEARCH IN DataGridView

        private void deleteRow()
        {
            try
            {
                int index = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows[index].Visible = false;

                if (dataGridView1.Rows[index].Cells[0].Value == string.Empty)
                {
                    dataGridView1.Rows[index].Cells[4].Value = RowState.Deleted;
                    return;
                }

                dataGridView1.Rows[index].Cells[4].Value = RowState.Deleted;
            }
            catch (NullReferenceException e)
            {
                MessageBox.Show("Ви не вибрали жодного рядка", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }//DELETE ONE Row

        private void deleteAll()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Visible = false;
                dataGridView1.Rows[i].Cells[4].Value = RowState.Deleted;
            }
            Update();
        }// DELETE ALL ROWS

        private void Update()
        {
            database.openConnection();

            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[4].Value;

                if (rowState == RowState.Existed)
                {
                    continue;
                }

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[3].Value);
                    var deleteQuery = $"delete from {TableDB} where id = {id} ";

                    var command = new SqlCommand(deleteQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified)
                {
                    var name = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var country = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var description = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var id = dataGridView1.Rows[index].Cells[3].Value;

                    var changeQuery = $"update {TableDB} set Name='{name}', Country='{country}', Description='{description}', where id = '{id}' ";
                    var command = new SqlCommand(changeQuery,database.getConnection());
                    command.ExecuteNonQuery();
                }
            }
            database.closeConnection();
        }//UPDATE Rows by RowState

        private void Change()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

            var name = tb_Name.Text;
            var country = tb_Company.Text;
            var description = tb_Description.Text;

            dataGridView1.Rows[selectedRow].SetValues(name, country, description);
            dataGridView1.Rows[selectedRow].Cells[4].Value = RowState.Modified;

        }// EDIT Rows 

        private void ClearFields()
        {
            tb_Name.Text = "";
            tb_Company.Text = "";
            tb_Description.Text = "";
        }// Clear Edit textBox 

        private void addPlotersFromFile(List<Ploter> importData, dataImportState dataState)
        {
            switch (dataState)
            {
                case dataImportState.rewrite:
                    deleteAll();
                    goto case dataImportState.addAsNew;
                   break;
                case dataImportState.addAsNew:
                    database.openConnection();
                    foreach (var ploter in importData)
                    {
                        string name = ploter.Name;
                        string company = ploter.Company;
                        string model = ploter.Model;
                        int countColors = ploter.CountColors;
                        int weight = ploter.Weight;
                        int price = ploter.Price;
                        bool winSup = ploter.WinSupport;
                        bool macSup = ploter.MacSupport;

                        var addQuery = $"insert into {TableDB} (Name, Company, Model, CountColors, Weight, Price, WinSup, MacSup) values ('{name}', '{company}', '{model}', '{countColors}', '{weight}', '{price}', '{winSup}', '{macSup}')";
                        var command = new SqlCommand(addQuery, database.getConnection());
                        command.ExecuteNonQuery();

                        Ploter p = new Ploter(name, company, model, countColors, weight, price, winSup, macSup);
                    }
                    database.closeConnection();
                    RefreshDataGrid(dataGridView1);
                    ClearFields();

                    MessageBox.Show("Добавили", "Успішно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }// IMPORT Rows FROM File

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (selectedRow >= 0)
            {

                DataGridViewRow row = dataGridView1.Rows[selectedRow];
                tb_Name.Text = row.Cells[0].Value.ToString();
                tb_Company.Text = row.Cells[1].Value.ToString();
                tb_Description.Text = row.Cells[2].Value.ToString();
            }
        }

        private void exitApp()
        {
            Application.Exit();
        }// EXIT FUNC

        // BUTTONS 
        private void btnSave_Click(object sender, EventArgs e)
        {
            Update();
        }// SAVING BUTTON 

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddFormOpen();
        }// ADD BUTTON

        private void btnDel_Click(object sender, EventArgs e)
        {
            deleteRow();
            ClearFields();
        }// DELETE BUTTON

        private void btnClear_Click(object sender, EventArgs e)
        {
            deleteAll();
        }// CLEAR BUTTON

        private void btnReload_Click_1(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
            ClearFields();
        }// RELOAD BUTTON

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Change();
            ClearFields();
        }// EDIT BUTTON

        private void btnExit_Click(object sender, EventArgs e)
        {
            exitApp();
        }// EXIT BUTTON


        private void btnSaveAsText_Click(object sender, EventArgs e)
        {
            ExportForm();
        }// EXPORT BUTTON

        private void btnOpenFromText_Click(object sender, EventArgs e)
        {
            ImportForm();
        }// IMPORT BUTTON

        private void miAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Застосунок демонструє виконання курсової роботи\n" +
                            "з курсу 'Об'єктно-орієнтоване програмування'\n\n" + "Розробив: [КАЛАНЧА Р.Р.]",
                            "Про програму", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }// ABOUT BUTTON

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var startForm = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is StartForm);
            startForm.Show();
        }
    }
}