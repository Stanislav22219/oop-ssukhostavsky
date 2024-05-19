namespace lb10_1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnStart1 = new System.Windows.Forms.Button();
            this.btnStop1 = new System.Windows.Forms.Button();
            this.btnStart2 = new System.Windows.Forms.Button();
            this.btnStart3 = new System.Windows.Forms.Button();
            this.btnStop2 = new System.Windows.Forms.Button();
            this.btnStop3 = new System.Windows.Forms.Button();
            this.btnStartAll = new System.Windows.Forms.Button();
            this.btnStopAll = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.richTextBox2_2 = new System.Windows.Forms.RichTextBox();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(18, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 182);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(289, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 182);
            this.panel2.TabIndex = 1;
            // 
            // btnStart1
            // 
            this.btnStart1.Location = new System.Drawing.Point(18, 205);
            this.btnStart1.Name = "btnStart1";
            this.btnStart1.Size = new System.Drawing.Size(200, 23);
            this.btnStart1.TabIndex = 3;
            this.btnStart1.Text = "Запустити потік 1";
            this.btnStart1.UseVisualStyleBackColor = true;
            this.btnStart1.Click += new System.EventHandler(this.btnStart1_Click);
            // 
            // btnStop1
            // 
            this.btnStop1.ForeColor = System.Drawing.Color.Red;
            this.btnStop1.Location = new System.Drawing.Point(18, 263);
            this.btnStop1.Name = "btnStop1";
            this.btnStop1.Size = new System.Drawing.Size(200, 23);
            this.btnStop1.TabIndex = 4;
            this.btnStop1.Text = "Зупинити потік 1";
            this.btnStop1.UseVisualStyleBackColor = true;
            this.btnStop1.Click += new System.EventHandler(this.btnStop1_Click);
            // 
            // btnStart2
            // 
            this.btnStart2.Location = new System.Drawing.Point(289, 205);
            this.btnStart2.Name = "btnStart2";
            this.btnStart2.Size = new System.Drawing.Size(200, 23);
            this.btnStart2.TabIndex = 5;
            this.btnStart2.Text = "Запустити потік 2";
            this.btnStart2.UseVisualStyleBackColor = true;
            this.btnStart2.Click += new System.EventHandler(this.btnStart2_Click);
            // 
            // btnStart3
            // 
            this.btnStart3.Location = new System.Drawing.Point(552, 205);
            this.btnStart3.Name = "btnStart3";
            this.btnStart3.Size = new System.Drawing.Size(200, 23);
            this.btnStart3.TabIndex = 6;
            this.btnStart3.Text = "Запустити потік 3";
            this.btnStart3.UseVisualStyleBackColor = true;
            this.btnStart3.Click += new System.EventHandler(this.btnStart3_Click);
            // 
            // btnStop2
            // 
            this.btnStop2.ForeColor = System.Drawing.Color.Red;
            this.btnStop2.Location = new System.Drawing.Point(289, 263);
            this.btnStop2.Name = "btnStop2";
            this.btnStop2.Size = new System.Drawing.Size(200, 23);
            this.btnStop2.TabIndex = 7;
            this.btnStop2.Text = "Зупинити потік 2";
            this.btnStop2.UseVisualStyleBackColor = true;
            this.btnStop2.Click += new System.EventHandler(this.btnStop2_Click);
            // 
            // btnStop3
            // 
            this.btnStop3.ForeColor = System.Drawing.Color.Red;
            this.btnStop3.Location = new System.Drawing.Point(552, 263);
            this.btnStop3.Name = "btnStop3";
            this.btnStop3.Size = new System.Drawing.Size(200, 23);
            this.btnStop3.TabIndex = 8;
            this.btnStop3.Text = "Зупинити потік 3";
            this.btnStop3.UseVisualStyleBackColor = true;
            this.btnStop3.Click += new System.EventHandler(this.btnStop3_Click);
            // 
            // btnStartAll
            // 
            this.btnStartAll.Location = new System.Drawing.Point(18, 321);
            this.btnStartAll.Name = "btnStartAll";
            this.btnStartAll.Size = new System.Drawing.Size(734, 23);
            this.btnStartAll.TabIndex = 9;
            this.btnStartAll.Text = "Запустити всі потоки";
            this.btnStartAll.UseVisualStyleBackColor = true;
            this.btnStartAll.Click += new System.EventHandler(this.btnStartAll_Click);
            // 
            // btnStopAll
            // 
            this.btnStopAll.ForeColor = System.Drawing.Color.Red;
            this.btnStopAll.Location = new System.Drawing.Point(18, 379);
            this.btnStopAll.Name = "btnStopAll";
            this.btnStopAll.Size = new System.Drawing.Size(734, 23);
            this.btnStopAll.TabIndex = 10;
            this.btnStopAll.Text = "Зупинити всі потоки";
            this.btnStopAll.UseVisualStyleBackColor = true;
            this.btnStopAll.Click += new System.EventHandler(this.btnStopAll_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(552, 6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(200, 182);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(801, 451);
            this.tabControl1.TabIndex = 12;
            // 
            // richTextBox2_2
            // 
            this.richTextBox2_2.Location = new System.Drawing.Point(288, 61);
            this.richTextBox2_2.Name = "richTextBox2_2";
            this.richTextBox2_2.Size = new System.Drawing.Size(200, 173);
            this.richTextBox2_2.TabIndex = 26;
            this.richTextBox2_2.Text = "";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(17, 25);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(734, 20);
            this.inputTextBox.TabIndex = 25;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(551, 61);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(200, 173);
            this.richTextBox2.TabIndex = 24;
            this.richTextBox2.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(17, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(734, 56);
            this.button2.TabIndex = 20;
            this.button2.Text = "Запустити всі потоки";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Controls.Add(this.btnStopAll);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.btnStartAll);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.btnStop3);
            this.tabPage1.Controls.Add(this.btnStart1);
            this.tabPage1.Controls.Add(this.btnStop2);
            this.tabPage1.Controls.Add(this.btnStop1);
            this.tabPage1.Controls.Add(this.btnStart3);
            this.tabPage1.Controls.Add(this.btnStart2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage1.Size = new System.Drawing.Size(793, 425);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Завдання 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(17, 61);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(200, 173);
            this.richTextBox3.TabIndex = 27;
            this.richTextBox3.Text = "";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.richTextBox3);
            this.tabPage3.Controls.Add(this.inputTextBox);
            this.tabPage3.Controls.Add(this.richTextBox2);
            this.tabPage3.Controls.Add(this.richTextBox2_2);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(793, 425);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Завдання 2";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Багатопотоковість .NET";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnStart1;
        private System.Windows.Forms.Button btnStop1;
        private System.Windows.Forms.Button btnStart2;
        private System.Windows.Forms.Button btnStart3;
        private System.Windows.Forms.Button btnStop2;
        private System.Windows.Forms.Button btnStop3;
        private System.Windows.Forms.Button btnStartAll;
        private System.Windows.Forms.Button btnStopAll;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.RichTextBox richTextBox2_2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.TabPage tabPage3;
    }
}

