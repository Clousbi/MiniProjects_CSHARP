using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleição2Candidatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int votos1, votos2, idade1, idade2;
            Console.WriteLine("Escreva a idade do primeiro candidato:");
            idade1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva a idade do segundo candidato:");
            idade2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva os votos do primeiro candidato:");
            votos1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva os votos do segundo candidato:");
            votos2 = int.Parse(Console.ReadLine());
            if (votos1 > votos2) // C1 eleito por votos
            {
                Console.WriteLine("Candidato 1 eleito por votos.");
            }
            else
            {
                if (votos2 > votos1) // C2 eleito por votos
                {
                    Console.WriteLine("Candidato 2 eleito por votos.");
                }
                else // C1 e C2 empatados em votos
                {
                    if (idade1 > idade2) // C1 eleito por idade
                    {
                        Console.WriteLine("Candidato 1 eleito por idade.");
                    }
                    else
                    {
                        if (idade2 > idade1) // C2 eleito por idade
                        {
                            Console.WriteLine("Candidato 2 eleito por idade.");
                        }
                        else // C1 e C2 empatados em idade: nova eleição
                        {
                            Console.WriteLine("Candidatos 1  e 2 empatados em votos e idade.Nova eleição deve ser realizada.");
                        }
                    }
                }
                Console.ReadKey();
            }
        }
    }
}

