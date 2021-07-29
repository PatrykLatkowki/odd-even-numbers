using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = GetInput();

            Console.WriteLine(number % 2 == 0 ? "Liczba parzysta" : "Liczba nieparzysta");
        }

        private static int GetInput()
        {
            while (true)
            {
                Console.Write("Podaj dowolną liczbę całkowitą: ");

                if (!int.TryParse(Console.ReadLine(), out int number))
                    Console.WriteLine("Podana liczba nie jest liczbą całkowitą!");
                else
                    return number;
            }
        }
    }
}
