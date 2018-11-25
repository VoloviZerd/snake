using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Figure //Базовый класс для наследников (Vert_Line и Horiz_Line)
    {
       protected List<Point> pList; //добавим модификатор доступа <protected>,чтобы переменная pList была видна у наследников 

        public virtual void Draw() //Указание virtual дает возможность наследнику переопределить этот метод
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
