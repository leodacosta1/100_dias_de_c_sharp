//programa simples pra criar strings que possam serem usadas no comando mkdir Dia_1 Dia_2 etc pra criar 100 pastas em um só comando
using System;

class Program
{
    static void Main(string[] args)
    {
        int dia = 0;

        for (int i = 1; i <= 100; i++)
        {
            dia++;
            Console.Write("Dia_" + dia + " ");
        }
    }
}


