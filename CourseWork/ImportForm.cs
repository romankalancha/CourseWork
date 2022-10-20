using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class ImportForm : Form
    {
        public List<Ploter> importData = new List<Ploter>();
        List<Ploter> ploters = new List<Ploter>();

        public ImportForm()
        {
            InitializeComponent();
        }

        private void fileDialogOpen()
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\Users\\ta4we\\source\\repos\\CourseWork\\CourseWork\\bin\\Debug\\net6.0-windows";
                openFileDialog.Filter = "Json Files (*.json)|*.json|Binary Files (*.bin)|*.bin";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();

                        List<Ploter> ploters = JsonConvert.DeserializeObject<List<Ploter>>(fileContent);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fileDialogOpen();
        }
    }
}
