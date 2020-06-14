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
            Point p1 = new Point(10, 10,'&');
            Point p2 = new Point(10, 20, '&');
            Point p3 = new Point(20, 10, '&');
            Point p4 = new Point(10, 5, '&');

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);

            List<char> symList = new List<char>();
            symList.Add('@');
            symList.Add('#');
            symList.Add('$');
            symList.Add('%');
            Console.ReadLine();
        }
    }
}
