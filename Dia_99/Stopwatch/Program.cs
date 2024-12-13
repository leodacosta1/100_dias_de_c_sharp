// Fundamentos do C# em balta.io
// Mão na massa: Cronômetro

using System;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        // inicia o cronômetro
        static void Start()
        {
            int time = 10;
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
        }
    }
}