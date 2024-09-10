using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero < 0)
        {
            Console.WriteLine($"O fatorial de {numero} não existe!");
        }
        else
        {
            Console.WriteLine($"O fatorial de {numero} é {Fatorial(numero)}");
        }
    }

    static int Fatorial (int somethingElse)
    {
        int resultado = 1;

        for (int counter = 1; counter <= somethingElse; counter++)
        {
            resultado = resultado * counter;
        }

        return resultado; // return Statement: The return statement sends the computed value back to the place where the method was called. Which is in line 16, in the Console.WriteLine. Essentially, the method is being evoked first with Fatorial(numero) and then its updated value is being used later on.
    }
}



    