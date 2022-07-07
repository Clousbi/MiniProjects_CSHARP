using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PercentualReprovação
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int turmaA,reprovadosA,turmaB,reprovadosB, reprovadosg;
            Console.WriteLine("Escreva o número de aprovados da turma A:");
            turmaA = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva o número de aprovados da turma B:");
            turmaB = int.Parse(Console.ReadLine());

            reprovadosA = (60 - turmaA) * 100 / 60;
            reprovadosB = (20 - turmaB) * 100 / 20;
            reprovadosg = (80 - turmaA - turmaB) * 100 / 80;

            Console.WriteLine($"Reprovados da turma A: {reprovadosA}");
            Console.WriteLine($"Reprovados da turma B: {reprovadosB}");
            Console.WriteLine($"Reprovados geral: {reprovadosg}");
            Console.ReadKey();
        }

    }
}
