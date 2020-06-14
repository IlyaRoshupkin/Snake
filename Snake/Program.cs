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
            //int x = 5;
            //int y = 3;
            //Func(x);
            //Console.WriteLine(x);
            Point p1 = new Point();
            p1.x = 1;
            p1.y = 3;
            p1.sym = '1';
            //p1.Draw();
            Reset(p1);
            Console.ReadLine();

            //Console.Clear();
            //p1.Draw();


            //Point p2 = new Point(4,5,'2');
            //p2.Draw();
            //Move(p2,10,10);
            //p2.Draw();

            p1.Draw();
            //p2.Draw();

            //Console.ReadLine();
            //Console.Clear();

            //p2 = p1;

            //p2.Draw();
            
            Console.ReadLine();
        }

        private static void Reset(Point p)
        {
            p.Draw();
            p = new Point();
            Console.ReadLine();
            Console.Clear();

            p.Draw();
            Console.ReadLine();
            Console.Clear();
        }

        private static void Move(Point p2, int dx, int dy)
        {
            p2.x += dx;
            p2.y += dy;
        }

        private static void Func(int value)
        {
            Console.WriteLine(value);
            value++;
            Console.WriteLine(value);
        }
    }
}
