using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace somaComVetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, soma = 0;
            int[] V;
            float media;

            Console.WriteLine("Tamanho do vetor");
            n =int.Parse(Console.ReadLine());
            V = new int[n];

            Console.WriteLine("Elementos do Vetor:");
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"{i + 1}o. elemento:");
                V[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                soma = soma + V[i];
            }
            media = (float)soma / n;
            Console.WriteLine($"Soma: {soma}");
            Console.WriteLine($"Média: {media}");
            Console.ReadKey();
        }
    }
}
