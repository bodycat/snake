using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine : Figure
// Горизонтальная линия наследуется от фигуры (частный случай)
    {
// После добавления наследования можно убрать следующее:
//      List<Point> pList;
        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        {
            pList = new List<Point>();
            for(int x = xLeft; x <= xRight; x++)
            {
//              После изменения идентификатора доступа в классе Figure обнаружим интересную вещь:
//              Из класса горизонтальной линии уехал метод Drow, pList 
//              Однако горизонтальная линия является частным случаем класса Figure
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
/* хороший пример перезаписи - Желтая граница
    public override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            foreach(Point p in pList)
            base.Draw();
            Console.ForegroundColor = ConsoleColor.White;
        }
*/
    }
}
