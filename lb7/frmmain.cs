using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lb7
{
    public partial class frmmain : Form
    {
        
        public frmmain()
        {
            InitializeComponent();
            mnuSave.Enabled = false;
        }

        private void mnuNew_Click(object sender, EventArgs e)
        {
            blank frm = new blank();
            frm.DocName = "Untitled " + ++openDocuments;
            frm.Text = frm.DocName;
            frm.MdiParent = this;
            frm.Show();
        }
        private int openDocuments = 0;

        private void mnuArrangeIcons_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void theHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void theVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void mnuCut_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.Cut();
        }

        private void mnuCopy_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.Copy();
        }

        private void mnuPaste_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.richTextBox1.Text = Clipboard.GetText(TextDataFormat.UnicodeText);
            
        }

        private void mnuDelete_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.Delete();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.SelectAll();
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                blank frm = new blank();
                frm.Open(openFileDialog1.FileName);
                frm.MdiParent = this;
                frm.DocName = openFileDialog1.FileName;
                frm.Text = frm.DocName;
                frm.Show();
            }
            mnuSave.Enabled = true;

        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.Save(frm.DocName);

            frm.IsSaved = true;

        }

        private void mnuSaveAs_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                blank frm = (blank)this.ActiveMdiChild;
                frm.Save(saveFileDialog1.FileName);
                frm.MdiParent = this;
                frm.DocName = saveFileDialog1.FileName;
                frm.Text = frm.DocName;

                mnuSave.Enabled = true;
                frm.IsSaved = true;
            }            
        }

        private void mnuFont_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.MdiParent = this;
            fontDialog1.ShowColor = true;
            fontDialog1.Font = frm.richTextBox1.SelectionFont;
            fontDialog1.Color = frm.richTextBox1.SelectionColor;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                frm.richTextBox1.SelectionFont = fontDialog1.Font;
                frm.richTextBox1.SelectionColor = fontDialog1.Color;
            }
            frm.Show();
        }

        private void mnuColor_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.MdiParent = this;
            colorDialog1.Color = frm.richTextBox1.SelectionColor;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                frm.richTextBox1.SelectionColor = colorDialog1.Color;
            }
            frm.Show();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuFind_Click(object sender, EventArgs e)
        {
            FindForm frm = new FindForm();
            if (frm.ShowDialog(this) == DialogResult.Cancel) return;
            blank form = (blank)this.ActiveMdiChild;
            form.MdiParent = this;
            int start = form.richTextBox1.SelectionStart;
            form.richTextBox1.Find(frm.FindText, start, frm.FindCondition);
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            About frm = new About();
            frm.ShowDialog();
        }

        private void tbAbout_Click(object sender, EventArgs e)
        {
            About frm = new About();
            frm.ShowDialog();
        }

        private void toolBarMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Equals(tbNew))
            {
                mnuNew_Click(this, new EventArgs());
            }
            if (e.ClickedItem.Equals(tbOpen))
            {
                mnuOpen_Click(this, new EventArgs());
            }
            if (e.ClickedItem.Equals(tbSave))
            {
                mnuSave_Click(this, new EventArgs());
            }
            if (e.ClickedItem.Equals(tbCut))
            {
                mnuCut_Click(this, new EventArgs());
            }
            if (e.ClickedItem.Equals(tbCopy))
            {
                mnuCopy_Click(this, new EventArgs());
            }
            if (e.ClickedItem.Equals(tbPaste))
            {
                mnuPaste_Click(this, new EventArgs());
            }
        }

        private void ukranianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("uk");
            this.Controls.Clear();
            InitializeComponent();
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
            this.Controls.Clear();
            InitializeComponent();
        }

        public void tbAlignCenter_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.MdiParent = this;
            frm.richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void tbAlignLeft_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.MdiParent = this;
            frm.richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void tbAlignRight_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.MdiParent = this;
            frm.richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void tbImage_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            Clipboard.SetImage(Image.FromFile(openFileDialog2.FileName));
            blank frm = (blank)this.ActiveMdiChild;
            frm.MdiParent = this;
            frm.richTextBox1.Paste();
            Clipboard.Clear();
        }
    }
}
