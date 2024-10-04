using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Ввод текста, который заканчивается точкой
        Console.WriteLine("Введите текст, заканчивающийся точкой:");
        string input = Console.ReadLine();

        // Удаление точки для анализа слов, затем вернём её обратно
        string textWithoutDot = input.TrimEnd('.');

        // Разделение текста на слова (учитываем, что слова разделены пробелами и запятыми)
        string[] words = textWithoutDot.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

        // Определение длины самого длинного слова
        int maxWordLength = words.Max(word => word.Count(char.IsLetter));

        // Вывод числа К (длина самого длинного слова)
        Console.WriteLine($"К (длина самого длинного слова): {maxWordLength}");

        // Шифрование текста
        string encryptedText = EncryptText(input, maxWordLength);

        // Вывод зашифрованного текста
        Console.WriteLine("Зашифрованный текст:");
        Console.WriteLine(encryptedText);
    }

    // Метод для шифрования текста
    static string EncryptText(string input, int shift)
    {
        char[] encryptedChars = input.ToCharArray();

        for (int i = 0; i < encryptedChars.Length; i++)
        {
            char currentChar = encryptedChars[i];

            // Шифрование только английских букв
            if (char.IsLetter(currentChar))
            {
                if (char.IsUpper(currentChar))
                {
                    // Для заглавных букв (A-Z)
                    encryptedChars[i] = (char)((currentChar - 'A' + shift) % 26 + 'A');
                }
                else if (char.IsLower(currentChar))
                {
                    // Для строчных букв (a-z)
                    encryptedChars[i] = (char)((currentChar - 'a' + shift) % 26 + 'a');
                }
            }
        }

        return new string(encryptedChars);
    }
}
