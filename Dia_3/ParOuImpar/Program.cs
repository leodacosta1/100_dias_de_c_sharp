using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("É par ou ímpar? Digite um número inteiro com até 10 dígitos: ");
        int number = int.Parse(Console.ReadLine());

        if(number % 2 == 0)
        {
            Console.WriteLine("É par!");
        }
        else
        {
            Console.WriteLine("É ímpar!");
        }

        if(number % 10 == 2)
        {
            Console.WriteLine("Qual o menu de hoje?");
            string resposta = Console.ReadLine().Trim().ToLower(); // guarda a resposta do usuário em uma string para ser chamada posteriormente, se a condição for alcançada

            if(resposta == "miojo") // agora usando a string que a gente criou pra guardar aquela resposta ali em cima
            {
                Console.WriteLine("Muito bem, velho. 2. vez 1. Diga!");
                Console.WriteLine("Tu não é o fodão?");
                string segundaResposta = Console.ReadLine().Trim().ToLower(); // guardando a segunda resposta agora, Trim() cortando espaços vazios e ToLower() deixando tudo caixa baixa
                
                if(segundaResposta == "2")
                {
                    Console.WriteLine("AAAAAAAAAAAAAAAAAAAAHHHHHHHH!");
                    return;
                }
                else
                {
                    Console.WriteLine("Game Over");
                }
            }
            else
            {
                Console.WriteLine("Game Over");
            }
        }
    }
}