using System;

namespace project
{
   
    // Класс для отрисовки нижней панели (футера)
    // Содержит командную строку и панель функциональных клавиш
 
    class Footer
    {
        public Footer()
        {
            Console.ResetColor();
            Console.SetCursorPosition(0, 16); // Установка курсора в позицию для командной строки
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("C:\\NC>"); // Место где пользователь что то типо вводит

            // Ряд F-ок (F1-F10)
            string[] words = { "1Помощь ", "2Вызов ", "3Чтение ", "4Правка ", "5Копия ", "6НовИмя", "7НовКат", "8Удал-е", "9Меню  ", "0Выход " };

            // Отрисовка каждой функциональной клавиши с подсветкой цифры
            foreach (string word in words)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] == word[0]) // Если это первая буква (цифра)
                    {
                        // Цифра - белая на черном фоне (выделение)
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write(word[i]);
                        // Остальной текст - черный на голубом фоне
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.Cyan;
                    }

                    if (word[i] == word[0]) continue; // Пропускаем первую букву (уже вывели)
                    Console.Write(word[i]);
                }
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" ");
            }
            // Возврат курсора в командную строку для ввода
            Console.SetCursorPosition(6, 16);
        }
    }
}