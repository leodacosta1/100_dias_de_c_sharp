// Fundamentos do C#
// balta.io

using System;

namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("O que que você quer, ein?");
            Console.WriteLine("1 - Abrir arquivo");
            Console.WriteLine("2 - Criar novo arquivo");
            Console.WriteLine("0 - Sair");
            short option = short.Parse(Console.ReadLine());

            switch(option)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Abrir(); break;
                case 2: Editar(); break;
                default: Menu(); break;
            }
        }
        
        static void Abrir(){}

        static void Editar()
        {
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo (ESC para sair)");
            Console.WriteLine("-----------------------");
            string text = "";

            // faça algo
            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine; // quebra a linha no fim de cada leitura de linha
            }
            // enquanto o usuário não apertar a tecla ESC
            // aqui fica um exemplo perfeito do uso de um do while ser mais adequado que um while. Se fosse apenas while, o programa esperaria um input pra executar o código, visto que estamos usando o ReadKey dentro do parâmetro do laço de repetição
            while (Console.ReadKey().Key != ConsoleKey.Escape); // ReadKey().Key lê a tecla

            Console.Write(text);
        }
    }
}