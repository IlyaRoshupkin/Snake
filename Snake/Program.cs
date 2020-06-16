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
            Field field = new Field(80, 20);

            Point tail = new Point(10, 10, '*');
            Snake snake = new Snake(tail, 10, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(field.MAPWIDTH, field.MAPHEIGTH, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }
                snake.Draw();
                    
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
