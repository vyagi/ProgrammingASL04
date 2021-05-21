
namespace InvoiceManager
{
    partial class InvoiceManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openButton = new System.Windows.Forms.Button();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.pathLabel = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.totalPaidButton = new System.Windows.Forms.Button();
            this.groupByMonth = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(12, 32);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 23);
            this.openButton.TabIndex = 0;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(53, 6);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(544, 20);
            this.pathTextBox.TabIndex = 1;
            this.pathTextBox.Text = "C:\\Users\\Marcin\\OneDrive\\Invoices.txt";
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(12, 9);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(32, 13);
            this.pathLabel.TabIndex = 2;
            this.pathLabel.Text = "Path:";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(12, 61);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(585, 377);
            this.resultTextBox.TabIndex = 3;
            // 
            // totalPaidButton
            // 
            this.totalPaidButton.Location = new System.Drawing.Point(94, 33);
            this.totalPaidButton.Name = "totalPaidButton";
            this.totalPaidButton.Size = new System.Drawing.Size(100, 23);
            this.totalPaidButton.TabIndex = 4;
            this.totalPaidButton.Text = "Group by person";
            this.totalPaidButton.UseVisualStyleBackColor = true;
            this.totalPaidButton.Click += new System.EventHandler(this.totalPaidButton_Click);
            // 
            // groupByMonth
            // 
            this.groupByMonth.Location = new System.Drawing.Point(201, 33);
            this.groupByMonth.Name = "groupByMonth";
            this.groupByMonth.Size = new System.Drawing.Size(95, 23);
            this.groupByMonth.TabIndex = 5;
            this.groupByMonth.Text = "Group by month";
            this.groupByMonth.UseVisualStyleBackColor = true;
            this.groupByMonth.Click += new System.EventHandler(this.groupByMonth_Click);
            // 
            // InvoiceManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 450);
            this.Controls.Add(this.groupByMonth);
            this.Controls.Add(this.totalPaidButton);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.openButton);
            this.Name = "InvoiceManager";
            this.Text = "Invoice Manager 2021";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Button totalPaidButton;
        private System.Windows.Forms.Button groupByMonth;
    }
}

