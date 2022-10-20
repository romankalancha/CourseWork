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
    public partial class PloterForm : Form
    {
        DataBase database = new DataBase();
        public PloterForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            database.openConnection();

            var name = textBox1.Text;
            var country = textBox2.Text;
            var model = textBox3.Text;

            var winSup = checkBox1.Checked;
            var macSup = checkBox2.Checked;

            int countColors;
            int weight;
            int price;
            if (int.TryParse(textBox4.Text, out countColors) && int.TryParse(textBox5.Text, out weight) && int.TryParse(textBox6.Text, out price))
            {
                var addQuery = $"insert into Products (Name, Country, Model, CountColors, Weight, Price, WinSup, MacSup) values ('{name}', '{country}', '{model}', '{countColors}', '{weight}', '{price}', '{winSup}', '{macSup}')";

                var command = new SqlCommand(addQuery, database.getConnection());
                command.ExecuteNonQuery();

                Ploter p = new Ploter(name, country, model, countColors, weight, price, winSup, macSup);
                MessageBox.Show("Записали", "Успішно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Перевірте правильність значень", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            database.closeConnection();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PloterForm_Load(object sender, EventArgs e)
        {
            button1.DialogResult = DialogResult.OK;
            AcceptButton = button1;
            button2.DialogResult = DialogResult.Cancel;
            CancelButton = button2;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
