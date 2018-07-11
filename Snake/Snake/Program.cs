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
            // Эта запись является недочётом, который мы удалим в следующем уроке
            int x1 = 1;
            int y1 = 3;
            char sym1 = '*';

            Draw(x1, y1, sym1);

            int x2 = 4;
            int y2 = 5;
            char sym2 = '#';

            Draw(x2, y2, sym2);

            Console.ReadLine();
        }

        // Повторяющиеся куски кода выводятся в отдельные функции
        // Таким образом программа становится проще
        static void Draw(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
