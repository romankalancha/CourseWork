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

namespace CourseWork
{
    public partial class PloterForm : Form
    {
        public Ploter ThePloter;
        public PloterForm(Ploter p)
        {
            ThePloter = p;

            InitializeComponent();
        }
        public PloterForm()
        {
            InitializeComponent();
        }
        void error_message(string text_message)
        {
            MessageBox.Show(text_message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void button1_Click(object sender, EventArgs e)
        {

            /*ThePloter.Name = textBox1.Text.Trim();
            ThePloter.Country = textBox2.Text.Trim();
            ThePloter.Model = textBox3.Text.Trim();

            int countColors;
            if (int.TryParse(textBox4.Text.Trim(), out countColors))
            {
                ThePloter.CountColors = countColors;
            }
            else
            {
                error_message("Неправильно введене число!");
                textBox4.Focus(); return;
            }

            int w;
            if (int.TryParse(textBox5.Text.Trim(), out w))
            {
                ThePloter.Weight = w;
            }
            else
            {
                error_message("Неправильно введене число!");
                textBox5.Focus(); return;
            }
            double pr;
            if (double.TryParse(textBox6.Text.Trim(), out pr))
            {
                ThePloter.Price = pr;
            }
            else
            {
                error_message("Неправильно введене число!");
                textBox6.Focus(); return;
            }
            ThePloter.WinSupport = checkBox1.ThreeState;
            ThePloter.MacSupport = checkBox2.ThreeState;*/
            button1.DialogResult = DialogResult.OK;
            AcceptButton = button1;
            button2.DialogResult = DialogResult.Cancel;
            CancelButton = button2;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PloterForm_Load(object sender, EventArgs e)
        {
            if (ThePloter != null)
            {
                textBox1.Text = ThePloter.Name;
                textBox2.Text = ThePloter.Country;
                textBox3.Text = ThePloter.Model;
                textBox4.Text = ThePloter.CountColors.ToString("0");
                textBox5.Text = ThePloter.Weight.ToString("0");
                textBox6.Text = ThePloter.Price.ToString("0.00");
                checkBox1.Checked = ThePloter.WinSupport;
                checkBox2.Checked = ThePloter.MacSupport;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
