using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace lb3_1
{
    public abstract class Array
    {
        protected List<double> elements = new List<double>();

        public virtual void Add(double element)
        {
            elements.Add(element);
        }

        public abstract void Process();

        public void Display(ListBox listBox)
        {
            foreach (var element in elements)
            {
                listBox.Items.Add(element);
            }
            listBox.Items.Add('-');
        }
    }

}
