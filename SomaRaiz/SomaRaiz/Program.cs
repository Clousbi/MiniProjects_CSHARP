using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomaRaiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int P1, P2, Soma, Quadrado;
            for (int i = 1000; i <= 9999; i++)
            {
                P1 = i / 100;
                P2 = i % 100;

                Soma = P1 + P2;
                Quadrado = Soma * Soma;

                if (Quadrado == i)
                {
                    Console.WriteLine($"O número {i} possui essa característica...");
                }
            }
            Console.ReadKey();
        }
    }
}
