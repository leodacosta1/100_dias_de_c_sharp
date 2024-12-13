// Fundamentos do C# em balta.io
// Mão na massa: Cronômetro

using System;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
            //Start(6); // trocamos a declaração da variável time de dentro da função Start (int time = 6;) para usar como parâmetro: Start(int time). Então, ao chamarmos a função, declaramos um valor, que vai ser usado pelo parâmetro time.  
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundo => 10s = 10 segundos");
            Console.WriteLine("M = Minuto => 1m = 1 minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quando tempo deseja contar?");

            string data = Console.ReadLine().ToLower(); // não precisamos converter a saída de console.readline porque o usuário vai digitar um número junto com uma letra (10s ou 10m), que é uma string. ToLower é um método de string que converte os caracteres para minúsculo e portanto não precisamos fazer uma verificação só pra checar se o valor foi inserido em maísculas ou minúsculas
            char type = char.Parse(data.Substring(data.Length-1,1)); // os parâmetros de Substring são o valor inicial (conta a posição de um caracter em uma string com valor inicial de 0, como em em array) e a quantidade de caracteres que a gente quer pegar. se data = fruta, data.Substring(1,1) é igual a 'r' (1 caractere na posição 1) que retorna como uma string. Por isso precisamos fazer uma conversão explícita para assimilarmos o valor ao tipo char.
            // pra encontrarmos a posição do último caractere, contamos o total de caracteres com .Length e subtraímos 1, pois a soma de caracteres começa com 1 e a posição em um caractere começa com 0.

            // Abaixo a evolução do código a partir da linha de raciocínio explicada acima:
            // char type = data.Substring(1,1);
            // char type = char.Parse(data.Substring(1,1));
            // char type = char.Parse(data.Substring(data.Length-1,1));
            int time = int.Parse(data.Substring(0,data.Length - 1)); // Susbstring pega um pedaço da string, no caso data. Como já pegamos o último caractere com char type, podemos pedir um valor que seja a contagem total de caracteres de data, menos 1. Ou seja, percorremos da posição zero até a penúltima da string.

            Console.WriteLine(type);
            Console.WriteLine(time);
        }

        // inicia o cronômetro
        static void Start(int time)
        {
            // int time = 6;
            int currentTime = 0;

            //exibe o temporizador
            while (currentTime != time)
            {
                Console.Clear(); // aqui a gente limpa os números já contados para visualizarmos somente o número sendo contado no momento
                currentTime++;
                Console.WriteLine(currentTime); // aqui exibimos os números, ou melhor, o número atual, por conta do Console.Clear, mas o processador é muito rápido e não conseguimos visualizar a contagem. Por isso usamos o Thread.Sleep()

                // Thread trabalha com a execução atual do processador. Vamos usar Thread para fazer o cronômetro esperar 1s antes de passar para o próximo número
                Thread.Sleep(1000); // 1000 milissegundos
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado");
            Thread.Sleep(2500); // Esse Thread.Sleep é usado para dar uma pausa (de 2,5s) antes do programa voltar para o menu
        }
    }
}