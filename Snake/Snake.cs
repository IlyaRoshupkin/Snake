﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake:Figure
    {
        public Direction direction;
        public Snake(Point tail, int length, Direction _direction)
        {
            pList = new List<Point>();
            direction = _direction;
            for (int snakePoint = 0; snakePoint <= length; snakePoint++)
            {
                Point p = new Point(tail);
                p.Move(snakePoint, direction);
                pList.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }

        internal void HandleKey(ConsoleKeyInfo key)
        {
            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                    {
                        direction = Direction.UP;
                        break;
                    }
                case ConsoleKey.DownArrow:
                    {
                        direction = Direction.DOWN;
                        break;
                    }
                case ConsoleKey.RightArrow:
                    {
                        direction = Direction.RIGHT;
                        break;
                    }
                case ConsoleKey.LeftArrow:
                    {
                        direction = Direction.LEFT;
                        break;
                    }
            }
        }

        private Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }
    }
}
