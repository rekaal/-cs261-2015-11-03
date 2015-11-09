using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Vector[] vectors = new Vector[]
            {
                new Vector{ X =3, Y = 4},
                new Vector{ X = 2, Y = 2},
                new Vector{ X = 5, Y = 2}
            };

            for (int index = 0; index < vectors.Length; ++index)
            {
                Console.WriteLine(vectors[index]);
            }
            Console.WriteLine("排序後");
            Array.Sort(vectors);
            for (int index = 0; index < vectors.Length; ++index)
            {
                Console.WriteLine(vectors[index]);
            }
        }
    }
}