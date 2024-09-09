using System;

class Program
{
    static void Main(string[] args)
    {
        string novoCalc = "s"; // aqui já assumo que a string tem o valor de "s" para poder executar uma vez a calculadora. Abaixo, vou mudar o valor de acordo com o input do usuário.
        
        double result = 0;
        
        while (novoCalc == "s")
        {
            Console.WriteLine("Digite um número de 1 a 4 para a operação que você quer realizar entre dois números: ");
            Console.WriteLine("1.Soma");
            Console.WriteLine("2.Subtração");
            Console.WriteLine("3.Divisão");
            Console.WriteLine("4.Multiplicação");
            string operacao = Console.ReadLine();


            Console.WriteLine("Digite um número: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o outro número: ");
            double num2 = double.Parse(Console.ReadLine());
            
                
            switch(operacao)
            {
                case "1":
                    result = num1 + num2;
                    Console.WriteLine("O Resultado é: " + result + " 乁( •_• )ㄏ");
                    break;
            
            
                case "2":
                    result = num1 - num2;
                    Console.WriteLine("O Resultado é: " + result + " ( ͡• ͜ʖ ͡• )");
                    break;
            
                case "3":
                    result = num1 / num2;
                    Console.WriteLine("O Resultado é: " + result + " （⌐■_■)");
                    break;
            
                case "4":
                    result = num1 * num2;
                    Console.WriteLine("O Resultado é: " + result + " ᕕ(⌐■_■)ᕗ 🎉 ");
                    break;
            }

            Console.WriteLine("Deseja realizar uma operação com esse resultado? (s/n)");
            string continuarCalc = Console.ReadLine();
            
            while (continuarCalc == "s")
            {
                Console.WriteLine("Digite um número de 1 a 4 para a operação que você quer realizar com o resultado anterior: ");
                Console.WriteLine("1.Soma");
                Console.WriteLine("2.Subtração");
                Console.WriteLine("3.Divisão");
                Console.WriteLine("4.Multiplicação");
                string continuarOperacao = Console.ReadLine();
                
                Console.WriteLine("Digite um número: ");
                double num3 = double.Parse(Console.ReadLine());
                

                switch(continuarOperacao)
                {
                    case "1":
                        result += num3;
                        Console.WriteLine("O Resultado é: " + result + " 乁( •_• )ㄏ");
                        break;
                
                
                    case "2":
                        result -= num3;
                        Console.WriteLine("O Resultado é: " + result + " ( ͡• ͜ʖ ͡• )");
                        break;
                
                    case "3":
                        result /= num3;
                        Console.WriteLine("O Resultado é: " + result + " （⌐■_■)");
                        break;
                
                    case "4":
                        result *= num3;
                        Console.WriteLine("O Resultado é: " + result + " ᕕ(⌐■_■)ᕗ 🎉 ");
                        break;
                }
                
                // Essas duas linhas resolvem o problema do programa sempre retornar a executar operações sem dar opção de fechar, apesar de obrigar o usuário a responder duas vezes se quer fazer outra operação com o resultado
                Console.WriteLine("Deseja realizar uma operação com esse resultado? (s/n)");
                continuarCalc = Console.ReadLine();
            }

            Console.WriteLine("Deseja realizar uma operação com esse resultado? (s/n)");
            continuarCalc = Console.ReadLine();

            Console.WriteLine("Deseja realizar outra operação? (s/n)");
            novoCalc = Console.ReadLine();
        }
        
        Console.WriteLine("Calculadora encerrada. Até mais! ٩(◕‿◕｡)۶"); // texto foi sugerido pelo chatgpt com emoji e tudo

    }
}

