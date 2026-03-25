using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPilha
{
    internal class Pilha
    {
        private int[] vetor;
        private int topo;

        public Pilha(int capacidade)
        {
            vetor = new int[capacidade];
        }

        public bool vazio()
        {
            return topo == 0;
        }
        public bool cheia()
        {
            return topo == vetor.Length;
        }

        public void empilhar(int valor)
        {
            if (!cheia())
            {
                vetor[topo] = valor;
                topo++;
            }
        }
        public int desempilhar()
        {
            if (!vazio())
            {
                topo--;
                return vetor[topo];
            }
            return 0;
        }
        public void imprimir()
        {
            string itens = "";

            for (int i = 0; i < topo; i++)
            {
                itens += $"{vetor[i]}, ";
                Console.WriteLine($"[ {(itens.Length == 0 ? itens : itens.Substring(0, itens.Length - 2))} ]");


            }

        }
    }
}
