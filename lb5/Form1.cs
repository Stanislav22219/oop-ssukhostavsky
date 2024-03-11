using System;

namespace lb5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {    
            Remove Remove = new Remove();
            Remove.remove(console);


            IndexOf IndexOf = new IndexOf();
            IndexOf.indexOf(console);

            LastIndexOf LastIndexOf = new LastIndexOf();
            LastIndexOf.lastIndexOf(console);
        }
    }
}
