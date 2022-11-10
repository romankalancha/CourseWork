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
        string TableDB = "Products";
        public PloterForm()
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
            var company = tbCompany.Text;
            var model = tbModel.Text;

            var winSup = cbWin.Checked;
            var macSup = cbMac.Checked;

            int countColors;
            int weight;
            int price;
            if (int.TryParse(tbCColors.Text, out countColors) && int.TryParse(tbWeight.Text, out weight) && int.TryParse(tbPrice.Text, out price))
            {
                var addQuery = $"insert into {TableDB} (Name, Company, Model, CountColors, Weight, Price, WinSup, MacSup) values ('{name}', '{company}', '{model}', '{countColors}', '{weight}', '{price}', '{winSup}', '{macSup}')";

                var command = new SqlCommand(addQuery, database.getConnection());
                command.ExecuteNonQuery();

                Ploter p = new Ploter(name, company, model, countColors, weight, price, winSup, macSup);
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
