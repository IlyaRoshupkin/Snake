using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorisontalLine
    {
        private List<Point> _line = new List<Point>();

        public HorisontalLine(int xLeft, int xRight, int y, char sym)
        {
            for(int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x, y, sym);
                _line.Add(p);
            }
        }

        public void Draw()
        {
            foreach(Point p in _line)
            {
                p.Draw();
            }
        }
    }
}
