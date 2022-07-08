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
            string cor,estacionamento, proprietario,placa, modelo_veiculo,nome_docarroantigo =null,modelo_docarroantigo=null, placa_docarroantigo=null, placa_docarronovo=null, modelo_docarronovo=null, nome_docarronovo=null,cor_nova=null, cor_antiga=null;
            int valorHora, veiculos, horas, montanteFinal = 0, montanteAdicional, media, anoFinal = 0, anoAdicional=0, mediaIdade, cadastro = 0, ano_fabricacao=0, ano_atual = 2023, fabr_anoantigo=0, fabr_novo = 0 ,horariopermanencia_carroantigo =0, horariopermanencia_carronovo=0;
            Console.Write("Escreva o nome do Estacionamento: ");
            estacionamento = Console.ReadLine();
            Console.Write("Escreva o valor (Em R$) por hora: ");
            valorHora = int.Parse(Console.ReadLine());
            Console.Write("Escreva a quantidade de veículos: ");
            veiculos = int.Parse(Console.ReadLine());

            Console.Clear();
            

            for (int i = 1; i <= veiculos; i++) // valor do montante (repetição até a quantidade de veículos)
            {

                Console.WriteLine($"   ...{estacionamento}...");
                Console.WriteLine(" | - - - - - - - - -|");
                Console.WriteLine($" |   Relatorio {i}    |");
                Console.WriteLine(" | - - - - - - - - -|");
                Console.WriteLine("");

                Console.Write("Informe o nome do proprietario: ");
                proprietario = Console.ReadLine();

                Console.Write("Modelo do veículo: ");
                modelo_veiculo = Console.ReadLine();

                Console.Write("Cor do veículo: ");
                cor = Console.ReadLine();

                Console.Write("A numeração da placa: ");
                placa = Console.ReadLine();

                Console.Write("Escreva o ano de fabricação do veículo: ");
                ano_fabricacao = int.Parse(Console.ReadLine());

                anoAdicional = ano_atual-ano_fabricacao;

                anoFinal = anoFinal + anoAdicional;
                

                Console.Write("Escreva quantas horas que o veículo permaneceu no estacionamento: ");
                horas = int.Parse(Console.ReadLine());
                montanteAdicional = valorHora * horas;
                montanteFinal = montanteFinal + montanteAdicional;

                if (ano_fabricacao < ano_atual )
                {

                    placa_docarroantigo = placa;
                    modelo_docarroantigo = modelo_veiculo;
                    nome_docarroantigo = proprietario;
                    fabr_anoantigo = ano_fabricacao;
                    horariopermanencia_carroantigo = horas;
                    cor_antiga = cor;

                    ano_atual = ano_fabricacao;

                }

                if (ano_fabricacao > 0)
                {
                    placa_docarronovo = placa;
                    modelo_docarronovo = modelo_veiculo;
                    nome_docarronovo = proprietario;
                    fabr_novo = ano_fabricacao;
                    horariopermanencia_carronovo = horas;
                    cor_nova = cor;

                    ano_atual = ano_fabricacao;

                }


                Console.Clear();

            }
            media = montanteFinal / veiculos;
            mediaIdade = anoFinal / veiculos;


            Console.WriteLine("|--------------|");
            Console.WriteLine("|----Resumo----|");
            Console.WriteLine("|--------------|");
            Console.WriteLine("");

            Console.WriteLine($"O estacionamento teve o total de {veiculos} veículos;");
            Console.WriteLine($"O montante arrecadado ao longo do dia foi de {montanteFinal} reais;");
            Console.WriteLine($"A média é de {media} reais;");
            Console.WriteLine($"A idade média dos veículos é de {mediaIdade} anos.");
            Console.WriteLine("");

            Console.WriteLine("|--------------|");
            Console.WriteLine("|-----Fim------|");
            Console.WriteLine("|--------------|");
            Console.WriteLine("");


            Console.WriteLine("Digite 1 para VER os cadastros do veiculo mais antigo e do veículo mais novo ");
            cadastro = int.Parse(Console.ReadLine());

            Console.Clear();

            if (cadastro >= 1)
            {
                Console.WriteLine("|-------------------------------|");
                Console.WriteLine("|---- Cadastro dos veículos ----|");
                Console.WriteLine("|-------------------------------|");
                Console.WriteLine("");

                Console.WriteLine("|--------------------------------------|");
                Console.WriteLine("|    Cadastro do veículo mais velho    |");
                Console.WriteLine("|--------------------------------------|");
                Console.WriteLine("");

                //descricao do carro mais velho
                Console.WriteLine($"Nome do proprietario: {nome_docarroantigo}");
                Console.WriteLine($"Modelo do veículo: {modelo_docarroantigo}");
                Console.WriteLine($"Cor: {cor_antiga}");
                Console.WriteLine($"Numeração da placa: {placa_docarroantigo}");
                Console.WriteLine($"ano do veículo: {fabr_anoantigo}");
                Console.WriteLine($"Hora(s) de permanencia no estacionamento:{horariopermanencia_carroantigo}");
                Console.WriteLine("");


                Console.WriteLine("|--------------------------------------|");
                Console.WriteLine("|    Cadastro do veículo mais novo     |");
                Console.WriteLine("|--------------------------------------|");
                Console.WriteLine("");

                // descricao do carro mais novo
                Console.WriteLine($"Nome do proprietario: {nome_docarronovo}");
                Console.WriteLine($"Modelo do veículo: {modelo_docarronovo}");
                Console.WriteLine($"Cor: {cor_nova}");
                Console.WriteLine($"Numeração da placa: {placa_docarronovo}");
                Console.WriteLine($"Ano do veículo: {fabr_novo}");
                Console.WriteLine($"Hora(S) de permanencia no estacionamento:{horariopermanencia_carronovo}");

               
             
            }      

               
            Console.ReadKey();
        }
    }
}
    