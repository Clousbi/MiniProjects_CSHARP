using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoIntermediario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string estacionamento;
            int valorHora, veiculos, horas, montanteFinal=0, montanteAdicional, media;
            Console.WriteLine("Escreva o nome do Estacionamento:");
            estacionamento = Console.ReadLine();
            Console.WriteLine("Escreva o valor por hora:");
            valorHora = int.Parse(Console.ReadLine());

            do //quantidade de veículos (com repetição caso menor que 10)
            {
                Console.WriteLine("Escreva a quantidade de veículos:");
                veiculos = int.Parse(Console.ReadLine());
            } while (veiculos < 10);

            for(int i=0; i <veiculos; i++) // valor do montante (repetição até a quantidade de veículos)
            {
                Console.WriteLine("Escreva as horas que o veículo permaneceu no estacionamento:");
                horas = int.Parse(Console.ReadLine());
                montanteAdicional = valorHora * horas;
                montanteFinal = montanteFinal + montanteAdicional;
            }

            media = montanteFinal / veiculos;
           
            Console.WriteLine($"O {estacionamento} teve no total de {veiculos} veículos;"); 
            Console.WriteLine($"O montante arrecadado ao longo do dia foi de {montanteFinal}reais;");
            Console.WriteLine($"A média é de {media} reais;");
            Console.ReadKey();
        }
    }
}
