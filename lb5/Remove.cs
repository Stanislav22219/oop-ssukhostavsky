using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb5
{
    class Remove
    {
        public void remove(ListBox console)
        {
            string s = "Hello World";
            int index = 4;
            int length = 3;
            s = s.Remove(index, length);
            console.Items.Add(s);
        }

    }
}
