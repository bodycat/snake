﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Класс - такой же тип данных как числа или символы
namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point()
        {
            Console.WriteLine("Создаёся новая точка");
        }

        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }
          
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write( sym );
        }
    }
}
