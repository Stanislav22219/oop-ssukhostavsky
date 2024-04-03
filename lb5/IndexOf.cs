using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb5
{
    class IndexOf
    {
        public void indexOf(TextBox txtString, TextBox txtSub)
        {
            string s = txtString.Text;
            string sub = txtSub.Text;
            int index = s.IndexOf(sub);
            MessageBox.Show(index.ToString());
        }
    }
}
