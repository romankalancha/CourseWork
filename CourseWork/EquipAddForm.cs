using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace CourseWork
{
    public partial class EquipAddForm : Form
    {
        DataBase database = new DataBase();
        public EquipAddForm()
        {
            InitializeComponent();
        }
        private void PloterForm_Load(object sender, EventArgs e)
        {
            btnOk.DialogResult = DialogResult.OK;
            AcceptButton = btnOk;
            btnCancel.DialogResult = DialogResult.Cancel;
            CancelButton = btnCancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            database.openConnection();

            var name = tbName.Text;
            var producer = tbProducer.Text;
            int price, width;
            if (int.TryParse(tbPrice.Text, out price) && int.TryParse(tb_width.Text, out width))
            {
                var addQuery = $"insert into equip (name, price, producer, keybord_width) values ('{name}', '{price}', '{producer}', '{width}')";

                var command = new SqlCommand(addQuery, database.getConnection());
                command.ExecuteNonQuery();

                Equip p = new Equip(name,price,producer);
                MessageBox.Show("Записали", "Успішно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Перевірте правильність значень", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            database.closeConnection();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
