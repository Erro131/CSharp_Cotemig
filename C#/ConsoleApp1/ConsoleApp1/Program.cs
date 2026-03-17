using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escreva um programa que preencha aleatoriamente uma matriz real de 6x6, calcule a soma e a média dos elementos 
            //situados acima da diagonal secundária, incluindo a própria diagonal.


            double[,] mat = new double[6,6];

            Random rand = new Random();

            double soma = 0;

            double media = 0;

            double cont = 0;

            for (int i = 0; i< mat.GetLength(0); i++)
            {
              
                for (int j = 0; j < mat.GetLength(1); j++)
                {

                    mat[i,j] = rand.NextDouble();
                    if (i + j <= mat.GetLength(0) - 1)
                    {

                        soma += mat[i, j];

                        cont++;
                        Console.WriteLine("Cont: " + cont);
                    }
                }

               


            }
            media = soma / cont;


            Console.WriteLine("Soma: " + soma);

            Console.WriteLine("Média: " + media);

        }
    }
}
