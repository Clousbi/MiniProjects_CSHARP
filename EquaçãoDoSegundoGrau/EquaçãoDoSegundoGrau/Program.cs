using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquaçãoDoSegundoGrau
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta;
            double x1, x2;
            Console.WriteLine("Por gentileza, informe os seguintes valores");
            Console.WriteLine("para que as raízes da equação sejam calculadas: ");
            Console.Write("a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("b: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("c: ");
            c = double.Parse(Console.ReadLine());
            delta = Math.Pow(b, 2) - 4 * a * c;
            Console.WriteLine($"delta = {delta}");
            if (delta > 0) // duas raízes
            {
                x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"Raízes reais: {x1} e {x2} ");
            }
            else
            {
                if (delta < 0) // nenhuma raiz
                {
                    Console.WriteLine("Não existem raízes reais.");
                }
                else // uma única raiz
                {
                    x1 = -b / (2 * a);
                    Console.WriteLine($"Raiz: {x1}");
                }
            }
            Console.ReadKey();
        }
    }
}
