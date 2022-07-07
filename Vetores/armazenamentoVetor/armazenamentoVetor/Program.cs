using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace armazenamentoVetor
{
    internal class Program
    {
        static int[] preencherVetor(int n)
        {

            int[] vetor = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Insira na {i + 1}° posição: ");
                vetor[i] = int.Parse(Console.ReadLine());

            }

            return vetor;
        }
        
        static void Main(string[] args)
        {
            int n1, n2, cont;
            int[] V1, V2;
            Console.WriteLine("Escreva o tamanho do primeiro vetor:");
            n1= int.Parse(Console.ReadLine());
            Console.WriteLine("Primeiro Vetor:");
            V1 = preencherVetor(n1);
            Console.WriteLine("Escreva o tamanho do segundo vetor:");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Vetor:");
            V2 = preencherVetor(n2);

            Console.Clear();

            Console.WriteLine($"Sequência do primeiro vetor: ");
            for (int i = 0; i < V1.Length; i++)
            {
                Console.WriteLine($"{V1[i]}. ");
            }

            Console.WriteLine($"Sequência do segundo vetor: ");
            for (int i = 0; i < V2.Length; i++)
            {
                Console.WriteLine($"{V2[i]}. ");
            }

            for (int i = 0; i < n1; i++)
            {
                cont = 0;
                for (int j = 0; j < n2; j++)
                {
                    if (V1[i] % V2[j] == 0)
                    {
                        cont++;
                    }
                }
                if (cont == n2)
                {
                    Console.WriteLine($"Os múltiplos são:{V1[i]}. ");
                }
            }


                Console.ReadKey();
        }
    }
}
