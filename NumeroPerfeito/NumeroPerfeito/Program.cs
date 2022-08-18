using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroPerfeito
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int divisores;

            for (int i = 0; i <= 1000; i++)
            {
                divisores = 0;

                for (int j = 1; j < i; j++)
                {

                    if (i % j == 0)
                    {
                        divisores = divisores + j;
                    }
                    
                }
                if (divisores == i)
                {
                    Console.WriteLine($"O número {i} é um número perfeito");
                }

            }
            Console.ReadKey();
            
        }
    }
}
