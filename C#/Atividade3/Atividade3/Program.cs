using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Atividade3
{
    internal class Program
    {


//  O IBOPE deseja fazer uma pesquisa de audiência das rádios locais.Para tal, cada entrevistado deverá informar: 

//IDADE
//SEXO(1-Masculino, 2-Feminino)
//ESTADO CIVIL(1-Casado, 2-Solteiro, 3-Viúvo, 4-Divorciado)
//RÁDIO PREFERIDA(1-BHfm, 2-98fm, 3-Jovem Pan, 4-Itatiaia, 5-CDL) - Qualquer outro valor deverá ser contabilizado como "Outros".

//Será realizada no total de 10 pesquisas.Calcular e imprimir:

//a) % de audiência de cada rádio(incluindo outros);
//b) nº de mulheres divorciadas que preferem CDL;
//c) nº de homens menores de 18 anos que preferem Jovem Pan;
//d) média das idades;
//e) % de homens e de mulheres.

        static void Main(string[] args)
        {
            int[] vet_Idade = new int[10];

            int[] vet_Sexo = new int[10];

            int[] vet_Radio = new int[10];

            int[] vet_Estado = new int[10];

            int ConM = 0, ConF = 0;

            int SomaIdade = 0; 

            int ContHomen18pan = 0;

            double mediaIdade = 0;

            int contBH = 0, cont98 = 0, contPan = 0, contIta = 0, contCDL = 0, contOutros = 0;

            int ContWomanDivoCDl = 0;

            for (int i = 0; i < 10; i++) {

                Console.Write("Idade : ");
                vet_Idade[i] = int.Parse(Console.ReadLine());
                Console.Write("Digite o sexo 1 = M e 2 = F : ");





                    
                vet_Sexo[i] = int.Parse(Console.ReadLine());

                while (vet_Sexo[i] != 1 && vet_Sexo[i] != 2)
                {
                    Console.Write("Valor inválido! Digite 1 para M ou 2 para F: ");
                    vet_Sexo[i] = int.Parse(Console.ReadLine());
                }

                Console.Write("Qual é o seu Estado Civil : 1-Casado, 2-Solteiro, 3-Viúvo, 4-Divorciado");


                vet_Estado[i] = int.Parse(Console.ReadLine());

                while (vet_Estado[i] < 1 || vet_Estado[i] > 4)
                {
                    Console.Write("Valor inválido! Digite um número entre 1 e 4 - 1-Casado, 2-Solteiro, 3-Viúvo, 4-Divorciado ");
                    vet_Estado[i] = int.Parse(Console.ReadLine());
                }

                Console.Write("Fale o Seu Radio : 1 - BHfm, 2 - 98fm, 3 - Jovem Pan, 4 -Itatiaia, 5 - CDL, 6 - Outros : ");

                vet_Radio[i] = int.Parse(Console.ReadLine());


                switch (vet_Radio[i])
                {
                    case 1: contBH++; break;
                    case 2: cont98++; break;
                    case 3: contPan++; break;
                    case 4: contIta++; break;
                    case 5: contCDL++; break;
                    default: contOutros++; break; // Qualquer outro cai aqui!
                }

            }
            
        

            for (int i = 0; i < 10; i++)
            {
                if (vet_Idade[i] < 18 && vet_Sexo[i] == 1 && vet_Radio[i] == 5 )
                {
                    ContHomen18pan++; 
                }

                SomaIdade =+ vet_Idade[i];


                if (vet_Sexo[i] == 2 && vet_Estado[i] == 4 && vet_Radio[i] == 3){

                    ContWomanDivoCDl++;
                }

                if (vet_Sexo[i] == 1)
                {
                    ConM++;
                }
                else
                {
                    ConF++;
                }


            }
            mediaIdade = SomaIdade / 10.0;




            Console.WriteLine("\n--- RESULTADOS DA PESQUISA ---");
            Console.WriteLine("a) Porcentagem de Audiência:");
         
            Console.WriteLine($"- BHFM: {contBH * 10}% | 98FM: {cont98 * 10}% | Jovem Pan: {contPan * 10}%");
            Console.WriteLine($"- Itatiaia: {contIta * 10}% | CDL: {contCDL * 10}% | Outros: {contOutros * 10}%");

            Console.WriteLine($"\nb) Mulheres divorciadas que preferem CDL: {ContWomanDivoCDl}");
            Console.WriteLine($"c) Homens < 18 que preferem Jovem Pan: {ContHomen18pan}");
            Console.WriteLine($"d) Média das idades: {mediaIdade:F2}");
            Console.WriteLine($"e) Homens: {ConM * 10}% | Mulheres: {ConF * 10}%");


        }
    }
}
