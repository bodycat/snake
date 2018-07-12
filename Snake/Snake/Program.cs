using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// ООП

// Инкапсуляция - свойства классов скрывать детали своей реализации
// - Механизм языка, позволяющий ограничить доступ одних компонентов программы к другим;
// - Языковая конструкция, позволяющая связать данные с методами, предназначенными для обработки этих данных.

// Наследование - свойство системы, позволяющее описать новый класс на основе уже существующего
// Частично или полностью замещающйся функциональностью

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize( 800, 600);
            Point p1 = new Point(1, 1, '*');
            p1.Draw();
            Point p2 = new Point(2, 1, '#');
            p2.Draw();
            HorizontalLine x1line = new HorizontalLine(5,10,7,'+');
            x1line.Drow();
            VerticalLine y1line = new VerticalLine(5, 5, 10, '$');
            y1line.Drow();
            VerticalLine y2line = new VerticalLine(10, 5, 10, '$');
            y2line.Drow();
            // HELLO итд

            Employee e = new Employee();
            e.age = 42;
            e.pay = 30000;

            Console.ReadLine();
        }
    }
}

// ДЗ - нет