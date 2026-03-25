using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassPilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vet = { 1,2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Pilha par = new Pilha ( vet.Length / 2 );
            Pilha impar = new Pilha ( vet.Length / 2 );



            for (int i = 0; i < vet.Length; i++)
            {
                if (vet[i] % 2 == 0)
                {
                    par.empilhar(vet[i]);

                
                }
                else
                {
                    impar.empilhar(vet[i]);
                }
            }
            for(int i = 0; i<vet.Length/2; i++)
            {
                int p = par.desempilhar();
                int ip = impar.desempilhar();

                vet[i * 2] = p;
                vet[i * 2 + 1] = ip;
            }
            for(int i = 0; i< vet.Length; i++)
            {
                Console.WriteLine(vet[i]);
            }
            Console.ReadKey();
            



        }

       

        }
    }
 