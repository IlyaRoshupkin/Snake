using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figure
    {
        protected List<Point> _line;

        public void Draw()
        {
            foreach (Point p in _line)
                p.Draw();
        }
    }
}
