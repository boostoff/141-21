using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Инициализация массива вещественных чисел
        double[] array = { 1.2, -3.5, 0.0, -1.1, 0.0, -4.7, 3.0, -5.0 };

        // Вывод массива на экран
        Console.WriteLine("Массив:");
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        // Подсчет количества элементов, равных нулю
        int zeroCount = array.Count(x => x == 0);

        // Вычисление суммы отрицательных нечетных элементов массива
        double sumNegativeOdd = array
            .Where(x => x < 0 && Math.Abs(x) % 2 == 1) // Фильтрация отрицательных нечетных чисел
            .Sum();

        // Вывод результатов
        Console.WriteLine($"\nКоличество элементов массива, равных нулю: {zeroCount}");
        Console.WriteLine($"Сумма отрицательных нечетных элементов массива: {sumNegativeOdd}");
    }
}
