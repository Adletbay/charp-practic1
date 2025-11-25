using System;
using System.Collections.Generic;

namespace project
{

    // Класс для отрисовки левой панели файлового менеджера
    // Отображает файлы в виде компактного списка (3 колонки)
    // Использует псевдографику для создания рамок

    class Left
    {
        public Left(List<FileItem> files, int startX, int startY)
        {
            int maxLines = 30; // Максимальное количество строк для отображения
            int columns = 3; // Количество колонок для компактного отображения
            int nameWidth = 12; // Ширина колонки для имени файла

            // Вывод заголовка дисков и отрисовка загаловка левой панели с псевдографикой
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Cyan;
            string longPart = new string('\u2550', 12);  
            string shortPart = new string('\u2550', 2);
            Console.WriteLine("\u2554" + longPart + "\u2564" + shortPart + " C:\\NC " + "\u2550" + shortPart + "\u2564" + longPart + "\u2557");

            string firstPart = new string(' ', 4);
            string secondPart = new string(' ', 5);

            Console.Write("\u2551");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("C:| Имя");
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.Write(secondPart + "\u2502" + firstPart);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Имя");
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.Write(secondPart + "\u2502" + firstPart);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Имя");
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.Write(secondPart + "\u2551");
            Console.ForegroundColor = ConsoleColor.Cyan;

            // Вывод файлов
            for (int i = 0; i < Math.Min(files.Count, maxLines); i++)
            {
                string name = files[i].Name.Length > nameWidth ? files[i].Name.Substring(0, nameWidth - 2) + "~" : files[i].Name;
                int row = i / columns;
                int col = i % columns;

                Console.SetCursorPosition(0, startY + row);
                Console.Write("\u2551");

                int x = startX + col * (nameWidth + 1);
                Console.SetCursorPosition(x, startY + row);
                Console.Write(name.PadRight(nameWidth));
                Console.Write("\u2502");

                Console.SetCursorPosition(39, startY + row);
                Console.Write("\u2551");
            }
            // Нижняя часть панели с информацией о каталоге
            Console.SetCursorPosition(0, 13); 
            string longPartD = new string('\u2500', 12);
            string longD = new string('\u2550', 38);
            Console.Write("\u255F" + longPartD + "\u2534" + longPartD + "\u2534" + longPartD + "\u2562");
            Console.SetCursorPosition(0, 14);
            Console.Write("\u2551" + ".." + "           " + "\u2580" + "КАТАЛОГ" + "\u2580" + " 11.10.02  19:40" + "\u2551");
            Console.SetCursorPosition(0, 15);
            Console.Write("\u255A" + longD + "\u255D");
        }
    }
}