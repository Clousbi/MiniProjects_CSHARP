using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatorial
{
    internal class Program
    {
        static int Fatorial(int x)
        {
            int fatn = 1;
            for (int i = 1; i <= x; i++)
            {
                fatn = fatn * i;
            }
            return (fatn);
        }
        static void Main(string[] args)
        {
            int n;
            Console.Write("Digite o número:");
            n = int.Parse(Console.ReadLine());
            Console.Write($"O fatorial de {n} é {Fatorial(n)}");

            Console.ReadKey();
        }
    }
}
