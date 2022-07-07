using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inverteVetor
{
    internal class Program
    {
        static int [] inverteVetor (int [] v) //inverte o vetor principal
        {
            int[] vi = new int[v.Length];
            int i, j = v.Length - 1;
            for (i = 0; i < v.Length; i++)
            {
                vi[j] = v[i];
                j--;
            }
            return vi;
        }
        static int[] preencherVetor(int n) //anota todos os valores em cada casa do vetor
        {

            int[] vetor = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Insira na {i + 1}° posição: ");
                vetor[i] = int.Parse(Console.ReadLine());

            }

            return vetor;
        }
        static void imprimirVetor(int[] v) //exibe os valores inseridos no vetor
        {
            
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write($"{v[i]}, ");
            }

        }
        static void Main(string[] args)
        {
            int[] v;
            int n;
            Console.WriteLine("Escreva o tamanho do vetor:");
            n = int.Parse(Console.ReadLine()); //anota o tamanho do vetor
            v = preencherVetor(n); //função
            imprimirVetor(v); //parametro
            imprimirVetor(inverteVetor(v)); //parametro (função)

            Console.ReadKey();

        }
    }
}
