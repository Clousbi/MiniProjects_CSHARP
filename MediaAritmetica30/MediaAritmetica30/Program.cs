using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaAritmetica30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y, z, M = 0;
            while (M < 30)
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

            //Solução2:
            double x, y, z, M;
            do
            {
                Console.Write("Primeiro número: ");
                x = float.Parse(Console.ReadLine());
                Console.Write("Segundo número: ");
                y = float.Parse(Console.ReadLine());
                Console.Write("Terceiro número: ");
                z = float.Parse(Console.ReadLine());
                M = (x + y + z) / 3;
                Console.WriteLine($"média = {M}");
            } while (M < 30);
            Console.ReadKey(); 
            
        }
    }
}
