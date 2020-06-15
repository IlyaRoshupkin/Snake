using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            Field field = new Field(100, 30);
            HorisontalLine horisontalLine = new HorisontalLine(10, 20, 5, '$');
            VerticalLine verticalLine = new VerticalLine(15, 0, 10, '#');
            Point t = new Point(15, 10, '*');

            horisontalLine.Draw();
            verticalLine.Draw();

            Snake snake = new Snake(t, 10, Direction.RIGHT);
            snake.Draw();
            snake.Move();
            Console.ReadLine();
            snake.Move();
            Console.ReadLine();
            snake.Move();
            Console.ReadLine();
            snake.Move();
            Console.ReadLine();
            snake.Move();
            Console.ReadLine();

        }
    }
}
