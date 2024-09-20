using System;

class Program
{
    // Функция, которая моделирует график
    static double GraphFunction(double x)
    {
        if (x >= -6 && x <= -4)
        {
            // Постоянная линия: y = -1
            return -1;
        }
        else if (x > -4 && x <= 0)
        {
            // Линейный участок между (-4, -1) и (0, 0)
            double y1 = -1, x1 = -4;
            double y2 = 0, x2 = 0;
            return y1 + (y2 - y1) / (x2 - x1) * (x - x1);
        }
        else if (x > 0 && x <= 2)
        {
            // Участок с кривой между (0, 0) и (2, 4)
            // Допустим, это часть окружности с центром в (0, 0) и радиусом 2
            return Math.Sqrt(4 - Math.Pow(x, 2));
        }
        else if (x > 2 && x <= 8)
        {
            // Линейный участок между (2, 4) и (8, 0)
            double y1 = 4, x1 = 2;
            double y2 = 0, x2 = 8;
            return y1 + (y2 - y1) / (x2 - x1) * (x - x1);
        }
        else if (x > 8 && x <= 10)
        {
            // Линейный участок между (8, 0) и (10, -1)
            double y1 = 0, x1 = 8;
            double y2 = -1, x2 = 10;
            return y1 + (y2 - y1) / (x2 - x1) * (x - x1);
        }
        else
        {
            // Если x не в заданном диапазоне
            return double.NaN;
        }
    }

    // Функция для вывода таблицы значений
    static void PrintTable(double xStart, double xEnd, double dx)
    {
        Console.WriteLine("{0,-10}{1,-10}", "x", "y");

        double x = xStart;
        while (x <= xEnd)
        {
            double y = GraphFunction(x);
            Console.WriteLine("{0,-10:F2}{1,-10:F2}", x, y);
            x += dx;
        }
    }

    static void Main(string[] args)
    {
        // Задать начальные значения
        double xStart = -6;
        double xEnd = 10;
        double dx = 0.5;  // Шаг

        // Вывести таблицу значений
        PrintTable(xStart, xEnd, dx);
    }
}
