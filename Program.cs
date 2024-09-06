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
            // Ввод номинала банкноты
            Console.Write("vvod banka (50, 100, 200, 500, 1000, 2000, 5000): ");
            int denomination;

            // Проверка корректности ввода
            if (!int.TryParse(Console.ReadLine(), out denomination))
            {
                Console.WriteLine("tol`ko 50, 100, 200, 500, 1000, 2000, 5000.");
                return;
            }

            // operator switch
            switch (denomination)
            {
                case 50:
                    Console.WriteLine(" 50 rub = Saint-Peterburg.");
                    break;
                case 100:
                    Console.WriteLine("100 rub = Moscow.");
                    break;
                case 200:
                    Console.WriteLine("200 rub = Sevastopol.");
                    break;
                case 500:
                    Console.WriteLine("500 rub = Arhangelsk.");
                    break;
                case 1000:
                    Console.WriteLine("1000  rub = Yaroslavl.");
                    break;
                case 2000:
                    Console.WriteLine("2000  rub = Vladivostok.");
                    break;
                case 5000:
                    Console.WriteLine("5000  rub = Habarovsk.");
                    break;
                default:
                    // netu kupuri
                    Console.WriteLine("netu takoi.");
                    break;
            }
        }
    }
}