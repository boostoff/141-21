using System;

class Program
{
    static void Main()
    {
        // Определение размерностей ступенчатого массива
        int[][] jaggedArray = new int[5][];
        jaggedArray[0] = new int[5];
        jaggedArray[1] = new int[3];
        jaggedArray[2] = new int[8];
        jaggedArray[3] = new int[4];
        jaggedArray[4] = new int[6];

        // Инициализация генератора случайных чисел
        Random random = new Random();

        // Заполнение ступенчатого массива случайными числами в диапазоне от -500 до 500
        for (int i = 0; i < jaggedArray.Length; i++)
        {
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                jaggedArray[i][j] = random.Next(-500, 501); // Генерация случайного числа
            }
        }

        // Вывод ступенчатого массива и сумм элементов строк на экран
        Console.WriteLine("Ступенчатый массив и суммы элементов строк:");
        for (int i = 0; i < jaggedArray.Length; i++)
        {
            int rowSum = 0;
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.Write(jaggedArray[i][j] + "\t"); // Вывод элементов строки
                rowSum += jaggedArray[i][j]; // Вычисление суммы элементов строки
            }
            Console.WriteLine($"| Сумма строки: {rowSum}");
        }
    }
}
