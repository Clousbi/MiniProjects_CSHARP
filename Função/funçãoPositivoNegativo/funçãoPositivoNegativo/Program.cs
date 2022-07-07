using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funçãoPositivoNegativo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Escreva um número inteiro:");
            n = int.Parse(Console.ReadLine());
            if (n > 0)
            {
                Console.WriteLine("É um número positivo");
            }
            else if (n < 0)
            {
                Console.WriteLine("É um número negativo");
            }
            else
            {
                Console.WriteLine("É um número nulo");
            }
            Console.ReadKey();
        }


        /*static int pnn (int n) // Lista de exercicios 3 (numero 1)
        {
            if (n > 0)
            {
                Console.WriteLine("É um número positivo");
            }else if(n < 0)
            {
                Console.WriteLine("É um número negativo");
            }
            else
            {
                Console.WriteLine("É um número nulo");
            }
            return n;
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Escreva um número inteiro:");
            n = int.Parse(Console.ReadLine());
            pnn(n);
            Console.ReadKey();
        }*/
    }
}
