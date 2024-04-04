using System;
using System.IO;
using System.Windows.Forms; // Добавляем пространство имен для работы с Windows Forms

namespace Toodet_Dotskin
{
    internal class Kvitung
    {
        public Kvitung(string productName, double price, string folderPath)
        {
            string checkContent = $"Товар: {productName}\nЦена: {price}";

            try
            {
                // Создаем уникальное имя для файла на основе текущей даты и времени
                string fileName = $"Check_{DateTime.Now:yyyyMMddHHmmss}.txt";

                // Полный путь к файлу
                string filePath = Path.Combine(folderPath, fileName);

                // Записываем чек в файл
                File.WriteAllText(filePath, checkContent);

                Console.WriteLine($"Чек успешно создан и сохранен в файл: {filePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при создании чека и сохранении файла: {ex.Message}");
            }
        }
    }
}