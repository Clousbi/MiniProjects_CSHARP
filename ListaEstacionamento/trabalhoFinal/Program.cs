using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalhoFinal
{
    internal class Program
        {
        static StreamReader estacionamento_in = new
        StreamReader("C:\\Users\\Bianc\\OneDrive\\Documentos\\CÓDIGOS 2022\\C#\\FACULDADE\\EXERCICIOS\\trabalhoFinal\\estacionamento_in.txt");
        static StreamWriter estacionamento_out = new
        StreamWriter("C:\\Users\\Bianc\\OneDrive\\Documentos\\CÓDIGOS 2022\\C#\\FACULDADE\\EXERCICIOS\\trabalhoFinal\\estacionamento_out.txt");
        static string LeituraString() //Leitura do nome do estacionamento
        {
            string dado;
            dado = estacionamento_in.ReadLine();
            return (dado);
        }
        static int Montante(double valorHora, int carros, int[] horas) // função que calcula o que arrecadou no final do dia 
        {
            int montanteFinal = 0, montanteAdicional;

            for (int i = 0; i < carros; i++) // for para passar em todos os carros e adicionando a quantidade entre (valor das horas * horas permanecidas)
            {

                montanteAdicional = (int)(valorHora * horas[i]); // multiplicação de cada carro pagou no estacionamento
                montanteFinal = montanteFinal + montanteAdicional; // armazena e soma com o que os outros carros pagaram
            }
            return (montanteFinal);
        }
        static double Media(int n, int[] vetor) // função pra calcular a média de idade entre os carros
        {
            int soma = 0;
            double media;

            for (int i = 0; i < n; i++)
            {
                soma = soma + vetor[i];
            }
            media = soma / n;
            return (media);
        }
        static void ImprimirResumo (string Estacionamento, int Carros, double ValorHora,int [] Horas, int [] AnoFabricacao) // procedimento que faz o resumo da arrecadação e a média
        {
            float media, MontanteFinal = 0;

            MontanteFinal = Montante(ValorHora, Carros, Horas);
            media = MontanteFinal / Carros;

            estacionamento_out.WriteLine("|--------------|");
            estacionamento_out.WriteLine("|----Resumo----|");
            estacionamento_out.WriteLine("|--------------|");
            estacionamento_out.WriteLine("");

            estacionamento_out.WriteLine($"O {Estacionamento} teve no total de {Carros} veículos;");
            estacionamento_out.WriteLine($"O montante arrecadado ao longo do dia foi de {MontanteFinal}reais;");
            estacionamento_out.WriteLine($"A média do faturamento é de {media} reais;");
            estacionamento_out.WriteLine($"A média de idade dos veículos é de {2022 - Media(Carros, AnoFabricacao)} anos");

        }
        static void ImprimirLista(string [] Placa, string [] Proprietario, string [] Modelo,int [] AnoFabricacao ,int [] Horas, int Carros) // procedimento que mostra os dados do carro mais antigo e do mais novo
        {
            int anofabricacaoAntigo = 0, horasAntigo = 0, anoAtual = 2022, anofabricacaoNovo = 0, horasNovo = 0;
            string placaAntigo = null, modeloAntigo = null, proprietarioAntigo = null, placaNovo = null, modeloNovo = null, proprietarioNovo = null;

           




            for (int i = 0; i < Carros; i++)
            {
                if (AnoFabricacao[i] < anoAtual)
                {

                    placaAntigo = Placa[i];
                    modeloAntigo = Modelo[i];
                    proprietarioAntigo = Proprietario[i];
                    anofabricacaoAntigo = AnoFabricacao[i];
                    horasAntigo = Horas[i];


                    anoAtual = AnoFabricacao[i];

                }

                if (AnoFabricacao[i] > 0)
                {
                    placaNovo = Placa[i];
                    modeloNovo = Modelo[i];
                    proprietarioNovo = Proprietario[i];
                    anofabricacaoNovo = AnoFabricacao[i];
                    horasNovo = Horas[i];


                    anoAtual = AnoFabricacao[i];

                }
            }

            estacionamento_out.WriteLine("|-------------------------------|");
            estacionamento_out.WriteLine("|---- Cadastro dos veículos ----|");
            estacionamento_out.WriteLine("|-------------------------------|");
            estacionamento_out.WriteLine("");

            estacionamento_out.WriteLine("|--------------------------------------|");
            estacionamento_out.WriteLine("|    Cadastro do veículo mais velho    |");
            estacionamento_out.WriteLine("|--------------------------------------|");
            estacionamento_out.WriteLine("");

            estacionamento_out.WriteLine($"Placa: {placaAntigo}");
            estacionamento_out.WriteLine($"Modelo do veículo: {modeloAntigo}");
            estacionamento_out.WriteLine($"Ano de fabricação: {anofabricacaoAntigo}");
            estacionamento_out.WriteLine($"Horas no estacionamento: {horasAntigo}");
            estacionamento_out.WriteLine($"Proprietário:{proprietarioAntigo}");

            estacionamento_out.WriteLine("|--------------------------------------|");
            estacionamento_out.WriteLine("|    Cadastro do veículo mais novo     |");
            estacionamento_out.WriteLine("|--------------------------------------|");
            estacionamento_out.WriteLine("");

            estacionamento_out.WriteLine($"Placa: {placaNovo}");
            estacionamento_out.WriteLine($"Modelo do veículo: {modeloNovo}");
            estacionamento_out.WriteLine($"Ano de fabricação: {anofabricacaoNovo}");
            estacionamento_out.WriteLine($"Horas no estacionamento: {horasNovo}");
            estacionamento_out.WriteLine($"Proprietário:{proprietarioNovo}");

            estacionamento_out.WriteLine("|--------------|");
            estacionamento_out.WriteLine("|-----Fim------|");
            estacionamento_out.WriteLine("|--------------|");
            estacionamento_out.WriteLine("");
        }
        static void Main(string[] args)
        {
            
            string Estacionamento, carros, valorHora;
            
            Estacionamento = LeituraString();
            valorHora = LeituraString();
            carros = LeituraString();

            int Carros = Int32.Parse(carros);
            double ValorHora = double.Parse(valorHora);

            string[] Placa = new string[Carros], Modelo = new string[Carros], Proprietario = new string[Carros], anoFabricacao = new string[Carros], horas = new string[Carros];



            for (int i = 0; i < Carros; i++)
            {
                
                Placa [i] = estacionamento_in.ReadLine(); 
                Modelo [i] = estacionamento_in.ReadLine(); 
                anoFabricacao [i] = estacionamento_in.ReadLine();
                horas [i] =  estacionamento_in.ReadLine();
                Proprietario [i] = estacionamento_in.ReadLine();
            }


            int[] AnoFabricacao = Array.ConvertAll(anoFabricacao, int.Parse);
            int[] Horas = Array.ConvertAll(horas, int.Parse);
            


            ImprimirResumo(Estacionamento, Carros, ValorHora, Horas, AnoFabricacao);
            ImprimirLista(Placa, Proprietario ,Modelo ,AnoFabricacao, Horas, Carros);

            estacionamento_in.Close();
            estacionamento_out.Close();
            Console.ReadKey();
        }
    }
}
