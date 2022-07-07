using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchCaseVogaleConsoante
{
    internal class Program
    {
        static void letraVouC(char x)
        {
            switch (x)
            {
                case 'a':
                    Console.Write("A letra inserida é uma vogal.");
                    break;
                case 'e':
                    Console.Write("A letra inserida é uma vogal.");
                    break;
                case 'i':
                    Console.Write("A letra inserida é uma vogal.");
                    break;
                case 'o':
                    Console.Write("A letra inserida é uma vogal.");
                    break;
                case 'u':
                    Console.Write("A letra inserida é uma vogal.");
                    break;
                default:
                    Console.Write("A letra inserida é uma consoante.");
                    break;
            }

        }


        static void Main(string[] args)
        {
            char letra;
            Console.WriteLine("Escreva a letra desejada:");
            letra = char.Parse(Console.ReadLine());

            letraVouC(letra);
            Console.ReadKey();



        }
    }
}
