using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;
          
        public Point()
        {
        }
        // Конструкторы - методы, с  помощью которых создаём различные точки
        public Point(int x, int y, char sym)
        {
            //this
            this.x = x;
            this.y = y;
            this.sym = sym;
        }
        // Методы, которые можем вызывать для каждой конкретной точки

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void Move(int offset, Direction direction)
        {
            if(direction == Direction.RIGHT)
            {
                x = x + offset;
            }
            else if(direction == Direction.LEFT)
            {
                x = x - offset;
            }
            else if (direction == Direction.UP)
            {
                y = y - offset;
            }
            else if (direction == Direction.DOWN)
            {
                y = y + offset;
            }
        }

        // Добавили IsHit
        public bool IsHit(Point p)
		{
			return p.x == this.x && p.y == this.y;
		}

        public void Draw()
        {
            //нужно проверку поставить на выход из границ
            Console.SetCursorPosition(x, y);
            Console.Write( sym );
        }

        public void Clear()
        {
            sym = ' ';
            Draw();
        }
/* Перекинули в класс Figure
        public bool IsHit(Point p)
        // Проверка, есть ли пересечения текущей точки 
        {
            return p.x == this.x && p.y == this.y;
        }
*/
        public override string ToString()
        {
            // return base.ToString();
            // c# магия
            return x + ", " + y + ", " + sym;
        }
    }
}

// Класс -> экземпляр (объект) 