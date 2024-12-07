// Fundamentos do C# em balta.io
// Mão na massa: Criando uma calculadora

using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            // aqui, se não usarmos o .Parse(), o compilador acusa que não podemos fazer uma conversão implícita, já que o ReadLine() espera uma string. Estaríamos, portanto, sem o .Parse(), tentando converter implicitamente uma string para um float, a partir do momento em que declaramos que ela assumiria o valor da float var1.
            float var1 = float.Parse(Console.ReadLine());

            Console.WriteLine(var1);
        }
    }
}