using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake:Figure
    {
        public Snake(Point tail, int length, Direction direction)
        {
            _line = new List<Point>();
            for(int snakePoint = 0; snakePoint < length; snakePoint++)
            {
                Point p = new Point(tail);
                p.Move(snakePoint, direction);
                _line.Add(p);
            }
        }
    }
}
