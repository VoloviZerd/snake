using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1,3,'*');
            p1.Draw();

            Point p2 = new Point(4,5,'#');
            p2.Draw();

            Horiz_Line Hline = new Horiz_Line(5,10,8,'+');
            Hline.Drow();

            Vert_Line Vline = new Vert_Line(17, 30, 18, '+');
            Vline.Drow();

            Console.ReadLine();
        }

       
    }
}
