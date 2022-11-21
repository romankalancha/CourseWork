using System.Data.SqlClient;
using System.Data;
using CourseWork.Classes;

namespace CourseWork
{
    public partial class ModelForm : Form
    {
       DataBase database = new DataBase();
       string TableDB_ploterModel = "dbo.ploterModel";
       string TableDB = "dbo.ploter";
       int selectedRow;
       public ModelForm()
        {
            InitializeComponent();
        }
        private void ModelForm_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("Name", "Назва");
            dataGridView1.Columns.Add("Description", "Опис");
            dataGridView1.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.Columns[1].Width = 300;

            dataGridView1.Columns.Add("id", "ID");
            dataGridView1.Columns.Add("IsNew", String.Empty);
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;

            dataGridView1.RowTemplate.Height = 80;

            EventArgs args = new EventArgs(); OnResize(args);


            dataGridView1.AutoGenerateColumns = false;
        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(
                record.GetString(0),
                record.IsDBNull(1) ? "" : record.GetString(1),
                record.GetInt32(3),
                RowState.ModifiedNew
                );
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"SELECT * FROM {TableDB_ploterModel}";

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
            string searchString = $"SELECT * FROM {TableDB} WHERE CONCAT (Name, Description) LIKE '%" + tstbSearch.Text + "%'";
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

        private void Update()
        {
            database.openConnection();

            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[3].Value;

                if (rowState == RowState.Modified)
                {
                    var name = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var description = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var id = dataGridView1.Rows[index].Cells[2].Value;

                    var changeQuery = $"UPDATE {TableDB_ploterModel} SET Name='{name}', Description='{description}' WHERE fk_id_model = '{id}' " +
                                            $"UPDATE {TableDB} SET Model='{name}' WHERE id = '{id}'";
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
            var description = tb_Description.Text;

            dataGridView1.Rows[selectedRow].SetValues(name, description);
            dataGridView1.Rows[selectedRow].Cells[3].Value = RowState.Modified;

        }// EDIT Rows 

        private void ClearFields()
        {
            tb_Name.Text = "";
            tb_Description.Text = "";
        }// Clear Edit textBox 

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (selectedRow >= 0)
            {

                DataGridViewRow row = dataGridView1.Rows[selectedRow];
                tb_Name.Text = row.Cells[0].Value.ToString();
                tb_Description.Text = row.Cells[1].Value.ToString();
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