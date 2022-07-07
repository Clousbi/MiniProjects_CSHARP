using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizSomaDiagonal
{
    class Program
    {
        static int[,] PreencherMatrizQuadrada(int n)
        {
            int[,] M = new int[n, n];
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
        static void Soma(int[,] M)
        {
            int soma = 0;
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    soma = soma + M[i, j];
                }

            }
            Console.WriteLine($"A soma dos elementos em cada linha:{soma}.");

        }
        static void SomaDiagonal(int[,] M)
        {
            int soma = 0;
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        soma = soma + M[i, j];
                    }

                }

            }
            Console.WriteLine($"A soma dos elementos em cada linha:{soma}.");

        }
        static void SomaPiramideinferior(int[,] M)
        {
            int soma = 0;
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    if (i > j)
                    {
                        soma = soma + M[i, j];
                    }

                }

            }
            Console.WriteLine($"A soma dos elementos em cada linha:{soma}.");

        }
        static void SomaPiramidesuperior(int[,] M)
        {
            int soma = 0;
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    if (i < j)
                    {
                        soma = soma + M[i, j];
                    }

                }

            }
            Console.WriteLine($"A soma dos elementos em cada linha:{soma}.");

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

                Console.Write("");

            }

        }
        static void Main(string[] args)
        {
            int[,] M;
            int n;
            Console.Write("Tamanho da matriz:");
            n = int.Parse(Console.ReadLine());


            M = PreencherMatrizQuadrada(n);
            Soma(M);
            SomaDiagonal(M);
            SomaPiramideinferior(M);
            SomaPiramidesuperior(M);
            ImprimirMatriz(M);
            Console.ReadKey();
        }
    }
}
