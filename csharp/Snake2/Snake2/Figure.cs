using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake2
{
    class Figure
    {
        protected List<Point> pList;

        public virtual void Draw()  //virtual позволяет переопределять метод Draw
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
