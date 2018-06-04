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

            while(true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    /*
                    if (key.Key == ConsoleKey.LeftArrow)
                        snake.direction = Directions.LEFT;
                    else if (key.Key == ConsoleKey.RightArrow)
                        snake.direction = Directions.RIGHT;
                    else if (key.Key == ConsoleKey.DownArrow)
                        snake.direction = Directions.DOWN;
                    else if (key.Key == ConsoleKey.UpArrow)
                        snake.direction = Directions.UP;
                    */
                    snake.HandleKey(key.Key);
                }
                Thread.Sleep(300);  // 300мс
                snake.Move();
            }
            /*Console.ReadLine();*/
        }
    }
}