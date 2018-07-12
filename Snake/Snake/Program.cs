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
            Point p1 = new Point(1,3,'*');
            p1.Draw();
            
            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];

            foreach (int i in numList)
            {
                Console.WriteLine(i);
            }
            numList.RemoveAt(0);
            List<Point> PList = new List<Point>();
            PList.Add(p1);
            PList.Add(p2);

// Домашнее задание: свои списки с различными символами
// ASCII с 33 до 47 знака идут символы, дальше цифры и алфавит
            int a = 33;
//          int a = int.Parse(Console.ReadLine());
            int b = 47;
            //          int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Выводим символы из списка CharList:");
            List<Char> CharList = new List<Char>();
            for (int i = a; i <= b; i++)
            {
                CharList.Add((char)i);
            }
            foreach (Char item in CharList)
            Console.WriteLine(item + " - символ таблицы ASCII");
        Console.ReadKey();
        }
    }
}
