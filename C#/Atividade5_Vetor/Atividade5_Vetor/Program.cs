using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Atividade5_Vetor
{
    internal class Program
    {






        class Aluno
        {

            public String nome;
            public String resultadoFinal;
        }

        class TestaAluno
        {
            static void Main(string[] args)
            {
                //Escreva a classe TestaAluno que deverá permitir o cadastro de N alunos, onde N será informado pelo usuário (dica: use um vetor de objetos). 
                //Ao final, imprimir nome e resultado final dos N alunos.

                Console.Write("Informe a quantidade de alunos: ");

                int n = int.Parse(Console.ReadLine());


                Aluno[] Aluno = new Aluno[n];


                for (int i = 0; i < Aluno.Length; i++)
                {

                    Aluno[i]  = new Aluno();

                    Console.Write("Informe o Nome do Aluno:");
                    Aluno[i].nome = Console.ReadLine();

                    Console.WriteLine("O Resultado Final do Aluno:");
                    Aluno[i].resultadoFinal = Console.ReadLine();




                }
                for (int i = 0; i < n; i++)
                {
                    // Aqui acessamos as propriedades que preenchemos antes
                    Console.WriteLine("Nome: " + Aluno[i].nome + " | Resultado: " + Aluno[i].resultadoFinal);
                }

            }




        }
    }
}

   