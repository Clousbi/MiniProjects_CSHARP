using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaAritmetica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            double x, y, z, M;
            for (i = 1; i <= 5; i++)
            {
                Console.Write("Primeiro número: ");
                x = float.Parse(Console.ReadLine());
                Console.Write("Segundo número: ");
                y = float.Parse(Console.ReadLine());
                Console.Write("Terceiro número: ");
                z = float.Parse(Console.ReadLine());
                M = (x + y + z) / 3;
                Console.WriteLine($"média = {M}");
            }
            Console.ReadKey();
        }
    }
}
