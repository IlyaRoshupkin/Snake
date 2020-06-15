using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Field
    {
        public Field(int width, int heigth)
        {
            Console.SetWindowSize(width,heigth);
            Console.SetBufferSize(width,heigth);

            HorisontalLine highLine = new HorisontalLine(1,width-2,0,'+');
            HorisontalLine downLine = new HorisontalLine(1, width-2, heigth-2, '+');
            VerticalLine leftLine = new VerticalLine(0, 0, heigth - 2, '+');
            VerticalLine rightLine = new VerticalLine(width - 1, 0, heigth - 2, '+');

            highLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();
        }
    }
}
