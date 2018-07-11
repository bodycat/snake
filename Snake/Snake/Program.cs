using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаём переменную типа Point, но так как Point это класс
            // То используется для создания экземпляров этого класса ключевое слово new
            // Синтаксическая особенность

            Point p1 = new Point();

            // Далее набираем название этой точки и показываем чему равняются атрибуты
            p1.x = 1;
            p1.y = 3;
            p1.sym = '*';

            p1.Draw();

            Point p2 = new Point();
            p2.x = 4;
            p2.y = 5;
            p2.sym = '#';

            p2.Draw();

            Console.ReadLine();
        }

        // Класс может состоять не только из данных
        // Но и из методов (функций)
        // Которые работают с этими данными
        // Спрячем функцию Draw внутри класса Point
        // Скажем что класс состоит из данных, 
        // Но ещё и из функции, которая орудует этими данными

        static void Draw(int x, int y, char sym)
        {
            
        }
    }
}
