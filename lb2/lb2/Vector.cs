using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lb2
{
    public class Vector
    {
        private double[] components;

        public Vector(params double[] components)
        {
            this.components = new double[components.Length];
            Array.Copy(components, this.components, components.Length);
        }

        public Vector(Vector vector)
        {
            this.components = new double[vector.components.Length];
            Array.Copy(vector.components, this.components, vector.components.Length);
        }

        public double Length
        {
            get { return Math.Sqrt(this.components.Sum(x => x * x)); }
        }

        public static Vector operator +(Vector v1, Vector v2)
        {
            if (v1.components.Length != v2.components.Length)
                throw new ArgumentException("Vectors must have the same dimension.");

            return new Vector(v1.components.Zip(v2.components, (a, b) => a + b).ToArray());
        }

        public static Vector operator -(Vector v1, Vector v2)
        {
            if (v1.components.Length != v2.components.Length)
                throw new ArgumentException("Vectors must have the same dimension.");

            return new Vector(v1.components.Zip(v2.components, (a, b) => a - b).ToArray());
        }

        public static double operator *(Vector v1, Vector v2)
        {
            if (v1.components.Length != v2.components.Length)
                throw new ArgumentException("Vectors must have the same dimension.");

            return v1.components.Zip(v2.components, (a, b) => a * b).Sum();
        }

        public static Vector operator *(Vector v, double scalar)
        {
            return new Vector(v.components.Select(x => x * scalar).ToArray());
        }

        public override string ToString()
        {
            return "(" + string.Join(", ", this.components) + ")";
        }
    }
}
