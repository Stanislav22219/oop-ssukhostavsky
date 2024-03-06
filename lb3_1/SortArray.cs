using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb3_1
{
    public class SortArray : Array
    {
        public override void Add(double element)
        {
            if (!elements.Contains(element))
            {
                base.Add(element);
            }
        }

        public override void Process()
        {
            elements.Sort();
        }
    }
}
