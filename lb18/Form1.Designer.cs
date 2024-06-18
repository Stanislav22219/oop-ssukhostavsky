namespace lb18
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewProcesses = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProcesses).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewProcesses
            // 
            dataGridViewProcesses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProcesses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProcesses.Location = new Point(10, 9);
            dataGridViewProcesses.Margin = new Padding(3, 2, 3, 2);
            dataGridViewProcesses.Name = "dataGridViewProcesses";
            dataGridViewProcesses.RowHeadersVisible = false;
            dataGridViewProcesses.RowHeadersWidth = 51;
            dataGridViewProcesses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProcesses.Size = new Size(506, 647);
            dataGridViewProcesses.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 667);
            Controls.Add(dataGridViewProcesses);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Процеси";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProcesses).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewProcesses;
    }
}
