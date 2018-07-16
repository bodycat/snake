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
            Console.SetBufferSize( 130, 130);

            //Отрисовка рамки
            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '#');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '#');
            VerticalLine leftLine = new VerticalLine(0, 0, 24, '#');
            VerticalLine rightLine = new VerticalLine(78, 0, 24, '#');
            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();

            // Отрисовка точек
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake( p, 4, Direction.RIGHT );
            snake.Draw();
            // Опишем метод, позволяющий отслеживать точки (магия C#)

            // Добавили появление еды на карте
            FoodCreator foodCreator = new FoodCreator(78, 24, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                // True or False (возвращает бинарное значение)
                if(snake.Eat( food ) )
                {
                    food = foodCreator.CreateFood();
                    //food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }

            }
            /*
            while(true)
            {
                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                Thread.Sleep(100);
                snake.Move();
            }
            */
//Console.ReadLine();
        }
    }
}

// ДЗ - нет