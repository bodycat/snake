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
        // public Direction direction;
        // Вернули код HandleKey в класс Snake, убираем public
        Direction direction;

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
            // Текущая позиция головы змейки
            Point head = pList.Last();
            // Создаем новую точку, копия предыдущего положения головы
            Point nextPoint = new Point(head);
            // Двигаем точку по направлению дирекшн
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        internal bool IsHitTail()
		{
			var head = pList.Last();
			for(int i = 0; i < pList.Count - 2; i++ )
			{
				if ( head.IsHit( pList[ i ] ) )
					return true;
			}
			return false;
		}

        public void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                // Доступа к direction до public в Snake не было
                direction = Direction.LEFT;
            else if (key == ConsoleKey.RightArrow)
                direction = Direction.RIGHT;
            else if (key == ConsoleKey.DownArrow)
                direction = Direction.DOWN;
            else if (key == ConsoleKey.UpArrow)
                direction = Direction.UP;
        }

        internal bool Eat( Point food)
        {
            Point head = GetNextPoint();
            if ( head.IsHit( food ) )
            {
                // if(head.x == food.x && head.y ==food.y)
                // Эта проверка в ответственности класса точка
                // Акт питания, если точка совпадает с головой змеи
                food.sym = head.sym;
                pList.Add( food );
                return true;
            }
            else
                return false;
        }
    }
}
