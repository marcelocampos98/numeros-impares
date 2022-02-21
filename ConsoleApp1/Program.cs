using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144 };

            int[] resultados = numeros.Where(x => (x % 2) != 0).ToArray();

            Console.WriteLine("Números ímpares: ");

            foreach (int item in resultados)
            {
                Console.WriteLine(item);
            }

        }
    }
}
