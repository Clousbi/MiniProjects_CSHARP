using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base10base2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, n, n2;

            Console.WriteLine("Digite um número:");
            n= int.Parse(Console.ReadLine());

            i = n;

            while(i != 0)
            {
                n2 = n % 2;
                n = n / 2;
               
                Console.Write($"{n2},");
                
                i--;
            }
            Console.ReadKey();
        }
    }
}
