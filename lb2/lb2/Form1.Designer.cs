namespace lb2
{
    partial class Form1
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
            this.addButton = new System.Windows.Forms.Button();
            this.vectorTextBox = new System.Windows.Forms.TextBox();
            this.vectorListBox = new System.Windows.Forms.ListBox();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.performOperationButton = new System.Windows.Forms.Button();
            this.operationComboBox = new System.Windows.Forms.ComboBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.Vector2TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(48, 121);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // vectorTextBox
            // 
            this.vectorTextBox.Location = new System.Drawing.Point(48, 67);
            this.vectorTextBox.Name = "vectorTextBox";
            this.vectorTextBox.Size = new System.Drawing.Size(250, 20);
            this.vectorTextBox.TabIndex = 1;
            this.vectorTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.vectorTextBox_KeyPress);
            // 
            // vectorListBox
            // 
            this.vectorListBox.FormattingEnabled = true;
            this.vectorListBox.Location = new System.Drawing.Point(161, 115);
            this.vectorListBox.Name = "vectorListBox";
            this.vectorListBox.Size = new System.Drawing.Size(137, 147);
            this.vectorListBox.TabIndex = 2;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(48, 172);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 3;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(48, 225);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // performOperationButton
            // 
            this.performOperationButton.Location = new System.Drawing.Point(403, 150);
            this.performOperationButton.Name = "performOperationButton";
            this.performOperationButton.Size = new System.Drawing.Size(227, 45);
            this.performOperationButton.TabIndex = 5;
            this.performOperationButton.Text = "Обчислити";
            this.performOperationButton.UseVisualStyleBackColor = true;
            this.performOperationButton.Click += new System.EventHandler(this.performOperationButton_Click);
            // 
            // operationComboBox
            // 
            this.operationComboBox.FormattingEnabled = true;
            this.operationComboBox.Items.AddRange(new object[] {
            "Add",
            "Subtract",
            "Dot Product",
            "Multiply by Scalar",
            "Length"});
            this.operationComboBox.Location = new System.Drawing.Point(525, 99);
            this.operationComboBox.Name = "operationComboBox";
            this.operationComboBox.Size = new System.Drawing.Size(105, 21);
            this.operationComboBox.TabIndex = 6;
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(403, 242);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(227, 20);
            this.resultTextBox.TabIndex = 7;
            // 
            // Vector2TextBox
            // 
            this.Vector2TextBox.Location = new System.Drawing.Point(403, 67);
            this.Vector2TextBox.Name = "Vector2TextBox";
            this.Vector2TextBox.Size = new System.Drawing.Size(227, 20);
            this.Vector2TextBox.TabIndex = 8;
            this.Vector2TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Vector2TextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(398, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Результат:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(398, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Вектор №2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(43, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Введіть вектор:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(398, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Операція:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 341);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Vector2TextBox);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.operationComboBox);
            this.Controls.Add(this.performOperationButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.vectorListBox);
            this.Controls.Add(this.vectorTextBox);
            this.Controls.Add(this.addButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox vectorTextBox;
        private System.Windows.Forms.ListBox vectorListBox;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button performOperationButton;
        private System.Windows.Forms.ComboBox operationComboBox;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.TextBox Vector2TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

