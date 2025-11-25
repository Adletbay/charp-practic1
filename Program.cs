using System;
using System.Collections.Generic;

namespace project
{
    // Главный класс программы - точка входа в приложение
    // Координирует создание и отрисовку всех компонентов файлового менеджера
    class ConsoleWindow
    {
        static void Main()
        {
            // Основной цвет консоли
            Console.BackgroundColor = ConsoleColor.DarkBlue;

            // Размер окна
            int width = 82;
            int height = 25;
            Console.SetWindowSize(width, height);

            // Получаем список файлов из отдельного класса
            List<FileItem> files = FileList.GetFiles();

            //начальныек координаты для отрисовки
            int startX = 1;
            int startY = 3;

            // Реализация заголовока
            Header header = new Header();

            // Реализация файлов
            Left left = new Left(files, startX, startY);
            Right right = new Right(files, startX, startY);

            // Реализация футера
            Footer footer = new Footer();

            Console.ReadKey();
        }
    }
}