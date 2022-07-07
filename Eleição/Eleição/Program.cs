using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleição
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;
            Console.Write("Digite a sua idade: ");
            idade = int.Parse(Console.ReadLine());
            if ((idade >= 18) && (idade <= 70))
                Console.WriteLine("Eleitor obrigatório.");
            else if (idade < 16)
                Console.WriteLine("Não eleitor.");
            else
                Console.WriteLine("Eleitor facultativo.");
            Console.ReadKey();
        }
    }
}
