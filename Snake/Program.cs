using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 10;
            int y1 = 10;
            char sym1 = '*';
            Draw(x1, y1, sym1);
            Console.ReadLine();
        }

        private static void Draw(int x1, int y1, char sym1)
        {
            Console.SetCursorPosition(x1, y1);
            Console.Write(sym1);
        }
    }
}
