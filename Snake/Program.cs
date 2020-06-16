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
            field.Draw();

            Point tail = new Point(10, 10, '*');
            Snake snake = new Snake(tail, 10, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(field.MAPWIDTH, field.MAPHEIGTH, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if(snake.IsWallHit(field.walls) || snake.IsTailHit())
                {
                    break;
                }
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

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Red;
            string text = "Game Over";
            Console.SetCursorPosition(Console.WindowWidth / 2 - text.Length / 2, Console.WindowHeight / 2);
            Console.WriteLine(text);
            Console.ReadLine();
        }

    }
}
