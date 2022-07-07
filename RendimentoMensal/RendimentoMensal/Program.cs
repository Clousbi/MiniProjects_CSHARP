using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RendimentoMensal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salariobase, salariofinal, coeficiente;
            int horasextras;
            Console.Write("Informe o salário base: ");
            salariobase = float.Parse(Console.ReadLine());
            Console.Write("Informe a quantidade de horas extras: ");
            horasextras = int.Parse(Console.ReadLine());
            if (horasextras <= 10)
                coeficiente = 0.01;
            else if (horasextras <= 20)
                coeficiente = 0.02;
            else
                coeficiente = 0.03;
            salariofinal = horasextras * salariobase * coeficiente +
            salariobase;
            Console.WriteLine($"Salário Final: R$ {salariofinal}");
            Console.ReadKey();
        }
    }
}
