using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake2
{
    class Program
    {
        static void Main(string[] args)
        {
            VerticalLine vl = new VerticalLine(0, 10, 5, '%');
            Draw(vl);

            Point p = new Point(4, 5, 'O');
            Figure fsnake = new Snake (p, 4, Directions.RIGHT);
            Draw(fsnake);
            Snake snake = (Snake)fsnake;    //приведение типа

            HorizontalLine hl = new HorizontalLine(0, 5, 6, '&');

            List<Figure> figures = new List<Figure>();
            figures.Add(fsnake);
            figures.Add(vl);
            figures.Add(hl);

            foreach(var f in figures)
            {
                f.Draw();
            }

            /*
            Console.SetBufferSize(80, 25);
            //рисуем границы
            HorizontalLine uLine = new HorizontalLine(0, 79, 1, '@');
            HorizontalLine dLine = new HorizontalLine(0, 79, 24, '@');
            VerticalLine lLine = new VerticalLine(0, 1, 23, '@');
            VerticalLine rLine = new VerticalLine(79, 1, 23, '@');
            uLine.Draw();
            dLine.Draw();
            lLine.Draw();
            rLine.Draw();

            Point pStart = new Point(4, 5, 'O');
            Snake snake = new Snake(pStart, 4, Directions.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();


            while (true)
            {
                if (snake.Eat(food))
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
                    snake.HandleKey(key.Key);
                }
                */
            /*Console.ReadLine();*/
        }
        static void Draw(Figure figure)
        {
            figure.Draw();
        }
    }
}