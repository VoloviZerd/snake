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
            //Point p1 = new Point(1,3,'*');
            //p1.Draw();

            //Point p2 = new Point(4,5,'#');
            //p2.Draw();

            //Horiz_Line Hline = new Horiz_Line(5,10,8,'+');
            //Hline.Drow();

            //Vert_Line Vline = new Vert_Line(10, 20, 10, '+');
            //Vline.Drow();

            Console.SetBufferSize(120, 30);



            //Рамка
            Horiz_Line Topline = new Horiz_Line(0, 78, 0, '+');
            Topline.Drow();
            Horiz_Line Bottomline = new Horiz_Line(0, 78, 24, '+');
            Bottomline.Drow();
            Vert_Line Leftline = new Vert_Line(0, 24, 0, '+');
            Leftline.Drow();
            Vert_Line Rightline = new Vert_Line(0, 24, 78, '+');
            Rightline.Drow();


            //Отрисовка точек
            Point p1 = new Point(1,3,'*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();

            Console.ReadLine();
        }

       
    }
}
