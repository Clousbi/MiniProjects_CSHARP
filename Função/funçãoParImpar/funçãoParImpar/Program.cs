using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funçãoParImpar
{
    internal class Program
    {
        static int votação (int x,  int y)
        {
            if (x > y)
            {
                Console.WriteLine($"Eleitor 1 ganhou com:{x} votos.");
                return x;
            }
            else
            {
                Console.WriteLine($"Eleitor 2 ganhou com:{y} votos.");
                return y;
            }
        }
        static void Main(string[] args)
        {
            int eleitor1, eleitor2;
            Console.WriteLine("Escreva a quantidade de votos do eleitor 1:");
            eleitor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva a quantidade de votos do eleitor 2:");
            eleitor2 = int.Parse(Console.ReadLine());
          votação(eleitor1, eleitor2);
            Console.ReadKey();

        }
    }


}
