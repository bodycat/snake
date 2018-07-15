using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figure
    {
// После добавления наследования необходимо заменить индетификатор доступа
//      List<Point> pList;
        protected List<Point> pList;
//      Чтобы pList была видна у наследников

        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
