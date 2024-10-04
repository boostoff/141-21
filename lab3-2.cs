using System;

class Program
{
    static void Main()
    {
        // ÐÐ½Ð¸ÑÐ¸Ð°Ð»Ð¸Ð·Ð°ÑÐ¸Ñ ÐºÐ²Ð°Ð´ÑÐ°ÑÐ½Ð¾Ð¹ Ð¼Ð°ÑÑÐ¸ÑÑ (2D Ð¼Ð°ÑÑÐ¸Ð²Ð°)
        int[,] matrix = {
            { 1, 4, 3, 2 },
            { 2, 5, 8, 7 },
            { 1, 2, 3, 4 },
            { 9, 8, 7, 6 }
        };

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        // ÐÑÐ²Ð¾Ð´ Ð¸ÑÑÐ¾Ð´Ð½Ð¾Ð¹ Ð¼Ð°ÑÑÐ¸ÑÑ Ð½Ð° ÑÐºÑÐ°Ð½
        Console.WriteLine("ÐÑÑÐ¾Ð´Ð½Ð°Ñ Ð¼Ð°ÑÑÐ¸ÑÐ°:");
        PrintMatrix(matrix);

        // ÐÐ¿ÑÐµÐ´ÐµÐ»ÐµÐ½Ð¸Ðµ ÑÑÑÐ¾ÐºÐ¸ Ñ ÑÐ°Ð¼Ð¾Ð¹ Ð´Ð»Ð¸Ð½Ð½Ð¾Ð¹ Ð²Ð¾Ð·ÑÐ°ÑÑÐ°ÑÑÐµÐ¹ Ð¿Ð¾ÑÐ»ÐµÐ´Ð¾Ð²Ð°ÑÐµÐ»ÑÐ½Ð¾ÑÑÑÑ
        int maxLength = 0;
        int rowWithMaxSequence = -1;

        for (int i = 0; i < rows; i++)
        {
            int currentLength = 1; // ÐÐ°ÑÐ°Ð»ÑÐ½Ð°Ñ Ð´Ð»Ð¸Ð½Ð° Ð¿Ð¾ÑÐ»ÐµÐ´Ð¾Ð²Ð°ÑÐµÐ»ÑÐ½Ð¾ÑÑÐ¸
            int maxCurrentRowLength = 1;

            for (int j = 1; j < cols; j++)
            {
                if (matrix[i, j] > matrix[i, j - 1])
                {
                    currentLength++;
                    maxCurrentRowLength = Math.Max(maxCurrentRowLength, currentLength);
                }
                else
                {
                    currentLength = 1;
                }
            }

            // ÐÐ±Ð½Ð¾Ð²Ð»ÐµÐ½Ð¸Ðµ Ð¼Ð°ÐºÑÐ¸Ð¼Ð°Ð»ÑÐ½Ð¾Ð¹ Ð´Ð»Ð¸Ð½Ñ Ð¸ ÑÑÑÐ¾ÐºÐ¸ Ñ ÑÑÐ¾Ð¹ Ð¿Ð¾ÑÐ»ÐµÐ´Ð¾Ð²Ð°ÑÐµÐ»ÑÐ½Ð¾ÑÑÑÑ
            if (maxCurrentRowLength > maxLength)
            {
                maxLength = maxCurrentRowLength;
                rowWithMaxSequence = i;
            }
        }

        Console.WriteLine($"\nÐ¡ÑÑÐ¾ÐºÐ° Ñ ÑÐ°Ð¼Ð¾Ð¹ Ð´Ð»Ð¸Ð½Ð½Ð¾Ð¹ Ð²Ð¾Ð·ÑÐ°ÑÑÐ°ÑÑÐµÐ¹ Ð¿Ð¾ÑÐ»ÐµÐ´Ð¾Ð²Ð°ÑÐµÐ»ÑÐ½Ð¾ÑÑÑÑ: {rowWithMaxSequence + 1}");

        // ÐÐ±Ð¼ÐµÐ½ Ð¼ÐµÑÑÐ°Ð¼Ð¸ 1 Ð¸ 2 ÑÑÐ¾Ð»Ð±ÑÐ¾Ð²
        SwapColumns(matrix, 0, 1);

        // ÐÑÐ²Ð¾Ð´ Ð¼Ð°ÑÑÐ¸ÑÑ Ð¿Ð¾ÑÐ»Ðµ Ð·Ð°Ð¼ÐµÐ½Ñ ÑÑÐ¾Ð»Ð±ÑÐ¾Ð²
        Console.WriteLine("\nÐÐ°ÑÑÐ¸ÑÐ° Ð¿Ð¾ÑÐ»Ðµ Ð¾Ð±Ð¼ÐµÐ½Ð° 1 Ð¸ 2 ÑÑÐ¾Ð»Ð±ÑÐ¾Ð²:");
        PrintMatrix(matrix);
    }

    // ÐÐµÑÐ¾Ð´ Ð´Ð»Ñ Ð¾Ð±Ð¼ÐµÐ½Ð° ÑÑÐ¾Ð»Ð±ÑÐ¾Ð² Ð¼ÐµÑÑÐ°Ð¼Ð¸
    static void SwapColumns(int[,] matrix, int col1, int col2)
    {
        int rows = matrix.GetLength(0);

        for (int i = 0; i < rows; i++)
        {
            int temp = matrix[i, col1];
            matrix[i, col1] = matrix[i, col2];
            matrix[i, col2] = temp;
        }
    }

    // ÐÐµÑÐ¾Ð´ Ð´Ð»Ñ Ð²ÑÐ²Ð¾Ð´Ð° Ð¼Ð°ÑÑÐ¸ÑÑ Ð½Ð° ÑÐºÑÐ°Ð½
    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
