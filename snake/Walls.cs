using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Walls
    {
        List<Figure> wallList;

        public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();

            //Рамка
            Horiz_Line Topline = new Horiz_Line(0, mapWidth - 2, 0, '+');

            Horiz_Line Bottomline = new Horiz_Line(0, mapWidth - 2, mapHeight - 1, '+');

            Vert_Line Leftline = new Vert_Line(0, mapHeight - 1, mapWidth - 2, '+');

            Vert_Line Rightline = new Vert_Line(0, 24, 78, '+');

            wallList.Add(Topline);
            wallList.Add(Bottomline);
            wallList.Add(Leftline);
            wallList.Add(Rightline);

        }

        internal bool IsHit(Figure figure)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
                return false;
            }
        }
        public void Draw()
            {
                foreach (var wall in wallList)
                {
                    wall.Draw();
                }
            }
        
    }
}
