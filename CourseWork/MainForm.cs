using System.Data.SqlClient;
using System.Data;

namespace CourseWork
{
    enum dataImportState
    {
        addAsNew,
        rewrite
    }
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
       string TableDB = "dbo.ploter";
       List<Ploter> ploters = new List<Ploter>();
       int selectedRow;
       public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);

            generealInfoObj();
        }

        private void AddFormOpen()
        {
            PloterForm add_form = new PloterForm();
            add_form.ShowDialog();
        }// FORMS
        private void ExportForm()
        {
            ExportForm eForm = new ExportForm(ploters);
            if (eForm.ShowDialog() == DialogResult.OK)
            {
                eForm.Close();
            }
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
        private void miFilter_Click(object sender, EventArgs e)
        {
            FiltherForm fForm = new FiltherForm();
            if (fForm.ShowDialog() == DialogResult.OK)
            {
                int max = fForm.AreaMax;
                int min = fForm.AreaMin;

                Filther(dataGridView1, min, max);
            }
        }// FILTHER FORM

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("Name", "Назва");
            dataGridView1.Columns.Add("Company", "Компанія");
            dataGridView1.Columns.Add("Model", "Модель");
            dataGridView1.Columns.Add("CountColors", "К-сть Кольорів");
            dataGridView1.Columns[3].Width = 60;
            dataGridView1.Columns.Add("Weight", "Вага (kg.)");
            dataGridView1.Columns[4].Width = 50;
            dataGridView1.Columns.Add("Price", "Ціна (₴)");

            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "WinSupport";
            column.HeaderText = "Підтримка Windows";
            column.Width = 75; dataGridView1.Columns.Add(column);

            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "MacSupport";
            column.HeaderText = "Підтримка Mac";
            column.Width = 75; dataGridView1.Columns.Add(column);

            dataGridView1.Columns.Add("id", "ID");
            dataGridView1.Columns.Add("IsNew", String.Empty);
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;

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
                record.GetInt32(4) + " Кг.", 
                string.Format("{0:### ### ###}", record.GetInt32(5)) + " ₴", 
                record.GetBoolean(6), 
                record.GetBoolean(7),
                record.GetInt32(8),
                RowState.ModifiedNew
                );
            Ploter p = new Ploter(
                record.GetString(0),
                record.GetString(1),
                record.GetString(2),
                record.GetInt32(3),
                record.GetInt32(4),
                record.GetInt32(5),
                record.GetBoolean(6),
                record.GetBoolean(7)
                );
            ploters.Add(p);

        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            ploters.Clear();

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

            string searchString = $"select * from {TableDB} where concat (Name, Company, Model, CountColors, Weight, Price, WinSup, MacSup) like '%" + tstbSearch.Text + "%'";

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

        private void Filther(DataGridView dgw, int Min, int Max)
        {
            dgw.Rows.Clear();

            string searchString = $"select * from {TableDB} where Price between {Min} and {Max}";

            SqlCommand com = new SqlCommand(searchString, database.getConnection());

            database.openConnection();

            SqlDataReader read = com.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRow(dgw, read);
            }

            read.Close();
        }// FILTHER Price

        private void deleteRow()
        {
            try
            {
                int index = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows[index].Visible = false;

                if (dataGridView1.Rows[index].Cells[0].Value == string.Empty)
                {
                    dataGridView1.Rows[index].Cells[9].Value = RowState.Deleted;
                    return;
                }

                dataGridView1.Rows[index].Cells[9].Value = RowState.Deleted;
                generealInfoObj();
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
                dataGridView1.Rows[i].Cells[9].Value = RowState.Deleted;
            }
            Update();
        }// DELETE ALL ROWS

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
                    var deleteQuery = $"delete from {TableDB} where id = {id} ";

                    var command = new SqlCommand(deleteQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified)
                {
                    var name = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var company = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var model = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var countColors = dataGridView1.Rows[index].Cells[3].Value.ToString();
                    var weight = dataGridView1.Rows[index].Cells[4].Value.ToString().Replace(" Кг.", "");
                    var price = dataGridView1.Rows[index].Cells[5].Value.ToString().Replace(" ", "").Replace("₴", "");
                    var winSup = dataGridView1.Rows[index].Cells[6].Value;
                    var macSup = dataGridView1.Rows[index].Cells[7].Value;
                    var id = dataGridView1.Rows[index].Cells[8].Value;

                    var changeQuery = $"update {TableDB} set Name='{name}', Company='{company}', Model='{model}', " +
                                      $"CountColors='{countColors}', Weight='{weight}', Price='{price}', WinSup='{winSup}', MacSup='{macSup}' where id = '{id}' ";
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
            var company = tb_Company.Text;
            var model = tb_Model.Text;
            int countColors;
            int weight;
            int price;
            var winSup = checkBox1.Checked;
            var macSup = checkBox2.Checked;

            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != String.Empty)
            {
                if (int.TryParse(tb_CountColors.Text, out countColors) && int.TryParse(tb_Weight.Text.Replace(" Кг.", ""), out weight) && int.TryParse(tb_Price.Text.Replace(" ", "").Replace("₴", ""), out price))
                {
                    dataGridView1.Rows[selectedRow].SetValues(name, company, model, countColors, weight + " Кг.", string.Format("{0:### ### ###}", price) + " ₴", winSup, macSup);
                    dataGridView1.Rows[selectedRow].Cells[9].Value = RowState.Modified;
                }
                else
                {
                    MessageBox.Show("Перевірте правильність значень", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }// EDIT Rows 

        private void ClearFields()
        {
            tb_Name.Text = "";
            tb_Company.Text = "";
            tb_Model.Text = "";
            tb_CountColors.Text = "";
            tb_Weight.Text = "";
            tb_Price.Text = "";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
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

        private void generealInfoObj()
        {
            if (ploters.Count > 0 )
            {
                toolStripStatusLabel1.Text = ploters[0].GeneralInfo();
                toolStripStatusLabel2.Text = ploters[0].PricePerYear();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (selectedRow >= 0)
            {

                DataGridViewRow row = dataGridView1.Rows[selectedRow];
                tb_Name.Text = row.Cells[0].Value.ToString();
                tb_Company.Text = row.Cells[1].Value.ToString();
                tb_Model.Text = row.Cells[2].Value.ToString();
                tb_CountColors.Text = row.Cells[3].Value.ToString();
                tb_Weight.Text = row.Cells[4].Value.ToString();
                tb_Price.Text = row.Cells[5].Value.ToString();
                checkBox1.Checked = Boolean.Parse(row.Cells[6].Value.ToString());
                checkBox2.Checked = Boolean.Parse(row.Cells[7].Value.ToString());

                toolStripStatusLabel1.Text = ploters[selectedRow].GeneralInfo();
                toolStripStatusLabel2.Text = ploters[selectedRow].PricePerYear();
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