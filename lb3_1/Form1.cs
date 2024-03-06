using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lb3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SortArray sortArray = new SortArray();
            sortArray.Add(5);
            sortArray.Add(3);
            sortArray.Add(5);
            sortArray.Add(2);
            sortArray.Process();
            sortArray.Display(console);

            XorArray xorArray = new XorArray();
            xorArray.Add(4);
            xorArray.Add(9);
            xorArray.Add(4);
            xorArray.Process();
            xorArray.Display(console);

        }
    }
}
