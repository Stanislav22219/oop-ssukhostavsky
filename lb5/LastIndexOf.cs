using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb5
{
    class LastIndexOf
    {
        public void lastIndexOf(ListBox console)
        {
            string s = "Hello World";
            string sub = "l";
            int index = s.LastIndexOf(sub);
            console.Items.Add(index);
        }
    }
}
