using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IDisplayable displayer = new LcdTv();
            displayer.Display("我要的訊息");
        }
    }
}