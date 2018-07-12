using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Инкапсуляция - свойства классов скрывать детали своей реализации
// - Механизм языка, позволяющий ограничить доступ одних компонентов программы к другим;
// - Языковая конструкция, позволяющая связать данные с методами, предназначенными для обработки этих данных.
namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            HorizontalLine xline = new HorizontalLine(5,10,8,'+');
            xline.Drow();

            VerticalLine yline = new VerticalLine(13, 1, 5, '$');
            yline.Drow();

            Console.ReadLine();
        }
    }
}

// ДЗ - вертикальную линию