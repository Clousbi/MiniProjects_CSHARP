using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroPrimoWhile
{
    internal class Program
    {
        static bool NumeroPrimo (int n)
        {
            if ((n == 0) || (n == 1))
            {
                return (false);
            }

            if (n == 2)
            {
                return (true);
            }

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            return (false);
        }
        static void Main(string[] args)
        {
            int n,resp;
            
            do
            {
                Console.WriteLine("Digite um número:");
                n = int.Parse(Console.ReadLine());

                if (NumeroPrimo(n) == true)
                {
                    Console.WriteLine("O numero é primo");

                }
                else
                {
                    Console.WriteLine("O número não pe primo");
                }

                Console.WriteLine("Deseja digitar outro número? ('1' para sim, '0' para não)");
                resp = int.Parse(Console.ReadLine());

            } while (resp != 0);
        }
    }
}
