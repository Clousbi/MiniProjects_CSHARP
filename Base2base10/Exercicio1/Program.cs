using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string binario;
            double base10 = 0, exp = 0;


            Console.WriteLine("Digite o número binário:");
            binario = Console.ReadLine();

            for (int i = binario.Length-1; i >= 0 ; i--)
            {
                base10 = base10 + char.GetNumericValue(binario[i]) * Math.Pow(2, exp);
                exp++;
            }
            Console.WriteLine($"Esse número na base 10 é {base10}");
            Console.ReadKey();
        }
    }
}
