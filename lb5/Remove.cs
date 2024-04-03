using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb5
{
    class Remove
    {
        public void remove(TextBox txtString, TextBox txtIndex, TextBox txtLength)
        {
            string s = txtString.Text;
            int index = int.Parse(txtIndex.Text);
            int length = int.Parse(txtLength.Text);
            s = s.Remove(index, length);
            MessageBox.Show(s);
        }

    }
}
