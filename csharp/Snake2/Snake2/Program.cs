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
                /*Console.ReadLine();*/
            }
        }
    }
}