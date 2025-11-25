// <summary>
// Класс для представления файла в файловой системе
// Содержит основные свойства: имя, размер и дата изменения
// </summary>
namespace project
{
    class FileItem
    {
        public string Name { get; set; }
        public int Size { get; set; }
        public DateTime Modified { get; set; }
    }
}