using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizLinhaSoma
{
    class Program
    {
        static void Matriz(int l, int c, int linha)
        {
            int[,] M = new int[l, c];
            int i = 0, soma =0;
            for (i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    Console.Write($"Insira na {i + 1}° linha e na {j + 1} coluna: ");
                    M[i, j] = int.Parse(Console.ReadLine());

                    if (i == linha-1)
                        soma = soma + M[i, j];
                    

                }
            }
            
           Console.WriteLine($"A soma da linha {linha} é :{soma}.");

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
            int l, c, linha;
            Console.Write("Número de colunas da matriz:");
            c = int.Parse(Console.ReadLine());
            Console.Write("Número de linhas da matriz:");
            l = int.Parse(Console.ReadLine());
            Console.Write("Linha escolhida para somar:");
            linha = int.Parse(Console.ReadLine());

            Matriz(l, c, linha);
            
            Console.ReadKey();
        }
    }
}
