using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace lb7
{
    public partial class blank : Form
    {
        public blank()
        {
            InitializeComponent();
            sbTime.Text = Convert.ToString(System.DateTime.Now.ToLongTimeString());
            sbTime.ToolTipText = Convert.ToString(System.DateTime.Today.ToLongDateString());
        }
        public string DocName = "";

        private string BufferText = "";
        public void Cut()
        {
            this.BufferText = richTextBox1.SelectedText;
            richTextBox1.SelectedText = "";
        }
        public void Copy()
        {
            this.BufferText = richTextBox1.SelectedText;
        }
        public void Paste()
        {
            richTextBox1.SelectedText = this.BufferText;
        }
        public void SelectAll()
        {
            richTextBox1.SelectAll();
        }
        public void Delete()
        {
            richTextBox1.SelectedText = "";
            this.BufferText = "";
        }

        private void cmnuCut_Click(object sender, EventArgs e)
        {
            Cut();
        }

        private void cmnuCopy_Click(object sender, EventArgs e)
        {
            Copy();
        }

        private void cmnuPaste_Click(object sender, EventArgs e)
        {   
            richTextBox1.Text = Clipboard.GetText(TextDataFormat.UnicodeText);
        }

        private void cmnuDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void cmnuSelectAll_Click(object sender, EventArgs e)
        {
            SelectAll();
        }
        public void Open(string OpenFileName)
        {
            if (OpenFileName == "")
            {
                return;
            }
            else
            {
                StreamReader sr = new StreamReader(OpenFileName);
                richTextBox1.Text = sr.ReadToEnd();
                // Закрываем поток
                sr.Close();
                DocName = OpenFileName;
            }
        }
        public void Save(string SaveFileName)
        {
            if (SaveFileName == "")
            {
                return;
            }
            else
            {
                StreamWriter sw = new StreamWriter(SaveFileName);
                sw.WriteLine(richTextBox1.Text);
                sw.Close();
                DocName = SaveFileName;
            }
        }
        
        public bool IsSaved = false;

        private void blank_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsSaved == false)
                if (MessageBox.Show("Do you want save changes in " + this.DocName + "?",
                "Message", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Save(this.DocName);
                }
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            sbAmount.Text = "Аmount of symbols " + richTextBox1.Text.Length.ToString();

            string keywords = @"\b(public|private|partial|static|namespace|class|using|void|foreach|in|frm|this)\b";
            MatchCollection keywordMatches = Regex.Matches(richTextBox1.Text, keywords);
 
            string types = @"\b(Console)\b";
            MatchCollection typeMatches = Regex.Matches(richTextBox1.Text, types);

            string comments = @"(\/\/.+?$|\/\*.+?\*\/|EventArgs)";
            MatchCollection commentMatches = Regex.Matches(richTextBox1.Text, comments, RegexOptions.Multiline);

            string strings = "\".+?\"";
            MatchCollection stringMatches = Regex.Matches(richTextBox1.Text, strings);

            int originalIndex = richTextBox1.SelectionStart;
            int originalLength = richTextBox1.SelectionLength;
            Color originalColor = Color.Black;

            statusStrip1.Focus();

            richTextBox1.SelectionStart = 0;
            richTextBox1.SelectionLength = richTextBox1.Text.Length;
            richTextBox1.SelectionColor = originalColor;

            foreach (Match m in keywordMatches)
            {
                richTextBox1.SelectionStart = m.Index;
                richTextBox1.SelectionLength = m.Length;
                richTextBox1.SelectionColor = Color.Blue;
            }

            foreach (Match m in typeMatches)
            {
                richTextBox1.SelectionStart = m.Index;
                richTextBox1.SelectionLength = m.Length;
                richTextBox1.SelectionColor = Color.DarkCyan;
            }

            foreach (Match m in commentMatches)
            {
                richTextBox1.SelectionStart = m.Index;
                richTextBox1.SelectionLength = m.Length;
                richTextBox1.SelectionColor = Color.Green;
            }

            foreach (Match m in stringMatches)
            {
                richTextBox1.SelectionStart = m.Index;
                richTextBox1.SelectionLength = m.Length;
                richTextBox1.SelectionColor = Color.Brown;
            }

            richTextBox1.SelectionStart = originalIndex;
            richTextBox1.SelectionLength = originalLength;
            richTextBox1.SelectionColor = originalColor;

            richTextBox1.Focus();
        }

        
    }
   
        


}
