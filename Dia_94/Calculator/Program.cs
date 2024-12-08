// Fundamentos do C# em balta.io
// Mão na massa: Criando uma calculadora
// Utilizando funções

using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Soma();
        }

        static void Soma() 
        {
            Console.Clear();
            // aqui, se não usarmos o .Parse(), o compilador acusa que não podemos fazer uma conversão implícita, já que o ReadLine() espera uma string. Estaríamos, portanto, sem o .Parse(), tentando converter implicitamente uma string para um float, a partir do momento em que declaramos que ela assumiria o valor da float var1.
            Console.WriteLine("Primeiro valor: ");
            float var1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float var2 = float.Parse(Console.ReadLine());

            Console.WriteLine(""); // Esse comando é só pro Console pular uma linha

            float resultado = var1 + var2;
            Console.WriteLine($"O Resultado da soma é {resultado}");
        }
    }
}