using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostoSaúde
{
    internal class Program { 
        

        static void doençasPorPeriodo (int [,] D, int mi, int mf) //procedimento
        {
            int soma = 0;
            for (int i = 0;i <= 2; i++)//trata os três tipos de doenças
            {
                soma = 0;  
                for (int j = mi-1; j <= mf-1; j++)
                {
                    soma = soma + D[j, i];
                }

                Console.WriteLine($"Soma das doenças: {i + 1}: {soma}");
            }
            
               
           
        }
        static void Main(string[] args)
        {
            int mi, mf, doença;
            int[,] doenças = {  { 212, 547, 256},
                                { 356, 498, 211},
                                { 356, 498, 211},
                                { 356, 456, 211},
                                { 355, 487, 211},
                                { 354, 477, 111},
                                { 353, 488, 911},
                                { 356, 494, 811},
                                { 323, 498, 711},
                                { 399, 493, 611},
                                { 300, 492, 511},
                                { 357, 422, 311} };
            Console.Write("Doenças: 1- Doença respiratória, 2- Doença gástrica, 3- Doença cardíaca");

            Console.Write("\nMês Inicial:");
            mi= int.Parse(Console.ReadLine());
            Console.Write("Mês Final:");
            mf = int.Parse(Console.ReadLine());
            Console.Write("Tipo da doença:");
            doença = int.Parse(Console.ReadLine());
            Console.Clear();

            doençasPorPeriodo(doenças, mi, mf);
            Console.ReadKey();

        }
    }
}
