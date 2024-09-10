using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um número: ");
        int tabuada = int.Parse(Console.ReadLine());
        int tabela = 0;

        do
        {
            int resultado = tabuada * tabela;
            Console.WriteLine($"{tabuada} x {tabela} = {resultado}");
            tabela++;
        } while (tabela <= 10);
    }
}



    