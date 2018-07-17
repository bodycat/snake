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

// Инкапсуляция - упаковка данных или функций в единый компонент (классы)
// обьединяет данный код и защищает от внешнего вмешательства и неправильного использования

// Наследование - свойство системы, позволяющее описать новый класс на основе уже существующего
// Частично или полностью замещающйся функциональностью

// Наследование позволяет создавать новые классы, которые повторно используют, 
// расширяют и изменяют поведение определенных других классов (Фигура - вертикал лайн, снейк итд)

// Полиморфизм - многообразие форм, имеющие несколько аспектов
// Во время выполнения выполнения производного класса могут рассматриваться как 
// объекты выполнения базового класса в таких местах как:
// параметры метода, коллекции или массивы
// когда это происходит объявленный тип объекта перестаёт соответствовать своему типу во время выполнения

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            //VerticalLine v1 = new VerticalLine(0, 0, 24, '%');
            //Draw(v1);

            Console.SetBufferSize( 130, 130);
            Walls walls = new Walls(80, 25);
            walls.Draw();

            // размер буфера не меньше размера консоли и не больше int64

            // Отрисовка точек
            Point p = new Point(4, 5, '*');
            //Snake snake = new Snake( p, 4, Direction.RIGHT );
            //snake.Draw();
            Figure Snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(78, 24, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (walls.IsHit(snake) || Snake.IsHitTail)
                {
                    break;
                }
                if(snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
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

            List<Figure> figures = new List<Figure>();
            figures.Add(fSnake);
            figures.Add(v1);
            figures.Add(h1);

            foreach (var f in figures)
            {
                f.Draw();
            }
        }

            static void Draw( Figure figure)
            {
                figure.Draw();
            }

        // Добавили появление еды на карте
        /*
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
    }
    */
    }
}

// ДЗ - нет