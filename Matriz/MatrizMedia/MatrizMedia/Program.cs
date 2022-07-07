using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizMedia
{
    class Program
    {

        static int[,] PreencherMatriz(int l, int c)
        {
            int[,] M = new int[l, c];
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    Console.Write($"Insira na {i + 1}° linha e na {j + 1} coluna: ");
                    M[i, j] = int.Parse(Console.ReadLine());

                }
            }
            return (M);

        }
        static void Media(int[,] M)
        {
            int soma = 0,
            media = 0;
            int[] V = new int[M.GetLength(0)];


            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    soma = soma + M[i, j];


                }

                Console.WriteLine($"A soma dos elementos em cada linha:{soma}.");
                media = soma / M.GetLength(1);
                V[i] = media;
                Console.WriteLine($"A media dos elementos em cada linha:{media}.");

                soma = 0;

            }



        }
        static void ImprimirMatriz(int[,] M)
        {
            Console.WriteLine("Sequência: ");
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    Console.WriteLine($"{M[i, j]}, ");
                }

            }

        }
        static void Main(string[] args)
        {
            int[,] M;
            int l, c;
            Console.Write("Número de colunas da matriz:");
            c = int.Parse(Console.ReadLine());
            Console.Write("Número de linhas da matriz:");
            l = int.Parse(Console.ReadLine());

            M = PreencherMatriz(l, c);
            Media(M);
            ImprimirMatriz(M);
            Console.ReadKey();
        }
    }
}
