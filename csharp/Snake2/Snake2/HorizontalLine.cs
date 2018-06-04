using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake2
{
    class HorizontalLine : Figure
    {
        //List<Point> pList;

        public HorizontalLine(int xL, int xR, int y, char sym)
        {
            pList = new List<Point>();
            
            for(int x = xL; x <= xR; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
        
        public override void Draw() //override переопределение метода
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            /*foreach(Point p in pList)
            {
                p.Draw();
            }*/

            base.Draw();

            Console.ForegroundColor = ConsoleColor.White;
        }
        
    }
}
