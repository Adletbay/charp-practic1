using System;
using System.Collections.Generic;

namespace project
{
    // <summary>
    // Статический класс для хранения тестовых данных о файлах
    // Используется для демонстрации работы программы без реальной файловой системы
    // </summary>

    static class FileList
    {
        // <summary>
        // Возвращает предопределенный список файлов для демонстрации
        // В реальном приложении здесь могло бы быть чтение из файловой системы
        // </summary>
        public static List<FileItem> GetFiles()
        {
            return new List<FileItem>()
            {
                // Каждый FileItem представляет собой файл с различными расширениями
                // Размеры и даты подобраны для реалистичного отображения
                new FileItem { Name = "Report.docx", Size = 2345, Modified = new DateTime(2025, 09, 22, 14, 30, 0) },
                new FileItem { Name = "Presentation.pptx", Size = 5678, Modified = new DateTime(2025, 09, 20, 10, 15, 0) },
                new FileItem { Name = "Data.xlsx", Size = 1024, Modified = new DateTime(2025, 09, 19, 9, 0, 0) },
                new FileItem { Name = "Image1.png", Size = 345, Modified = new DateTime(2025, 09, 18, 16, 45, 0) },
                new FileItem { Name = "Image2.jpg", Size = 789, Modified = new DateTime(2025, 09, 21, 11, 20, 0) },
                new FileItem { Name = "Video.mp4", Size = 12345, Modified = new DateTime(2025, 09, 17, 8, 10, 0) },
                new FileItem { Name = "Script.cs", Size = 234, Modified = new DateTime(2025, 09, 16, 13, 55, 0) },
                new FileItem { Name = "Archive.zip", Size = 4567, Modified = new DateTime(2025, 09, 15, 19, 30, 0) },
                new FileItem { Name = "Notes.txt", Size = 123, Modified = new DateTime(2025, 09, 14, 7, 5, 0) },
                new FileItem { Name = "Diagram.vsdx", Size = 678, Modified = new DateTime(2025, 09, 13, 15, 40, 0) },
                new FileItem { Name = "Project.csproj", Size = 890, Modified = new DateTime(2025, 09, 12, 12, 0, 0) },
                new FileItem { Name = "Music.mp3", Size = 3456, Modified = new DateTime(2025, 09, 11, 20, 15, 0) },
                new FileItem { Name = "Backup.bak", Size = 5678, Modified = new DateTime(2025, 09, 10, 9, 50, 0) },
                new FileItem { Name = "Config.json", Size = 234, Modified = new DateTime(2025, 09, 9, 14, 25, 0) },
                new FileItem { Name = "Readme.md", Size = 123, Modified = new DateTime(2025, 09, 8, 18, 10, 0) },
                new FileItem { Name = "Test1.cs", Size = 345, Modified = new DateTime(2025, 09, 7, 10, 0, 0) },
                new FileItem { Name = "Test2.cs", Size = 678, Modified = new DateTime(2025, 09, 6, 11, 15, 0) },
                new FileItem { Name = "Log1.log", Size = 123, Modified = new DateTime(2025, 09, 5, 16, 45, 0) },
                new FileItem { Name = "Log2.log", Size = 456, Modified = new DateTime(2025, 09, 4, 9, 30, 0) },
                new FileItem { Name = "Draft.docx", Size = 789, Modified = new DateTime(2025, 09, 3, 14, 5, 0) },
                new FileItem { Name = "Example.pptx", Size = 2345, Modified = new DateTime(2025, 09, 2, 8, 40, 0) },
                new FileItem { Name = "Template.xlsx", Size = 1024, Modified = new DateTime(2025, 09, 1, 19, 20, 0) },
                new FileItem { Name = "Photo1.png", Size = 345, Modified = new DateTime(2025, 08, 31, 13, 15, 0) },
                new FileItem { Name = "Photo2.jpg", Size = 678, Modified = new DateTime(2025, 08, 30, 7, 50, 0) },
                new FileItem { Name = "Video2.mp4", Size = 12345, Modified = new DateTime(2025, 08, 29, 22, 10, 0) },
                new FileItem { Name = "Script2.cs", Size = 234, Modified = new DateTime(2025, 08, 28, 11, 35, 0) },
                new FileItem { Name = "Archive2.zip", Size = 4567, Modified = new DateTime(2025, 08, 27, 17, 5, 0) },
                new FileItem { Name = "Notes2.txt", Size = 123, Modified = new DateTime(2025, 08, 26, 9, 20, 0) },
                new FileItem { Name = "Diagram2.vsdx", Size = 678, Modified = new DateTime(2025, 08, 25, 15, 50, 0) },
                new FileItem { Name = "Project2.csproj", Size = 890, Modified = new DateTime(2025, 08, 24, 12, 30, 0) }
            };
        }
    }
}