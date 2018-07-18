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
// Создали виртуал, любой наследник может переопределить его и написать свою версию Draw
        public virtual void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }

        internal bool IsHit( Figure figure )
        {
            foreach( var p in pList)
            {
                if ( figure.IsHit( p ))
                    return true;
            }
            return false;
        }

		private bool IsHit( Point point )
		{
			foreach(var p in pList)
			{
				if ( p.IsHit( point ) )
					return true;
			}
			return false;
		}
    }
}
