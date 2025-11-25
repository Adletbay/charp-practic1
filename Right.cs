using System;
using System.Collections.Generic;

namespace project
{
    class Right
    {
        public Right(List<FileItem> files, int startX, int startY)
        {
            int leftMaxLines = 30;
            int maxLines = leftMaxLines / 3;
            int nameWidth = 12;
            int sizeWidth = 10;
            int dateWidth = 10;
            int timeWidth = 6;
            int y = startY;
            int x = 40;

            // Заголовок правой таблицы
            Console.SetCursorPosition(x, 1);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Cyan;

            string longPart = new string('\u2550', 12);
            string dataPart = new string('\u2550', 10);
            string shortPart = new string('\u2550', 2);
            string timePart = new string('\u2550', 6);

            Console.Write("\u2554" + longPart + "\u2564" + shortPart);
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write(" C:\\NC ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write("\u2564" + dataPart + "\u2564" + timePart + "\u2557");

            Console.SetCursorPosition(x, 2);
            string bPart = new string(' ', 5);

            Console.Write("\u2551");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("C:| Имя");
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.Write(bPart + "\u2502");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("  Размер ");
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.Write("\u2502");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("   Дата  ");
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.Write(" \u2502");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Время ");
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.Write("\u2551");

            // Вывод файлов
            for (int i = 0; i < Math.Min(files.Count, maxLines); i++)
            {
                string name = files[i].Name.Length > nameWidth ? files[i].Name.Substring(0, nameWidth - 2) + "~" : files[i].Name;
                var file = files[i];

                Console.SetCursorPosition(x, y);
                Console.Write("\u2551");
                Console.Write(name.PadRight(nameWidth));
                Console.Write("\u2502");

                Console.SetCursorPosition(x + nameWidth + 2, y);
                Console.Write(file.Size.ToString().PadLeft(sizeWidth - 1));
                Console.Write("\u2502");

                Console.SetCursorPosition(x + nameWidth + sizeWidth + 2, y);
                Console.Write(file.Modified.ToString("dd.MM.yyyy").PadRight(dateWidth));
                Console.Write("\u2502");

                Console.SetCursorPosition(x + nameWidth + sizeWidth + dateWidth + 3, y);
                Console.Write(file.Modified.ToString("HH:mm").PadLeft(timeWidth));
                Console.Write("\u2551");

                y++;
            }
            Console.SetCursorPosition(40, 13);
            string longPartD = new string('\u2500', 12);
            string dataPartD = new string('\u2500', 9);
            string shortPartD = new string('\u2500', 10);
            string timePartD = new string('\u2500', 6);
            string longD = new string('\u2550', 40);

            Console.Write("\u255F" + longPartD + "\u2534" + dataPartD + "\u2534" + shortPartD + "\u2534" + timePartD + "\u2562");
            Console.SetCursorPosition(40, 14);
            Console.Write("\u2551" + ".." + "           " + "\u2580" + "КАТАЛОГ" + "\u2580" + "  11.10.02   19:40" + "\u2551");
            Console.SetCursorPosition(40, 15);
            Console.Write("\u255A" + longD + "\u255D");
        }
    }
}