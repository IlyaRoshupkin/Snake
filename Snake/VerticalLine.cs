using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine
    {
        private List<Point> _line = new List<Point>();

        public VerticalLine(int x, int yHigh, int yDown, char sym)
        {
            for(int y = yHigh; y <= yDown; y++)
            {
                Point p = new Point(x, y, sym);
                _line.Add(p);
            }
        }

        public void Draw()
        {
            foreach(Point p in _line)
                p.Draw();
        }
    }
}
