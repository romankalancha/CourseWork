using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace CourseWork
{
    public partial class ImportForm : Form
    {
        public List<Ploter> importData;
        public enum dataImportState
        {
            addAsNew,
            Rewrite
        }
        public dataImportState dImportState;
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
                    filePath = openFileDialog.FileName;

                    string fileExt = Path.GetExtension(openFileDialog.FileName);
                    if (fileExt == ".json")
                    {
                        var fileStream = openFileDialog.OpenFile();
                        using (StreamReader reader = new StreamReader(fileStream))
                        {
                            fileContent = reader.ReadToEnd();

                            importData = JsonConvert.DeserializeObject<List<Ploter>>(fileContent);
                        }
                        fileNameLabel.Text = Path.GetFileName(filePath);

                    }
                    else if(fileExt == ".bin")
                    {
                        importData = new List<Ploter>();
                        try
                        {
                            using (BinaryReader binReader = new BinaryReader(File.Open(filePath, FileMode.Open)))
                            {
                                Ploter ploter;
                                while(binReader.BaseStream.Position < binReader.BaseStream.Length)
                                {
                                    ploter = new Ploter();
                                    for (int i = 1; i <= 8; i++)
                                    {
                                        switch (i)
                                        {
                                            case 1:
                                                ploter.Name = binReader.ReadString();
                                                break;
                                            case 2:
                                                ploter.Company = binReader.ReadString();
                                                break;
                                            case 3:
                                                ploter.Model = binReader.ReadString();
                                                break;
                                            case 4:
                                                ploter.CountColors = binReader.ReadInt32();
                                                break;
                                            case 5:
                                                ploter.Weight = binReader.ReadInt32();
                                                break;
                                            case 6:
                                                ploter.Price = binReader.ReadInt32();
                                                break;
                                            case 7:
                                                ploter.WinSupport = binReader.ReadBoolean();
                                                break;
                                            case 8:
                                                ploter.MacSupport = binReader.ReadBoolean();
                                                break;
                                        }
                                    }
                                    importData.Add(ploter);
                                }
                            }
                            fileNameLabel.Text = Path.GetFileName(filePath);
                        }
                        catch (SerializationException e)
                        {
                            MessageBox.Show($"Помилка читання файлу'{filePath}'", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    
                    
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fileDialogOpen();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dImportState = dataImportState.addAsNew;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dImportState = dataImportState.Rewrite;
        }

        private void ImportForm_Load(object sender, EventArgs e)
        {
            btnOk.DialogResult = DialogResult.OK;
            AcceptButton = btnOk;
        }
    }
}
