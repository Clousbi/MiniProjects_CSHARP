using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vetorParImpar
{
    internal class Program
    {
        static int contaPares(int[] V) //números pares dentro do vetor n
        {
            int i, cont = 0;
            for (i = 0; i < V.Length; i++)
                if (V[i] % 2 == 0)
                    cont++;
            return (cont);
        }

        static int contaImpares(int[] V) // números impares dentro do vetor n
        {
            int i, cont = 0;
            for (i = 0; i < V.Length; i++)
                if (V[i] % 2 == 1)
                    cont++;
            return (cont);
        }

        static int[] preencheVetor(int n) // preenche o vetor com os números que o usuário colocar
        {

            int[] V = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Insira na {i + 1}° posição: ");
                V[i] = int.Parse(Console.ReadLine());

            }

            return V;
        }

        static void exibeVetor(int[] V) //mostra ao usuário os números que ele preencheu na suas posições
        {
            Console.WriteLine("Sequência: ");
            for (int i = 0; i < V.Length; i++)
            {
                Console.Write($"{V[i]}, ");
            }
        }

        static int somaPar(int[] V) // soma dos vetores pares
        {
            int soma = 0;
            for (int i = 0; i < V.Length; i++)
            {
                if (V[i] % 2 == 0)
                    soma = soma + V[i];
            }
            return soma;

        }
        static int somaImpar(int[] V) // soma dos vetores impares
        {
            int soma = 0;
            for (int i = 0; i < V.Length; i++)
            {
                if (V[i] % 2 == 1)
                    soma = soma + V[i];
            }
            return soma;

        }
        static void Main(string[] args)
        {
            int n,ip=0,ii=0;
            float media;
            int[] V,VP,VI;
            Console.WriteLine("Escreva a quantidade ne números inteiros:");
            n = int.Parse(Console.ReadLine());
            V = preencheVetor(n);
            Console.Clear();

            
            VP = new int[contaPares(V)];
            VI = new int[contaImpares(V)];

            for (int i = 0; i < V.Length; i++)
            {
                if (V[i] % 2 == 0)//par
                {
                    VP[ip] = V[i];
                    ip++;
                }
                else
                {
                    VI[ii] = V[i];
                    ii++;
                }
            

            }
            exibeVetor(V);
            exibeVetor(VP);
            exibeVetor(VI);











            Console.WriteLine($"Números pares: {contaPares(V)}");
            Console.WriteLine($"Soma dos números pares: {somaPar(V)}");
            Console.WriteLine($"Média dos números pares: {media = (float)somaPar(V) / contaPares(V)}");


            Console.WriteLine($"Números impares: {contaImpares(V)}");
            Console.WriteLine($"Soma dos números impares: {somaImpar(V)}");
            Console.WriteLine($"Média dos números impares: {media = (float)somaImpar(V) / contaImpares(V)}");






            Console.ReadKey();
        }
    }
}
