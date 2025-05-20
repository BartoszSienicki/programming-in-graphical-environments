using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace towarw
{
    public partial class Form1 : Form
    {
        private string filePath;

        public Form1()
        {
            InitializeComponent();
            CountUD.ValueChanged += new EventHandler(Count_ValueChanged);
            PricePU.ValueChanged += new EventHandler(Price_ValueChanged);
        }

        private void Count_ValueChanged(object sender, EventArgs e)
        {
            float count = (float)CountUD.Value;
            float pricePerUnit = (float)PricePU.Value;
            tbAmount.Text = (count * pricePerUnit).ToString("0.00") + " zł";
        }

        private void Price_ValueChanged(object sender, EventArgs e)
        {
            float count = (float)CountUD.Value;
            float pricePerUnit = (float)PricePU.Value;
            tbAmount.Text = (count * pricePerUnit).ToString("0.00") + " zł";
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void pomocToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void BPay_Click(object sender, EventArgs e)
        {
            if (Paid.Checked)
            {
                Paid.Checked = false;
            }
            else
            {
                Paid.Checked = true;
            }
        }

        private void BSent_Click(object sender, EventArgs e)
        {
            if (Sent.Checked)
            {
                Sent.Checked = false;
                Date.Visible = false;
            }
            else
            {
                Sent.Checked = true;
                Date.Value = DateTime.Now;
                Date.Visible = true;
            }
        }

        private void BDelivered_Click(object sender, EventArgs e)
        {
            if (Delivered.Checked)
            {
                Delivered.Checked = false;
            }
            else
            {
                Delivered.Checked = true;

            }
        }

        private void nowyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Czy na pewno chcesz usunąć wszystkie dane?",
                              "Potwierdzenie",
                              MessageBoxButtons.YesNo,
                              MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                textBox1.Text = "";
                Paid.Checked = false;
                Date.Visible = false;
                Sent.Checked = false;
                Delivered.Checked = false;
                CountUD.Value = 0;
                PricePU.Value = 0;
                Prod.SelectedIndex = -1;
                Desc.Clear();
            }
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Pliki CSV (*.csv)|*.csv|Wszystkie pliki (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Otworzono plik: " + openFileDialog.FileName);
                LoadFromCsv(openFileDialog.FileName);
            }
        }

        private void LoadFromCsv(string fileName)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                if (lines.Length > 0)
                {
                    string[] values = lines[0].Split(';');
                    textBox1.Text = values[0];
                    CountUD.Value = decimal.Parse(values[1]);
                    PricePU.Value = decimal.Parse(values[2]);
                    Prod.SelectedItem = values[4];
                    Paid.Checked = bool.Parse(values[5]);
                    Sent.Checked = bool.Parse(values[6]);
                    Date.Value = DateTime.Parse(values[7]);
                    Delivered.Checked = bool.Parse(values[8]);
                    Desc.Text = values[9].Replace("\n", Environment.NewLine);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas wczytywania pliku CSV: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SaveToCsv()
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine($"{Prod.Text};{CountUD.Text};{PricePU.Text};{tbAmount.Text};" +
                            $"{Prod.SelectedItem};{Paid.Checked};{Sent.Checked};" +
                            $"{Date.Value.ToShortDateString()};{Delivered.Checked};{Desc.Text}");
                        File.WriteAllText(saveFileDialog.FileName, sb.ToString());
                        MessageBox.Show("Dane zapisane");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Zly zapis: " + ex.Message);
            }
        }

        private void toolStripButtonSAVE_Click(object sender, EventArgs e)
        {
            SaveToCsv();
        }

        private void zapiszToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveToCsv();
        }

        private void zapiszjakoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveToCsv();
        }

        private void toolStripButtonLOAD_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Pliki CSV (*.csv)|*.csv|Wszystkie pliki (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Otworzono plik: " + openFileDialog.FileName);
                LoadFromCsv(openFileDialog.FileName);
            }
        }
    }
}
