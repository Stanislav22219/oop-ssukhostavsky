using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace lb12
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        
        string fn = @"C:\Users\Stas\Documents\Настроювані шаблони Office\cards.dotx";
        
        Word.Application word = new Word.Application();
        Word.Document doc = new Word.Document();

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            doc.Close();
            word.Quit();
            doc = null;
            word = null;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                Object missingObj = System.Reflection.Missing.Value;
                Object trueObj = true;
                Object falseObj = false;
                Object templatePathObj = fn;
                doc = word.Documents.Add(ref templatePathObj, ref missingObj, ref missingObj, ref missingObj);
                doc.Activate();
                foreach (Word.FormField f in doc.FormFields)
                {
                    switch (f.Name)
                    {
                        case "Name":
                            f.Range.Text = txtName.Text;
                            break;
                        case "Description":
                            f.Range.Text = txtDes.Text;
                            break;
                        case "Date":
                            f.Range.Text = txtDate.Text;
                            break;
                        case "Price":
                            f.Range.Text = txtPrice.Text;
                            break;
                        case "N":
                            f.Range.Text = txtN.Text;
                            break;
                        case "Code":
                            f.Range.Text = txtCode.Text;
                            break;
                        default: break;
                    }
                }
                word.Visible = true;
            }
            catch(Exception ex)
            {
                doc.Close();
                word.Quit();
                doc = null;
                word = null;
                throw ex;
            }
        }
    }
}
