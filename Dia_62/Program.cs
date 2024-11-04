// Seguindo aula "Utilizando operadores" em bata.io
// Fundamentos do C#

using System;

namespace MeyuApp
{
    class Program
    {
        static void Main(string[] args)
        {
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