using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//чтобы задержка Thread.Sleep работала подключаем директиву
using System.Threading;
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
            // размер буфера не меньше размера консоли и не больше int64
            Console.SetBufferSize( 150, 150);
            /*
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
            */
            // HELLO итд

            /*
            Employee e = new Employee();
            e.age = 42;
            e.pay = 30000; */

            //Отрисовка рамки
            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '$');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '$');
            VerticalLine leftLine = new VerticalLine(0, 0, 24, '$');
            VerticalLine rightLine = new VerticalLine(78, 0, 24, '$');
            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();

            // Отрисовка точек
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake( p, 4, Direction.RIGHT );
            snake.Draw();
            // Опишем метод, позволяющий отслеживать точки (магия C#)
            snake.Move();
            Thread.Sleep(300);
            snake.Draw();
            snake.Move();
            Thread.Sleep(300);
            snake.Draw();
            snake.Move();
            Thread.Sleep(300);
            snake.Draw();
            snake.Move();
            Thread.Sleep(300);

            while(true)
            {
                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.LeftArrow)
                        //доступа к direction до public в Snake не было
                        snake.direction = Direction.LEFT;
                    else if (key.Key == ConsoleKey.RightArrow)
                        snake.direction = Direction.RIGHT;
                    else if (key.Key == ConsoleKey.DownArrow)
                        snake.direction = Direction.DOWN;
                    else if (key.Key == ConsoleKey.UpArrow)
                        snake.direction = Direction.UP;
                }
                Thread.Sleep(100);
                snake.Move();
            }
//Console.ReadLine();
        }
    }
}

// ДЗ - нет