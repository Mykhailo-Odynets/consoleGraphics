using consoleGraphics;

Graphics graphics = new Graphics(Console.LargestWindowWidth, Console.LargestWindowHeight, new char[] { 'T', 'd' });


graphics.Start();
graphics.Fall();



// Moving the cursor with the arrow keys and drawing an X
//int width = 120;
//int height = 30;
//int curentX = width / 2;
//int curentY = height / 2;
//Console.CursorVisible = false;
//ConsoleKeyInfo key;
//Console.SetCursorPosition(curentX, curentY);
//Console.Write('X');
//do
//{
//    key = Console.ReadKey(true);

//    if (key.Key == ConsoleKey.UpArrow)
//    {
//        if (curentY == 0) continue;
//        Console.SetCursorPosition(curentX, curentY--);
//        Console.Write(' ');
//        Console.SetCursorPosition(curentX, curentY);
//        Console.Write('X');
//    }
//    else if (key.Key == ConsoleKey.DownArrow)
//    {
//        if (curentY == height - 1) continue;
//        Console.SetCursorPosition(curentX, curentY++);
//        Console.Write(' ');
//        Console.SetCursorPosition(curentX, curentY);
//        Console.Write('X');
//    }
//    else if (key.Key == ConsoleKey.LeftArrow)
//    {
//        if (curentX == 0) continue;
//        Console.SetCursorPosition(curentX--, curentY);
//        Console.Write(' ');
//        Console.SetCursorPosition(curentX, curentY);
//        Console.Write('X');
//    }
//    else if (key.Key == ConsoleKey.RightArrow)
//    {
//        if (curentX == width - 1) continue;
//        Console.SetCursorPosition(curentX++, curentY);
//        Console.Write(' ');
//        Console.SetCursorPosition(curentX, curentY);
//        Console.Write('X');
//    }
//} while (key.Key != ConsoleKey.X);