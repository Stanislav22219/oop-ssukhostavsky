
namespace lb7
{
    partial class blank
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(blank));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmnuCut = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmnuSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sbAmount = new System.Windows.Forms.ToolStripStatusLabel();
            this.sbTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            resources.ApplyResources(this.richTextBox1, "richTextBox1");
            this.richTextBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmnuCut,
            this.cmnuCopy,
            this.cmnuPaste,
            this.cmnuDelete,
            this.toolStripSeparator2,
            this.cmnuSelectAll});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            // 
            // cmnuCut
            // 
            resources.ApplyResources(this.cmnuCut, "cmnuCut");
            this.cmnuCut.Name = "cmnuCut";
            this.cmnuCut.Click += new System.EventHandler(this.cmnuCut_Click);
            // 
            // cmnuCopy
            // 
            resources.ApplyResources(this.cmnuCopy, "cmnuCopy");
            this.cmnuCopy.Name = "cmnuCopy";
            this.cmnuCopy.Click += new System.EventHandler(this.cmnuCopy_Click);
            // 
            // cmnuPaste
            // 
            resources.ApplyResources(this.cmnuPaste, "cmnuPaste");
            this.cmnuPaste.Name = "cmnuPaste";
            this.cmnuPaste.Click += new System.EventHandler(this.cmnuPaste_Click);
            // 
            // cmnuDelete
            // 
            resources.ApplyResources(this.cmnuDelete, "cmnuDelete");
            this.cmnuDelete.Name = "cmnuDelete";
            this.cmnuDelete.Click += new System.EventHandler(this.cmnuDelete_Click);
            // 
            // toolStripSeparator2
            // 
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            // 
            // cmnuSelectAll
            // 
            resources.ApplyResources(this.cmnuSelectAll, "cmnuSelectAll");
            this.cmnuSelectAll.Name = "cmnuSelectAll";
            this.cmnuSelectAll.Click += new System.EventHandler(this.cmnuSelectAll_Click);
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbAmount,
            this.sbTime});
            this.statusStrip1.Name = "statusStrip1";
            // 
            // sbAmount
            // 
            resources.ApplyResources(this.sbAmount, "sbAmount");
            this.sbAmount.Name = "sbAmount";
            // 
            // sbTime
            // 
            resources.ApplyResources(this.sbTime, "sbTime");
            this.sbTime.Name = "sbTime";
            // 
            // blank
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "blank";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.blank_FormClosing);
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cmnuCut;
        private System.Windows.Forms.ToolStripMenuItem cmnuCopy;
        private System.Windows.Forms.ToolStripMenuItem cmnuPaste;
        private System.Windows.Forms.ToolStripMenuItem cmnuDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem cmnuSelectAll;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sbAmount;
        private System.Windows.Forms.ToolStripStatusLabel sbTime;
    }
}