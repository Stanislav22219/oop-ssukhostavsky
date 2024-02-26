using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb3
{
    public abstract class Array
    {
        protected List<double> elements = new List<double>();

        public virtual void Add(double element)
        {
            elements.Add(element);
        }

        public abstract void Process();

        public void ForEach(Action<double> action)
        {
            foreach (var element in elements)
            {
                action(element);
            }
        }
    }
}
