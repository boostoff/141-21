using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bstff
{
    class Program
    {
        static void Main(string[] args)
        {
            // vvod a, b и x
            Console.Write("vvod a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("vvod b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("vvod x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            // proverka uslovii i vi4islenie y
            double y;

            // ternarnii operator
            y = (3 * a > 2 * b)
                ? (Math.Log(Math.Pow(x, 2)) - Math.Asin(x / 10))
                : (Math.Atan(2 * x - 0.6) + 2 * Math.Log(x));

            // vivod rez
            Console.WriteLine($"zna4 y 4erez ternarnii operatorom: {y:F3}");

            // s u4astiem uslovnogo operatora >> if
            if (3 * a > 2 * b)
            {
                y = Math.Log(Math.Pow(x, 2)) - Math.Asin(x / 10);
            }
            else
            {
                y = Math.Atan(2 * x - 0.6) + 2 * Math.Log(x);
            }

            // Вывод результата
            Console.WriteLine($"zna4 Y s uslovnim operatorom if: {y:F3}");
        }
    }
}
