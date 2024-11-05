// Seguindo aula "Utilizando If" em balta.io
// Fundamentos do C#

using System;

namespace MeyuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 18;
            int maioridade = 21;
            int idadeMaxima = 65;

            // pra usar uma expressão booleana com o operador de comparação, basta colocar
            // a operação dentro de parênteses
            if (!(idade <= maioridade))
                Console.WriteLine("É diferente");
            else
                Console.WriteLine("É igual");
            
            Console.WriteLine("Finalizou o programa");
        }
    }
}