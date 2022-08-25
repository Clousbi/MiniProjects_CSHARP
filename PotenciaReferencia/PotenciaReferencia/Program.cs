using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotenciaReferencia
{
    internal class Program
    {
        static double Potencia(ref double x, ref double y)
        {
            double potencia;
            potencia = Math.Pow(x, y);
            return (potencia);
        }

        static void Main(string[] args)
        {
            double x, y;
            Console.Write("Digite o número da base:");
            x = double.Parse(Console.ReadLine());
            Console.Write("Digite o número do expoente:");
            y = double.Parse(Console.ReadLine());
            Console.Write($"A potência de {y} na base {x} é {Potencia(ref x, ref y)}");

            Console.ReadKey();
        }
    }
}
