using System;

class Program
{
    static void Main(string[] args)
    {
        string continuarCalc = "s"; // aqui já assumo que a string tem o valor de "s" para poder executar uma vez a calculadora. Abaixo, vou mudar o valor de acordo com o input do usuário.
        
        while (continuarCalc == "s")
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
                    double resultSum = num1 + num2;
                    Console.WriteLine("O Resultado é: " + resultSum + " 乁( •_• )ㄏ");
                    break;
            
            
                case "2":
                    double resultSub = num1 - num2;
                    Console.WriteLine("O Resultado é: " + resultSub + " ( ͡• ͜ʖ ͡• )");
                    break;
            
                case "3":
                    double resultDiv = num1 / num2;
                    Console.WriteLine("O Resultado é: " + resultDiv + " （⌐■_■)");
                    break;
            
                case "4":
                    double resultMul = num1 * num2;
                    Console.WriteLine("O Resultado é: " + resultMul + " ᕕ(⌐■_■)ᕗ 🎉 ");
                    break;
            }

            Console.WriteLine("Deseja realizar outra operação? (s/n)");
            continuarCalc = Console.ReadLine();
        }
        
        Console.WriteLine("Calculadora encerrada. Até mais! ٩(◕‿◕｡)۶"); // esse texto foi sugerido pelo chatgpt com emoji e tudo, o que me deixou um pouco apreensivo.

    }
}

