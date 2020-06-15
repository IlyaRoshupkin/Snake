using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point()
        {
        }

        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        internal void Move(int snakePoint, Direction direction)
        {
            switch (direction)
            {
                case Direction.UP:
                    {
                        y -= snakePoint;
                        break;
                    }
                case Direction.DOWN:
                    {
                        y += snakePoint;
                        break;
                    }
                case Direction.RIGHT:
                    {
                        x += snakePoint;
                        break;
                    }
                case Direction.LEFT:
                    {
                        x -= snakePoint;
                        break;
                    }
            }
        }

        internal void Clear()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(' ');
        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public override string ToString()
        {
            return x + " , " + y + " , " + sym;
        }
    }
}
