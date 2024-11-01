using System;

class Program
{
    // Делегат для функции
    public delegate double Function(double x);

    // Метод для решения уравнения f(x) = 0 методом бисекции
    public static double BisectionMethod(Function f, double a, double b, double tolerance)
    {
        if (f(a) * f(b) >= 0)
        {
            throw new ArgumentException("Функция должна иметь разные знаки на концах отрезка [a, b].");
        }

        double c = a; // Переменная для хранения средней точки
        while ((b - a) >= tolerance)
        {
            // Находим среднюю точку
            c = (a + b) / 2;

            // Проверяем, является ли средняя точка корнем
            if (f(c) == 0.0)
                break;

            // Определяем, в какой половине находится корень
            if (f(c) * f(a) < 0)
                b = c; // Корень находится в левой половине
            else
                a = c; // Корень находится в правой половине
        }

        return c; // Возвращаем найденное значение корня
    }

    static void Main(string[] args)
    {
        // Пример использования метода BisectionMethod
        Function equation = x => x * x - 4; // Пример: f(x) = x^2 - 4 (корень в 2)

        double a = 0; // Левая граница
        double b = 5; // Правая граница
        double tolerance = 0.01; // Допустимая точность

        try
        {
            double root = BisectionMethod(equation, a, b, tolerance);
            Console.WriteLine($"Найденный корень: {root}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}
