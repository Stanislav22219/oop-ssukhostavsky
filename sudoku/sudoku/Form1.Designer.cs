namespace sudoku
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.newGameButton = new System.Windows.Forms.Button();
            this.checkButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.beginnerLevel = new System.Windows.Forms.RadioButton();
            this.IntermediateLevel = new System.Windows.Forms.RadioButton();
            this.AdvancedLevel = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(42, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 560);
            this.panel1.TabIndex = 0;
            // 
            // newGameButton
            // 
            this.newGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.newGameButton.Location = new System.Drawing.Point(610, 473);
            this.newGameButton.Margin = new System.Windows.Forms.Padding(2);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(149, 88);
            this.newGameButton.TabIndex = 1;
            this.newGameButton.Text = "Нова гра";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // checkButton
            // 
            this.checkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.checkButton.Location = new System.Drawing.Point(610, 40);
            this.checkButton.Margin = new System.Windows.Forms.Padding(2);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(149, 88);
            this.checkButton.TabIndex = 2;
            this.checkButton.Text = "Перевірити значення";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.clearButton.Location = new System.Drawing.Point(610, 144);
            this.clearButton.Margin = new System.Windows.Forms.Padding(2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(149, 88);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Очистити введення";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // beginnerLevel
            // 
            this.beginnerLevel.AutoSize = true;
            this.beginnerLevel.Checked = true;
            this.beginnerLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.beginnerLevel.Location = new System.Drawing.Point(610, 330);
            this.beginnerLevel.Margin = new System.Windows.Forms.Padding(2);
            this.beginnerLevel.Name = "beginnerLevel";
            this.beginnerLevel.Size = new System.Drawing.Size(135, 28);
            this.beginnerLevel.TabIndex = 3;
            this.beginnerLevel.TabStop = true;
            this.beginnerLevel.Text = "Початковий";
            this.beginnerLevel.UseVisualStyleBackColor = true;
            // 
            // IntermediateLevel
            // 
            this.IntermediateLevel.AutoSize = true;
            this.IntermediateLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.IntermediateLevel.Location = new System.Drawing.Point(610, 362);
            this.IntermediateLevel.Margin = new System.Windows.Forms.Padding(2);
            this.IntermediateLevel.Name = "IntermediateLevel";
            this.IntermediateLevel.Size = new System.Drawing.Size(112, 28);
            this.IntermediateLevel.TabIndex = 3;
            this.IntermediateLevel.Text = "Середній";
            this.IntermediateLevel.UseVisualStyleBackColor = true;
            // 
            // AdvancedLevel
            // 
            this.AdvancedLevel.AutoSize = true;
            this.AdvancedLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.AdvancedLevel.Location = new System.Drawing.Point(610, 394);
            this.AdvancedLevel.Margin = new System.Windows.Forms.Padding(2);
            this.AdvancedLevel.Name = "AdvancedLevel";
            this.AdvancedLevel.Size = new System.Drawing.Size(149, 28);
            this.AdvancedLevel.TabIndex = 3;
            this.AdvancedLevel.Text = "Продвинутий";
            this.AdvancedLevel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(622, 264);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 54);
            this.label1.TabIndex = 4;
            this.label1.Text = "Рівень складності";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AdvancedLevel);
            this.Controls.Add(this.IntermediateLevel);
            this.Controls.Add(this.beginnerLevel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Sudoku";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.RadioButton beginnerLevel;
        private System.Windows.Forms.RadioButton IntermediateLevel;
        private System.Windows.Forms.RadioButton AdvancedLevel;
        private System.Windows.Forms.Label label1;
    }
}

