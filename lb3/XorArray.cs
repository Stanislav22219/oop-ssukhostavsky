using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb3
{
    public class XorArray : Array
    {
        public override void Add(double element)
        {
            if (elements.Contains(element))
            {
                elements.Remove(element);
            }
            else
            {
                base.Add(element);
            }
        }

        public override void Process()
        {
            for (int i = 0; i < elements.Count; i++)
            {
                elements[i] = Math.Sqrt(elements[i]);
            }
        }
    }
}
