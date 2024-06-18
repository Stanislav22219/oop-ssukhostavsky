﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lb16
{
    public partial class SettingsForm : Form
    {
        public string Host { get; set; }
        public int Port { get; set; }

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Host = txtHost.Text;
            Port = int.Parse(txtPort.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
