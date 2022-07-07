using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoLinguagens
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, m, x, par=0, impar=0, maiorm=0, menorm=0, maior=0, menor=0, soma=0;
            float media;

            Console.WriteLine("Quantidade de números:");
            n = int.Parse (Console.ReadLine());
            Console.WriteLine("Valor de M:");
            m = int.Parse (Console.ReadLine()); 



            for (int i =0; i < n; i++)
            {
                Console.WriteLine($"{i +1}° número:");
                x = int.Parse (Console.ReadLine());

                if ( x % 2 == 0)
                {
                    par++;
                }
                else
                {
                    impar++;
                }



                if (x > m)
                {
                    maiorm++;
                }
                else
                {
                    menorm++;
                }



                if (i == 0)
                {
                    menor = x;
                }
                if (x > maior)
                {
                    maior = x;
                }
                if (x < menor)
                {
                    menor = x;
                }



                soma = soma + x;

                
            }


            media = soma / n;

            

            Console.WriteLine($"Quantidade de números pares:{par}");
            Console.WriteLine($"Quantidade de números impares:{impar}");
            Console.WriteLine($"Quantidade de números maiores que m:{maiorm}");
            Console.WriteLine($"Quantidade de números menores que m:{menorm}");
            Console.WriteLine($"O maior número:{maior}");
            Console.WriteLine($"O menor número:{menor}");
            Console.WriteLine($"A soma:{soma}");
            Console.WriteLine($"A média:{media}");
            Console.ReadKey();
        }
    }
}
