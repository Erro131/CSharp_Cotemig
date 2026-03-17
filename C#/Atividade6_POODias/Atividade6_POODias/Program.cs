using Microsoft.SqlServer.Server;
using System;

public class TestaData
{
    public static void Main()
    {
        // Cria uma data
        Data d = new Data(29, 2, 2024);

        // Mostra a data formatada
        Console.WriteLine("Data digitada: " + d.Formatar());

        // Mostra se é válida
        if (d.Validar())
        {
            Console.WriteLine("Resultado: Esta data e valida.");
        }
        else
        {
            Console.WriteLine("Resultado: Esta data e invalida.");
        }

        // Testando um Set e um Get
        d.SetMes(13);
        Console.WriteLine("Nova data alterada: " + d.Formatar());
        Console.WriteLine("Valida apos erro? " + d.Validar());
    }
    public class Date
    {

        private int dia;
        private int mes;
        private int ano;

        public Date(int dia, int mes, int ano)
        {
            this.dia = dia;
            this.mes = mes;
            this.ano = ano;
        }

        // Ajuste necessário para os sets funcionarem no C#
        public void setDia(int dia) { this.dia = dia; }
        public void setMes(int mes) { this.mes = mes; }
        public void setAno(int ano) { this.ano = ano; }

        public int getDia() { return dia; }
        public int getMes() { return mes; }
        public int getAno() { return ano; }

        public string formatar()
        {
            return this.dia + "/" + this.mes + "/" + this.ano;
        }

        public bool validar()
        {
            if (dia < 1) return false;
            if (mes < 1 || mes > 12) return false;
            if (ano < 1900 || ano > 2099) return false;

            switch (mes)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    if (dia > 31) return false;
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    if (dia > 30) return false;
                    break;

                default:
                    if ((ano % 400 == 0) || (ano % 4 == 0 && ano % 100 != 0))
                    {
                        if (dia > 29) return false;
                    }
                    else
                    {
                        if (dia > 28) return false;
                    }


            }
            return true;

        }

    }

}