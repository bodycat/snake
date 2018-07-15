using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Абстрагирование - способ выделить набор значимых характеристик объекта,
// Исключая из рассмотрения незначимые
namespace Snake
    
{
    // Наша змейка должна уметь двигаться, кушать, врезаться ит.д.
    class Snake : Figure 
    {
        // На этом уроке меняем модификатор доступа, добавив паблики
        public Direction direction;
        public Snake(Point tail, int length, Direction _direction)
        {
            direction = _direction;
            pList = new List<Point>();
            for(int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }

        public Point GetNextPoint()
        {
            // текущая позиция головы змейки
            Point head = pList.Last();
            // создаем новую точку, копия предыдущего положения головы
            Point nextPoint = new Point(head);
            // двигаем точку по направлению дирекшн
            nextPoint.Move(1, direction);
            return nextPoint;
        }
    }
}
