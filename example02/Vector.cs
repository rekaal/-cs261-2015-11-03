using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    internal class Vector : IComparable<Vector>
    {
        public double X { get; set; }
        public double Y { get; set; }

        public int CompareTo(Vector other)
        {
            if (this.X > other.X)
                return 1;
            else if (this.X == other.X)
                return 0;
            else
                return -1;
        }

        public override string ToString()
        {
            return string.Format("({0}, {1})", this.X, this.Y);
        }
    }
}