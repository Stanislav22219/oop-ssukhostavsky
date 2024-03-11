using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb5
{
    class IndexOf
    {
        public void indexOf(ListBox console)
        {
            string s = "Hello World";
            string sub = "or";
            int index = s.IndexOf(sub);
            console.Items.Add(index);
        }
    }
}
