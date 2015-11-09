using Studentlibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("請輸入國文成績：");
            String A = Console.ReadLine();
            int ANumber = int.Parse(A);
            Console.WriteLine("請輸入英文成績：");
            String B = Console.ReadLine();
            int BNumber = int.Parse(B);
            Console.WriteLine("請輸入數學成績：");
            String C = Console.ReadLine();
            int CNumber = int.Parse(C);
            Console.WriteLine("請輸入社會成績：");
            String D = Console.ReadLine();
            int DNumber = int.Parse(D);
            Console.WriteLine("請輸入自然成績：");
            String E = Console.ReadLine();
            int ENumber = int.Parse(E);
            students[] Students = new students[]
                {
                    new Students {ANumber},
                };
            Array.Sort(Students);
            for (int index = 0; index < Students.Length; ++index)
            {
                Console.WriteLine(Students[index]);
            }
        }
    }
}