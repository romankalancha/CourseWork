using System.Data.SqlClient;

namespace CourseWork
{
    public partial class PloterForm : Form
    {
        DataBase database = new DataBase();
        string TableDB = "dbo.ploter";
        
        string TableDB_2 = "dbo.Сompanies";
        string TableDB_3 = "dbo.Models";
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
                string addQuery =
                    $"INSERT INTO {TableDB} (Name, Company, Model, CountColors, Weight, Price, WinSup, MacSup)" +
                    $" VALUES ('{name}', '{company}', '{model}', '{countColors}', '{weight}', '{price}', '{winSup}', '{macSup}')";
                SqlCommand command = new SqlCommand(addQuery, database.getConnection());
                command.ExecuteNonQuery();

                string queryString = "SELECT IDENT_CURRENT('dbo.ploter')";
                command = new SqlCommand(queryString, database.getConnection());
                int id_ploter = command.ExecuteScalar().GetHashCode();
                command.ExecuteNonQuery();

                addQuery = $"INSERT INTO dbo.company (Name, fk_id_company) VALUES ('{company}', '{id_ploter}')" +
                           $"INSERT INTO dbo.ploterModel (Name, fk_id_model) VALUES ('{model}', '{id_ploter}')";
                command = new SqlCommand(addQuery, database.getConnection());
                command.ExecuteNonQuery();
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
