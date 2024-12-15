// Fundamentos do C#
// balta.io

using System;
using System.IO;

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
        
        static void Abrir()
        {
            Console.Clear();
            Console.WriteLine("Qual caminho do arquivo?");
            string path = Console.ReadLine();

            // a gente usa o using sempre que a gente vai ler ou salvar um arquivo
            using(var file = new StreamReader(path))
            {
                string text = file.ReadToEnd();
                Console.WriteLine(text);
            }

            Console.WriteLine("");
            Console.ReadLine();
            Menu();
        }

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

            Salvar(text);
        }

        static void Salvar(string text)
        {
            Console.Clear();
            Console.WriteLine("Qual caminho para salvar o arquivo?");
            var path = Console.ReadLine();

            // objeto para abrir um arquivo
            // new StreamWriter ou StreamReader
            // Stream é fluxo e Writer é escritor, ou escrita. Fluxo de escrita (de bytes). Um fluxo de bytes é um arquivo. Todos arquivos são essencialmente um fluxo de bytes.
            // mas pra abrir um arquivo, sempre precisamos fechá-lo pra evitar problemas de memória. Então usamos o using()
            // Toda vez que usamos o using com um objeto como parâmetro, o using cria, abre, usa e fecha o objeto automaticamente.


            using(var file = new StreamWriter(path)) // StreamWriter sempre pede como parâmetro um caminho pro arquivo, que já fornecemos com a variável path 
            {
                file.Write(text);
            }

            Console.WriteLine($"Arquivo {path} salvo com sucesso!");
            Console.ReadLine();
            Menu();
        }
    }
}