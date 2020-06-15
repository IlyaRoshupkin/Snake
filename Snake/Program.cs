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
            HorisontalLine horisontalLine = new HorisontalLine(10, 20, 5, '$');
            VerticalLine verticalLine = new VerticalLine(15, 0, 10, '#');

            horisontalLine.Draw();
            verticalLine.Draw();

            Console.ReadLine();
        }
    }
}
