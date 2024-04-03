using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb5
{
    class LastIndexOf
    {
        public void lastIndexOf(TextBox txtString, TextBox txtSub)
        {
            string s = txtString.Text;
            string sub = txtSub.Text;
            int index = s.LastIndexOf(sub);
            MessageBox.Show(index.ToString());
        }
    }
}
