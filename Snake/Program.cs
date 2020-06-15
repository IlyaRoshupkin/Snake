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
            Point tail = new Point(10, 10, '*');
            Snake snake = new Snake(tail, 10, Direction.RIGHT);
            snake.Draw();

            while (true)
            {
                snake.Move();
                Thread.Sleep(300);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key);
                }
            }

            
        }
    }
}
