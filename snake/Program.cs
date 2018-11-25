using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            //Полиморфизм****************************************************************
            //Vert_Line v1 = new Vert_Line(0, 10, 5, '%');
            //Draw(v1);

            //Point p = new Point(4, 5, '*');
            //Figure fSnake = new Snake(p, 4, Direction.RIGHT);
            //Draw(fSnake);
            //Snake snake = (Snake)fSnake; //Явное приведение типа, говоря, что fSnake принадлежит классу Snake и мы можем пользоваться методами класса snake для fSnake

            //Horiz_Line h1 = new Horiz_Line(0, 5, 6, '&');

            //List<Figure> figures = new List<Figure>();
            //figures.Add(fSnake);
            //figures.Add(v1);
            //figures.Add(h1);

            //foreach(var f in figures)
            //{
            //    f.Draw();
            //}
            //exit_Полиморфизм****************************************************************


            //Point p1 = new Point(1,3,'*');
            //p1.Draw();

            //Point p2 = new Point(4,5,'#');
            //p2.Draw();

            //Horiz_Line Hline = new Horiz_Line(5,10,8,'+');
            //Hline.Drow();

            //Vert_Line Vline = new Vert_Line(10, 20, 10, '+');
            //Vline.Drow();

            Console.SetBufferSize(120, 30);


            Walls.walls = new Walls(120, 30);
            walls.Draw();



            //Отрисовка точек
            Point p = new Point(1, 3, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            //Отрисовка еды
            FoodCreator foodCreator = new FoodCreator(120, 30, '?');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while(true) //Бесконечный цикл: код в скобках выполняется "вечно"
            {
                if(Walls.IsHit(snake)||snake.IsHitTail())
                {
                    break;
                }

                if (snake.Eat(food)) //встретит ли змея еду или нет
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key); //Вызов метода из класса snake
                }
                Thread.Sleep(100);
                snake.Move();

                
            }

         
        }

        static void Draw(Figure figure)
        {
            figure.Draw();
        }


    }
}
