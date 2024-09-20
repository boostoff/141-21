using System;

class Program
{
    static void Main()
    {
        // Цикл перебирает все трехзначные числа от 100 до 999
        for (int number = 100; number <= 999; number++)
        {
            // Проверяем, кратно ли число 3
            if (number % 3 == 0)
            {
                // Находим сумму цифр числа
                int sumOfDigits = SumDigits(number);

                // Находим частное от деления числа на 3
                int quotient = number / 3;

                // Находим сумму цифр частного
                int sumOfQuotientDigits = SumDigits(quotient);

                // Проверяем, больше ли сумма цифр числа, чем сумма цифр частного
                if (sumOfDigits > sumOfQuotientDigits)
                {
                    // Если условие выполняется, выводим число
                    Console.WriteLine(number);
                }
            }
        }
    }

    // Метод для нахождения суммы цифр числа
    static int SumDigits(int num)
    {
        int sum = 0;
        // Цикл для нахождения суммы цифр числа
        while (num > 0)
        {
            sum += num % 10; // Получаем последнюю цифру числа и добавляем к сумме
            num /= 10;       // Убираем последнюю цифру числа
        }
        return sum;
    }
}
