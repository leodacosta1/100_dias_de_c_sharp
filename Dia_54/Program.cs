using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite seu texto: ");
        string texto = Console.ReadLine();

        int palavras = texto.Split(new char[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries).Length;
        int frases = texto.Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
        int caracteres = texto.Length;

        Console.WriteLine($"Número de palavras: {palavras}");
        Console.WriteLine($"Número de frases: {frases}");
        Console.WriteLine($"Número de caracteres: {caracteres}");
    }
}
