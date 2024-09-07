using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Posso realizar operações matemáticas simples, como: ");
        Console.WriteLine("Soma");
        Console.WriteLine("Subtração");
        Console.WriteLine("Divisão");
        Console.WriteLine("Multiplicação");
        Console.WriteLine("Qual você quer que eu faça?");

        string resposta = Console.ReadLine().Trim().ToLower(); // guarda a resposta do usuário em uma string para ser chamada posteriormente, se a condição for alcançada

        switch(resposta == "Soma") // agora usando a string que a gente criou pra guardar aquela resposta ali em cima
        {
            case 1:
                Console.WriteLine("Digite um número: ");
                double numberSum1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite um outro número: ");
                double numberSum2 = double.Parse(Console.ReadLine());

                double resultSum = numberSum1 + numberSum2;
                Console.WriteLine("O Resultado é: " + resultSum);
                break;
            
        }
    }
}
