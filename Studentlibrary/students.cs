using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentlibrary
{
    public class students : IComparable<students>
    {
        public int X { get; set; }

        public int CompareTo(students other)
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
            return string.Format("{0}", this.X);
        }
    }
}