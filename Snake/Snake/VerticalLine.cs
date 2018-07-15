using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine : Figure
    {
        // List<Point> pList; ушёл в Figure и берётся оттуда
        public VerticalLine(int x, int yDown, int yTop, char sym)
        {
            pList = new List<Point>();
            for (int y = yDown; y <= yTop; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
    }
}
