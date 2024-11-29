using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleGraphics
{
    internal class Graphics
    {
        public Graphics(int width = 120, int height = 30, char[] symbols = null)
        {
            if (width <= 0 || height <= 0)
            {
                throw new ArgumentOutOfRangeException("Wrong Graphics parameters");
            }
            if (width > Console.LargestWindowWidth)
            {
                width = Console.LargestWindowWidth;
            }
            if (height > Console.LargestWindowHeight)
            {
                height = Console.LargestWindowHeight;
            }
            if (symbols == null)
            {
                symbols = new char[] { '.', 'a', '@'};
                //symbols = new char[] { 'T', 'd' };
            }
            Symbols = symbols;
            Width = width;
            Height = height;
            Buffer = new Point[Width];
        }

        public int Width { get; set; }
        public int Height { get; set; }
        public int BufferSize => Buffer.Length;
        public char[] Symbols { get; set; }
        public Point[] Buffer { get; init; }

        public void Start()
        {
            Console.CursorVisible = false;
            Console.SetBufferSize(Width, Height);
            Console.SetWindowSize(Width, Height);

            for (int i = 0; i < BufferSize; i++)
            {
                Buffer[i] = new Point(i % Width, 0, Symbols[Random.Shared.Next(Symbols.Length)], (ConsoleColor)Random.Shared.Next(16));
            }
        }
        public void ClearBuffer()
        {
            foreach (var point in Buffer)
            {
                point.Draw(clear: true);
            }
        }
        public void DrawBuffer()
        {
            foreach (var point in Buffer)
            {
                point.Draw();
            }
        }
        public void Fall()
        {
            while (true)
            {
                Point currentPoint;
                for (int x = 0; x < BufferSize / Width; x++)
                {
                    int i = 0;
                    do
                    {
                        currentPoint = Buffer[Random.Shared.Next(BufferSize)];
                        i++;
                    } while (currentPoint.IsActive && i < BufferSize);
                    currentPoint.IsActive = true;
                }

                foreach (var point in Buffer)
                {
                    if (point.IsActive)
                    {
                        Console.SetCursorPosition(point.X, point.Y);
                        Console.Write(" ");
                        point.Y++;
                    }
                    if (point.Y == Height)
                    {
                        point.IsActive = false;
                        point.Y = 0;
                        point.X = Random.Shared.Next(Width);
                        point.Symbol = Symbols[Random.Shared.Next(Symbols.Length)];
                        point.Color = (ConsoleColor)Random.Shared.Next(16);
                    }
                }

                //ClearBuffer();
                DrawBuffer();
                //Thread.Sleep(10);
            }
        }
    }
}
