using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            string Nome;
            float Salário;
            float NovoSalário;
            float Percentual;

            Console.Clear();        //Limpa a Tela

            Console.Write("Nome do Funcionário..: ");
            Nome = Console.ReadLine();

            Console.Write("Salário..............: ");
            Salário = float.Parse(Console.ReadLine());

            Console.Write("Aumento Percentual...: ");
            Percentual = float.Parse(Console.ReadLine());

            NovoSalário = Salário + Salário * Percentual / 100;

            Console.WriteLine("\nO(A) Funcionário(a) {0}, que recebia {1:F2}, passará a receber {2:F2}", Nome, Salário, NovoSalário);
            Console.WriteLine("já que teve um aumento de {0:F1} %.\n\n", Percentual);

            Console.ReadKey();
            
        }
    }
}
