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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Collections.Generic;

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
       List<Equip> Equips = new List<Equip>();
       List<Keyboard> keyboards = new List<Keyboard>();
       int selectedRow;
       public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }

        private void AddFormOpen()
        {
            EquipAddForm add_form = new EquipAddForm();
            add_form.ShowDialog();
        }// FORMS

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("Id", "id");
            dataGridView1.Columns.Add("Name", "Назва");
            dataGridView1.Columns.Add("Price", "Ціна");
            dataGridView1.Columns.Add("Producer", "Виробник");
            dataGridView1.Columns.Add("Width", "Ширина");
            dataGridView1.Columns.Add("IsNew", String.Empty);

            EventArgs args = new EventArgs(); OnResize(args);
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[5].Visible = false;

            dataGridView1.AutoGenerateColumns = false;
        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(
                record.GetInt32(0),
                record.GetString(1),
                record.GetInt32(2),
                record.GetString(3),
                record.GetInt32(4),
                RowState.ModifiedNew
                );
            Equip e = new Equip(
                record.GetString(1), 
                record.GetInt32(2), 
                record.GetString(3));
            Equips.Add(e);

            Keyboard k = new Keyboard(record.GetInt32(4));
            keyboards.Add(k);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            Equips.Clear();
            keyboards.Clear();

            string queryString = "select * from equip";

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

            string searchString = "select * from equip where concat (name, price, producer) like '%" + tstbSearch.Text + "%'";

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
                    dataGridView1.Rows[index].Cells[5].Value = RowState.Deleted;
                    return;
                }

                dataGridView1.Rows[index].Cells[5].Value = RowState.Deleted;
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
                dataGridView1.Rows[i].Cells[5].Value = RowState.Deleted;
            }
            Update();
        }// DELETE ALL ROWS

        private void Update()
        {
            database.openConnection();

            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[5].Value;

                if (rowState == RowState.Existed)
                {
                    continue;
                }
                
                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from equip where id = {id} ";

                    var command = new SqlCommand(deleteQuery, database.getConnection());
                    command.ExecuteNonQuery();

                }

                if (rowState == RowState.Modified)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value;
                    var name = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var price = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var producer = dataGridView1.Rows[index].Cells[3].Value.ToString();
                    var keybord_width = dataGridView1.Rows[index].Cells[4].Value.ToString();
                    

                    var changeQuery = $"update equip set name='{name}', price='{price}', producer='{producer}', keybord_width='{keybord_width}' where id = '{id}' ";

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
            var producer = tb_Producer.Text;
            var width = tbWidth.Text;
            int price;
            //var producer;

            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != String.Empty)
            {
                if (int.TryParse(tb_Price.Text, out price))
                {
                    dataGridView1.Rows[selectedRow].SetValues(dataGridView1.Rows[selectedRowIndex].Cells[0].Value, name, price, producer, width);
                    dataGridView1.Rows[selectedRow].Cells[5].Value = RowState.Modified;
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
            tb_Producer.Text = "";
            tb_Price.Text = "";
            tbWidth.Text = "";

        }// Clear Edit textBox 

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (selectedRow >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];
                tb_Name.Text = row.Cells[1].Value.ToString();
                tb_Price.Text = row.Cells[2].Value.ToString();
                tb_Producer.Text = row.Cells[3].Value.ToString();
                tbWidth.Text = row.Cells[4].Value.ToString();
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

        private void miAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Застосунок демонструє виконання курсової роботи\n" +
                            "з курсу 'Об'єктно-орієнтоване програмування'\n\n" + "Розробив: [КАЛАНЧА Р.Р.]",
                            "Про програму", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }// ABOUT BUTTON

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}