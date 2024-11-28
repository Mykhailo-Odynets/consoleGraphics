using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleGraphics
{
    internal class Point
    {
        public Point(int x, int y, char symbol, ConsoleColor color, bool isActive = false)
        {
            if (x < 0 || y < 0)
            {
                throw new ArgumentOutOfRangeException("Wrong Point parameters");
            }
            X = x;
            Y = y;
            Symbol = symbol;
            Color = color;
            IsActive = isActive;
        }

        public int X { get; set; }
        public int Y { get; set; }
        public char Symbol { get; set; }
        public bool IsActive { get; set; }
        public ConsoleColor Color { get; set; }
        public void Draw(bool clear = false)
        {
            if (!IsActive) return;
            Console.SetCursorPosition(X, Y);
            Console.ForegroundColor = Color;
            Console.Write(!clear ? Symbol : " ");
        }
    }
}
