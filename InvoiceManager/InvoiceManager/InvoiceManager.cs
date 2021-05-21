using System;
using System.Collections.Generic;
using System.IO;
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
                var invoice = new Invoice(lines[i]);

                if (summary.ContainsKey(invoice.Name))
                {
                    summary[invoice.Name] += invoice.Amount;
                }
                else
                {
                    summary[invoice.Name] = invoice.Amount;
                }
            }

            resultTextBox.Text = $"Name\tAmount{Environment.NewLine}";

            foreach (var entry in summary)
            {
                resultTextBox.Text += $"{entry.Key}\t{entry.Value}{Environment.NewLine}";
            }
        }

        private void groupByMonth_Click(object sender, EventArgs e)
        {
            var path = pathTextBox.Text;
            if (!File.Exists(path))
            {
                MessageBox.Show("The file does not exist. Cannot continue");
                return;
            }

            var lines = File.ReadAllLines(path);

            var summary = ParseLines(lines);

            DisplayResults(summary);
        }

        private Dictionary<int, decimal> ParseLines(string[] lines)
        {
            var summary = new Dictionary<int, decimal>();

            for (var i = 1; i < lines.Length; i++)
            {
                var invoice = new Invoice(lines[i]);

                if (summary.ContainsKey(invoice.Date.Month))
                    summary[invoice.Date.Month] += invoice.Amount;
                else
                    summary[invoice.Date.Month] = invoice.Amount;
            }

            return summary;
        }

        private void DisplayResults(Dictionary<int, decimal> summary)
        {
            resultTextBox.Text = $"Month\tAmount{Environment.NewLine}";

            for (var month = 1; month <= DateTime.Today.Month; month++)
            {
                if (summary.ContainsKey(month))
                    resultTextBox.Text += FormatLine(month, summary[month]);
                else
                    resultTextBox.Text += FormatLine(month, 0);
            }
        }

        private string FormatLine(int month, decimal value) => $"{PadWithZero(month)}\t{value}{Environment.NewLine}";

        private string PadWithZero(int month) => month.ToString().PadLeft(2, '0');
    }
}
