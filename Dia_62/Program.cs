// Seguindo aula "Utilizando operadores" em balta.io
// Fundamentos do C#

using System;

namespace MeyuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // utilizamos o double a fim de obter resultados com números reais,
            // caso haja, por exmeplo, uma divisão de 75 / 23.5
            double x = 2;
            double y = 2;
            x = (2 + 2) * 2;
            y = 2 + (2 * 2);
            bool z = x == y;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }
    }
}