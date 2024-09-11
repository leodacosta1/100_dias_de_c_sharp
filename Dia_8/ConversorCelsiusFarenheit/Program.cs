using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a temperatura em Celsius: ");
        float celsius = float.Parse(Console.ReadLine());

        float farenheit = (celsius * 1.8f) + 32f;

        Console.WriteLine($"A temperatura em Farenheit é {farenheit}");
    }
}