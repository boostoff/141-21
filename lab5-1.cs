using System;

class Program
{
    static void Main()
    {
        // Исходная строка
        string input = "язык программирования C#";

        // Вывод исходной строки
        Console.WriteLine("Исходная строка:");
        Console.WriteLine(input);

        // Разделение строки на слова
        string[] words = input.Split(' ');

        // Изменение порядка слов на зеркальный
        Array.Reverse(words);

        // Соединение слов обратно в строку
        string reversedWords = string.Join(" ", words);

        // Вывод строки с зеркальным порядком слов
        Console.WriteLine("\nСтрока с зеркальным порядком слов:");
        Console.WriteLine(reversedWords);

        // Вывод строки в обратном порядке символов
        char[] charArray = reversedWords.ToCharArray();
        Array.Reverse(charArray);
        string reversedChars = new string(charArray);

        // Вывод результата
        Console.WriteLine("\nСтрока в обратном порядке символов:");
        Console.WriteLine(reversedChars);
    }
}
