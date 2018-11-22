using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Snake : Figure
    {
        public Direction direction;

        public Snake(Point tail, int length, Direction _direction)
        {
            direction = _direction;
            pList = new List<Point>();  //Создал список
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();

        }

        public Point GetNextPoint() ////Метод (функция) определяет, в какой точке окажется змейка в след. момент
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        public void HandleKey(ConsoleKey key) // Публичный метод на нажатие кнопки направления движения
        {
           
            if (key == ConsoleKey.LeftArrow)
                direction = Direction.LEFT;
            else if (key == ConsoleKey.RightArrow)
                direction = Direction.RIGHT;
            else if (key == ConsoleKey.DownArrow)
                direction = Direction.DOWN;
            else if (key == ConsoleKey.UpArrow)
                direction = Direction.UP;
        }

        internal bool Eat (Point food)
        {
            Point head = GetNextPoint(); //Метод (функция) определяет, в какой точке окажется змейка в след. момент
            if (head.IsHit(food)) //следовательно, получаем точку соответствующую след положению головы змейки
            { //IsHit - метод класса Point определяющий равенство координат
                food.sym = head.sym; //если точка совпадает с точкой головы, то змея есть
                pList.Add(food);
                return true;
            }
            else
                return false;
        }

    }
}
