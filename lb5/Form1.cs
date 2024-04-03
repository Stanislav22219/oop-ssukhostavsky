using System;

namespace lb5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Remove Remove = new Remove();
            Remove.remove(txtString, txtIndex, txtLength);
        }

        private void btnFindFirst_Click(object sender, EventArgs e)
        {
            IndexOf IndexOf = new IndexOf();
            IndexOf.indexOf(txtString, txtSub);
        }

        private void btnFindLast_Click(object sender, EventArgs e)
        {
            LastIndexOf LastIndexOf = new LastIndexOf();
            LastIndexOf.lastIndexOf(txtString, txtSub);
        }
    }
}
