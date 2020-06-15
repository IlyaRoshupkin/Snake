using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            HorisontalLine line = new HorisontalLine(5, 10, 5, '*');
            line.Draw();
            Console.ReadLine();

            VerticalLine verticalLine = new VerticalLine(12, 5, 10, '#');
            verticalLine.Draw();
            Console.ReadLine();
        }
    }
}
