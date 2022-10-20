using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CourseWork
{
    public partial class ExportForm : Form
    {
        public List<Ploter> ExportData;
        public ExportForm(List<Ploter> ploters)
        {
            ExportData = ploters;
            InitializeComponent();
        }
        private void dataExport_binary(string fileName)
        {
            using (BinaryWriter binWriter = new BinaryWriter(File.Open(fileName, FileMode.Create)))
            {
                for (int i = 0; i < ExportData.Count; i++)
                {
                    binWriter.Write(ExportData[i].Name.ToString());
                    binWriter.Write(ExportData[i].Country.ToString());
                    binWriter.Write(ExportData[i].Model.ToString());
                    binWriter.Write(ExportData[i].CountColors.ToString());
                    binWriter.Write(ExportData[i].Weight.ToString());
                    binWriter.Write(ExportData[i].Price.ToString());
                    binWriter.Write(ExportData[i].WinSupport.ToString());
                    binWriter.Write(ExportData[i].MacSupport.ToString());
                }
            }
            MessageBox.Show($"Успішно записанор у файл '{fileName}'", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataExport_json(string fileName)
        {
            string json = JsonSerializer.Serialize(ExportData);
            File.WriteAllText($"{fileName}", json);

            MessageBox.Show($"Успішно записанор у файл '{fileName}'", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string fileName = "exported_data";
           if (textBox1.Text != "" && comboBox1.Text != "")
            {
                fileName = textBox1.Text;
            }
           switch (comboBox1.Text)
            {
                case "Двійковий формат":
                    dataExport_binary($"{fileName}.bin");
                    break;
                case "JSON":
                    dataExport_json($"{fileName}.json");
                    break;
            }
        }

        private void ExportForm_Load(object sender, EventArgs e)
        {
            button1.DialogResult = DialogResult.OK;
            AcceptButton = button1;
            button2.DialogResult = DialogResult.Cancel;
            CancelButton = button2;
        }
    }
}
