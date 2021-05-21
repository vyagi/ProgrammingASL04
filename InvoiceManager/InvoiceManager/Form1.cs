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
    }
}
