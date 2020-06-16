using System;
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

        internal bool IsTailHit()
        {
            Point head = pList.Last();
            for(int i = 0; i < pList.Count - 1; i++)
            {
                if (head.IsHit(pList[i]))
                    return true;
            }
            return false;
        }

        internal bool IsWallHit(List<Figure> walls)
        {
            Point head = GetNextPoint();
            foreach (Figure wall in walls)
            {
                if (wall.IsHit(head))
                    return true;
            }
            return false;
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

        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.sym = head.sym;
                pList.Add(food);
                return true;
            }
            else
                return false;
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
