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

namespace InvoiceManager
{
    public partial class InvoiceManager : Form
    {
        public InvoiceManager()
        {
            InitializeComponent();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            var path = pathTextBox.Text;
            if (!File.Exists(path))
            {
                MessageBox.Show("The file does not exist. Cannot continue");
                return;
            }

            resultTextBox.Lines = File.ReadAllLines(path);
        }

        private void totalPaidButton_Click(object sender, EventArgs e)
        {
            var path = pathTextBox.Text;
            if (!File.Exists(path))
            {
                MessageBox.Show("The file does not exist. Cannot continue");
                return;
            }

            var lines = File.ReadAllLines(path);

            var summary = new Dictionary<string, decimal>();

            for (int i = 1; i < lines.Length; i++)
            {
                var line = lines[i];
                var split = line.Split('\t');

                var name = split[0];
                var amount = Convert.ToDecimal(split[2]);

                if (summary.ContainsKey(name))
                {
                    summary[name] += amount;
                }
                else
                {
                    summary[name] = amount;
                }

                resultTextBox.Text = $"Name\tAmount{Environment.NewLine}";

                foreach (var entry in summary)
                {
                    resultTextBox.Text += $"{entry.Key}\t{entry.Value}{Environment.NewLine}";
                }
            }
        }
    }
}
