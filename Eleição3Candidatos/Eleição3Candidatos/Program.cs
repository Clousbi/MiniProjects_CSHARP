using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleição3Candidatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int v1, v2, v3;
            Console.WriteLine("Informe os números de votos: ");
            Console.Write("Candidato 1: ");
            v1 = int.Parse(Console.ReadLine());
            Console.Write("Candidato 2: ");
            v2 = int.Parse(Console.ReadLine());
            Console.Write("Candidato 3: ");
            v3 = int.Parse(Console.ReadLine());
            if (v1 > v2) // C2 eliminado (disputa entre C1 e C3)
            {
                if (v1 > v3) // C1 eleito
                {
                    Console.WriteLine("C1 eleito");
                }
                else
                {
                    if (v1 < v3) // C3 eleito
                    {
                        Console.WriteLine("C3 eleito");
                    }
                    else // C1 e C3 empatados e ganhando de C2
                    {
                        Console.WriteLine("C1 e C3 empatados");
                    }

                }
            }
            else //nada se sabe ainda
            {
                if (v1 < v2) // C1 eliminado (disputa entre C2 e C3)
                {
                    if (v2 > v3) // C2 eleito
                    {
                        Console.WriteLine("C2 eleito");
                    }
                    else
                    {
                        if (v2 < v3) // C3 eleito
                        {
                            Console.WriteLine("C3 eleito");
                        }
                        else // C2 e C3 empatados e ganhando de C1
                        {
                            Console.WriteLine("C2 e C3 empatados");
                        }
                    }
                }

                else // C1 e C2 empatados (ganhando, perdendo ou empatando com C3)
                {
                    if (v1 < v3) // C3 eleito com C1 e C3 empatados em segundo
                    {
                        Console.WriteLine("C3 eleito");
                    }
                    else
                    {
                        if (v1 > v3) // C1 e C2 empatados com C3 em segundo
                        {
                            Console.WriteLine("C1 e C2 empatados");
                        }
                        else // C1, C2 e C3 empatados
                        {
                            Console.WriteLine("C1, C2 e C3 empatados");
                        }
                    }
                }
            }

            Console.ReadKey();
        }
    }

}
