using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchCaseCalculadora
{
    internal class Program
    {
        class Programs
        {
            static double adicao(double a, double b)
            {
                return (a + b);
            }
            static double subtracao(double a, double b)
            {
                return (a - b);
            }
            static double multiplicacao(double a, double b)
            {
                return (a * b);
            }
            static double divisao(double a, double b)
            {
                return (a / b);
            }
            static void Main(string[] args)
            {
                double operacao, numeroA, numeroB;
                Console.Write("1-Adição; 2-subtração; 3-Divisão; 4-Multiplicação; 5-Potência;");
                Console.WriteLine("Escreva a operação desejada:");
                operacao = double.Parse(Console.ReadLine());
                Console.Write("Escreva o valor A (em caso de potência, sua base):");
                numeroA = double.Parse(Console.ReadLine());
                Console.Write("Escreva o valor B (em caso de potência, seu expoente):");
                numeroB = double.Parse(Console.ReadLine());

                switch (operacao)
                {
                    case 1:
                        operacao = adicao(numeroA, numeroB);
                        break;
                    case 2:
                        operacao = subtracao(numeroA, numeroB);
                        break;
                    case 3:
                        operacao = divisao(numeroA, numeroB);
                        break;
                    case 4:
                        operacao = multiplicacao(numeroA, numeroB);
                        break;
                    case 5:
                        operacao = Math.Pow(numeroA, numeroB);
                        break;
                    default:
                        Console.Write("Opção inválida");
                        break;
                }
                Console.WriteLine($"O valor da operação é: {operacao}");
                Console.ReadKey();
            }
        }
    }
}