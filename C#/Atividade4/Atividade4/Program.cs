using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Atividade4
{
    internal class Program
    {
        static void Main(string[] args) { }

        // Dê a codificação completa da classe Aluno, de acordo com o seguinte diagrama:


        //Aluno
        //- matricula: int
        //-nome: string
        //-nota1: double
        //-nota2: double
        //-nota3: double
        //+Aluno(int mat, string nome, double n1, double n2, double n3)
        //+ GetMatricula(): int
        //+GetNome(): string
        //+GetNotaFinal(): double
        //+GetResultado(): string


        //O método GetNotaFinal() deverá calcular e retornar a nota final do aluno, que consiste na média aritmética das três notas.
        //O método GetResultado() deverá retornar um string contendo o resultado final do aluno, de acordo com a seguinte tabela:
        //"Aprovado": nota final maior ou igual a 60 pontos.
        //"Recuperação": nota final entre 40 e 59 pontos, inclusive.
        //"Reprovado": nota inferior a 40 pontos.


        class Aluno
        {
            private int matricula;
            private string nome;
            private double nota1;
            private double nota2;
            private double nota3;



            Aluno(int mat, string nome, double n1, double n2, double n3)
            {
                this.matricula = mat;
                this.nome = nome;
                this.nota1 = n1;
                this.nota2 = n2;
                this.nota3 = n3;
            }
            public int GetMatricula()
            {
                return this.matricula;
            }
            public string GetNome()
            {
                return this.nome;
            }
            public double GetNota1()
            {
                return this.nota1;
            }
            public double GetNota2()
            {
                return this.nota2;
            }

            public double GetNota3()
            {
                return this.nota3;
            }


            public double GetNotaFinal()
            {
                return (this.nota1 + this.nota2 + this.nota3) / 3;
            }
            public string GetResultado()
            {
                double NotaFinal = GetNotaFinal();

                if (NotaFinal > 60)
                {
                    return "Aprovado";

                }
                else if (NotaFinal >= 40 && NotaFinal <= 59)
                {
                    return "Recuperação";
                }
                else
                {
                    return "Reprovado";

                }












            }
        }
    }
}

    
