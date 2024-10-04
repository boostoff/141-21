using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        // Путь к входному и выходному файлам
        string inputFilePath = "input.txt";   // Укажите путь к вашему входному файлу
        string outputFilePath = "output.txt"; // Укажите путь к вашему выходному файлу

        // Словарь для хранения профилей и количества вузов по каждому профилю
        Dictionary<string, int> profileCounts = new Dictionary<string, int>();

        // Чтение данных из файла
        try
        {
            string[] lines = File.ReadAllLines(inputFilePath);

            foreach (var line in lines)
            {
                // Разделение строки по запятой для получения названия вуза и профиля
                string[] parts = line.Split(',');

                if (parts.Length == 2)
                {
                    string profile = parts[1].Trim(); // Получаем профиль, убираем пробелы

                    // Увеличиваем счетчик для данного профиля
                    if (profileCounts.ContainsKey(profile))
                    {
                        profileCounts[profile]++;
                    }
                    else
                    {
                        profileCounts[profile] = 1;
                    }
                }
            }

            // Запись результата в выходной файл
            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                foreach (var profile in profileCounts)
                {
                    writer.WriteLine($"{profile.Key}: {profile.Value} вуз(а/ов)");
                }
            }

            Console.WriteLine("Программа успешно завершена. Результаты записаны в файл output.txt.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка при обработке файла: " + ex.Message);
        }
    }
}
