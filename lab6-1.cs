using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        // Чтение текста из файла
        string filePath = "input.txt";  // Укажите путь к вашему файлу
        string text = File.ReadAllText(filePath);

        // Разделение текста на предложения (используем регулярное выражение для учета точек, восклицательных и вопросительных знаков)
        string[] sentences = Regex.Split(text, @"(?<=[.!?])\s+");

        // Определение максимального количества знаков пунктуации в предложениях
        int maxPunctuationCount = sentences.Max(s => CountPunctuationMarks(s));

        // Вывод предложений с максимальным количеством знаков пунктуации
        Console.WriteLine("Предложения с максимальным количеством знаков пунктуации:");

        foreach (var sentence in sentences)
        {
            if (CountPunctuationMarks(sentence) == maxPunctuationCount)
            {
                Console.WriteLine(sentence);
            }
        }

        Console.WriteLine($"\nМаксимальное количество знаков пунктуации: {maxPunctuationCount}");
    }

    // Метод для подсчета количества знаков пунктуации в строке
    static int CountPunctuationMarks(string sentence)
    {
        char[] punctuationMarks = { '.', ',', ';', ':', '!', '?', '-', '(', ')', '[', ']', '{', '}', '"', '\'' };
        return sentence.Count(c => punctuationMarks.Contains(c));
    }
}
