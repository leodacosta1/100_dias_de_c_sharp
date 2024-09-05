using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um número: ");
        int number1 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite o segundo número: ");
        int number2 = int.Parse(Console.ReadLine());

        int result = number1 + number2;

        Console.WriteLine("A soma dos números é: " + result);
        
    }
}