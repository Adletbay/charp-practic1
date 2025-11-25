using System;

namespace project
{
    // <summary>
    // Класс для отрисовки верхней панели управления (меню)
    // Отображает основные разделы программы с подсветкой горячих клавиш
    // </summary>
    class Header
    {
        public Header()
        {
            Console.BackgroundColor = ConsoleColor.Blue;

            string[] words = { "Левая", "Файл", "Диск", "Команды", "Правая" };
            // Отрисовка каждого пункта меню с подсветкой первой буквы
            foreach (string word in words)
            {
                Console.Write(" ".PadLeft(5, ' ')); // Отступ между пунктами меню

                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] == word[0])
                    {
                        // Первая буква - желтая (горячая клавиша)
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(word[i]);
                        Console.ForegroundColor = ConsoleColor.Black; // Остальные буквы - черные
                    }

                    if (word[i] == word[0]) continue; Console.Write(word[i]); // Вывод остальных букв
                }
            }
            // Правая часть заголовка с информацией о размерах
            Console.Write(" ".PadLeft(26, ' '));
            Console.BackgroundColor = ConsoleColor.Cyan;
            //вывод реального времени
            DateTime currentTime = DateTime.Now;
            string timeString = currentTime.ToString("H mm");
            Console.WriteLine($" {timeString}");
        }
    }
}