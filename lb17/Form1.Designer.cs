namespace lb17
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            lblPort = new Label();
            lblHost = new Label();
            btnFont = new Button();
            settingsButton = new Button();
            logoutButton = new Button();
            loginButton = new Button();
            userNameTextBox = new TextBox();
            label1 = new Label();
            chatTextBox = new TextBox();
            messageTextBox = new TextBox();
            sendButton = new Button();
            fontDialog1 = new FontDialog();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblPort);
            groupBox1.Controls.Add(lblHost);
            groupBox1.Controls.Add(btnFont);
            groupBox1.Controls.Add(settingsButton);
            groupBox1.Controls.Add(logoutButton);
            groupBox1.Controls.Add(loginButton);
            groupBox1.Controls.Add(userNameTextBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(10, 5);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(478, 88);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // lblPort
            // 
            lblPort.AutoSize = true;
            lblPort.Location = new Point(173, 62);
            lblPort.Name = "lblPort";
            lblPort.Size = new Size(35, 15);
            lblPort.TabIndex = 7;
            lblPort.Text = "Порт";
            // 
            // lblHost
            // 
            lblHost.AutoSize = true;
            lblHost.Location = new Point(5, 62);
            lblHost.Name = "lblHost";
            lblHost.Size = new Size(32, 15);
            lblHost.TabIndex = 6;
            lblHost.Text = "Хост";
            // 
            // btnFont
            // 
            btnFont.Location = new Point(384, 48);
            btnFont.Margin = new Padding(3, 2, 3, 2);
            btnFont.Name = "btnFont";
            btnFont.Size = new Size(83, 29);
            btnFont.TabIndex = 5;
            btnFont.Text = "Текст";
            btnFont.UseVisualStyleBackColor = true;
            btnFont.Click += btnFont_Click;
            // 
            // settingsButton
            // 
            settingsButton.Image = (Image)resources.GetObject("settingsButton.Image");
            settingsButton.Location = new Point(384, 14);
            settingsButton.Margin = new Padding(3, 2, 3, 2);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(84, 30);
            settingsButton.TabIndex = 4;
            settingsButton.Text = "Порт";
            settingsButton.UseVisualStyleBackColor = true;
            settingsButton.Click += settingsButton_Click;
            // 
            // logoutButton
            // 
            logoutButton.Location = new Point(287, 48);
            logoutButton.Margin = new Padding(3, 2, 3, 2);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(91, 29);
            logoutButton.TabIndex = 3;
            logoutButton.Text = "Вийти";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += logoutButton_Click;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(287, 14);
            loginButton.Margin = new Padding(3, 2, 3, 2);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(91, 30);
            loginButton.TabIndex = 2;
            loginButton.Text = "Увійти";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(108, 19);
            userNameTextBox.Margin = new Padding(3, 2, 3, 2);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(173, 23);
            userNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 23);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "Введіть ім'я";
            // 
            // chatTextBox
            // 
            chatTextBox.Location = new Point(10, 98);
            chatTextBox.Margin = new Padding(3, 2, 3, 2);
            chatTextBox.Multiline = true;
            chatTextBox.Name = "chatTextBox";
            chatTextBox.Size = new Size(478, 176);
            chatTextBox.TabIndex = 1;
            // 
            // messageTextBox
            // 
            messageTextBox.Location = new Point(10, 278);
            messageTextBox.Margin = new Padding(3, 2, 3, 2);
            messageTextBox.Multiline = true;
            messageTextBox.Name = "messageTextBox";
            messageTextBox.Size = new Size(378, 53);
            messageTextBox.TabIndex = 2;
            // 
            // sendButton
            // 
            sendButton.Location = new Point(394, 278);
            sendButton.Margin = new Padding(3, 2, 3, 2);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(94, 53);
            sendButton.TabIndex = 3;
            sendButton.Text = "Надіслати";
            sendButton.UseVisualStyleBackColor = true;
            sendButton.Click += sendButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 337);
            Controls.Add(sendButton);
            Controls.Add(messageTextBox);
            Controls.Add(chatTextBox);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Чат TCP";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button logoutButton;
        private Button loginButton;
        private TextBox userNameTextBox;
        private Label label1;
        private TextBox chatTextBox;
        private TextBox messageTextBox;
        private Button sendButton;
        private Button settingsButton;
        private Button btnFont;
        private FontDialog fontDialog1;
        private Label lblPort;
        private Label lblHost;
    }
}
