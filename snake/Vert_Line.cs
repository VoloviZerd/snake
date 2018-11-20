using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Vert_Line : Figure
    {
        

        public Vert_Line(int yUp, int yDown, int x, char sym)
        {
            pList = new List<Point>();
            {
                pList = new List<Point>();
                for (int y = yUp; y <= yDown; y++)
                {
                    Point p = new Point(x, y, sym);
                    pList.Add(p);
                }






            }


        }

        
    }
}
