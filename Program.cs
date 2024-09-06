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
            // zapros zna4
            Console.Write("Vvedite zna4: ");
            double alpha;

            // vvod
            if (!double.TryParse(Console.ReadLine(), out alpha))
            {
                Console.WriteLine("krivoe 4islo.");
                return;
            }

            // vi4islenie z1
            double z1 = (Math.Sin(Math.PI / 2 + 3 * alpha)) / (1 - Math.Sin(3 * alpha - Math.PI));

            // vi4islenie z2
            double z2 = 1 / Math.Tan((5 * Math.PI / 4) + (3 * alpha / 2));

            // okruglenie do 1000
            z1 = Math.Round(z1, 3);
            z2 = Math.Round(z2, 3);

            // vivod
            Console.WriteLine($"z1 = {z1}");
            Console.WriteLine($"z2 = {z2}");
        }
    }
}
