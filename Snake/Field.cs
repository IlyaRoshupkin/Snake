using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Field
    {
        public int MAPWIDTH { get; }
        public int MAPHEIGTH { get; }

        public List<Figure> walls = new List<Figure>();

        public Field(int width, int heigth)
        {
            MAPWIDTH = width;
            MAPHEIGTH = heigth;

            Console.SetWindowSize(MAPWIDTH,MAPHEIGTH);
            Console.SetBufferSize(MAPWIDTH,MAPHEIGTH);

            HorisontalLine highLine = new HorisontalLine(1,MAPWIDTH-2,0,'%');
            HorisontalLine downLine = new HorisontalLine(1, MAPWIDTH-2, MAPHEIGTH-2, '%');
            VerticalLine leftLine = new VerticalLine(0, 0, MAPHEIGTH - 2, '&');
            VerticalLine rightLine = new VerticalLine(MAPWIDTH - 1, 0, MAPHEIGTH - 2, '&');

            walls.Add(highLine);
            walls.Add(downLine);
            walls.Add(leftLine);
            walls.Add(rightLine);
        }

        public void Draw()
        {
            foreach(Figure wall in walls)
            {
                wall.Draw();
            }
        }
    }
}
