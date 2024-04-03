namespace lb5
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
            btnRemove = new Button();
            txtString = new TextBox();
            txtSub = new TextBox();
            lblString = new Label();
            lblSubString = new Label();
            lblLength = new Label();
            lblIndex = new Label();
            txtLength = new TextBox();
            txtIndex = new TextBox();
            btnFindFirst = new Button();
            btnFindLast = new Button();
            SuspendLayout();
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(272, 22);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(75, 41);
            btnRemove.TabIndex = 0;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // txtString
            // 
            txtString.Location = new Point(116, 23);
            txtString.Name = "txtString";
            txtString.Size = new Size(100, 23);
            txtString.TabIndex = 1;
            // 
            // txtSub
            // 
            txtSub.Location = new Point(116, 66);
            txtSub.Name = "txtSub";
            txtSub.Size = new Size(100, 23);
            txtSub.TabIndex = 2;
            // 
            // lblString
            // 
            lblString.AutoSize = true;
            lblString.Location = new Point(26, 26);
            lblString.Name = "lblString";
            lblString.Size = new Size(38, 15);
            lblString.TabIndex = 3;
            lblString.Text = "String";
            // 
            // lblSubString
            // 
            lblSubString.AutoSize = true;
            lblSubString.Location = new Point(26, 69);
            lblSubString.Name = "lblSubString";
            lblSubString.Size = new Size(57, 15);
            lblSubString.TabIndex = 4;
            lblSubString.Text = "Substring";
            // 
            // lblLength
            // 
            lblLength.AutoSize = true;
            lblLength.Location = new Point(26, 155);
            lblLength.Name = "lblLength";
            lblLength.Size = new Size(44, 15);
            lblLength.TabIndex = 8;
            lblLength.Text = "Lenght";
            // 
            // lblIndex
            // 
            lblIndex.AutoSize = true;
            lblIndex.Location = new Point(26, 112);
            lblIndex.Name = "lblIndex";
            lblIndex.Size = new Size(36, 15);
            lblIndex.TabIndex = 7;
            lblIndex.Text = "Index";
            // 
            // txtLength
            // 
            txtLength.Location = new Point(116, 152);
            txtLength.Name = "txtLength";
            txtLength.Size = new Size(100, 23);
            txtLength.TabIndex = 6;
            // 
            // txtIndex
            // 
            txtIndex.Location = new Point(116, 109);
            txtIndex.Name = "txtIndex";
            txtIndex.Size = new Size(100, 23);
            txtIndex.TabIndex = 5;
            // 
            // btnFindFirst
            // 
            btnFindFirst.Location = new Point(272, 76);
            btnFindFirst.Name = "btnFindFirst";
            btnFindFirst.Size = new Size(75, 42);
            btnFindFirst.TabIndex = 9;
            btnFindFirst.Text = "Find first";
            btnFindFirst.UseVisualStyleBackColor = true;
            btnFindFirst.Click += btnFindFirst_Click;
            // 
            // btnFindLast
            // 
            btnFindLast.Location = new Point(272, 133);
            btnFindLast.Name = "btnFindLast";
            btnFindLast.Size = new Size(75, 42);
            btnFindLast.TabIndex = 10;
            btnFindLast.Text = "Find last";
            btnFindLast.UseVisualStyleBackColor = true;
            btnFindLast.Click += btnFindLast_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 194);
            Controls.Add(btnFindLast);
            Controls.Add(btnFindFirst);
            Controls.Add(lblLength);
            Controls.Add(lblIndex);
            Controls.Add(txtLength);
            Controls.Add(txtIndex);
            Controls.Add(lblSubString);
            Controls.Add(lblString);
            Controls.Add(txtSub);
            Controls.Add(txtString);
            Controls.Add(btnRemove);
            Name = "Form1";
            Text = "Робота з рядками";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRemove;
        private TextBox txtString;
        private TextBox txtSub;
        private Label lblString;
        private Label lblSubString;
        private Label lblLength;
        private Label lblIndex;
        private TextBox txtLength;
        private TextBox txtIndex;
        private Button btnFindFirst;
        private Button btnFindLast;
    }
}
