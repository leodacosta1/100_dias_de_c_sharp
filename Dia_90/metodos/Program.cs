using System;

namespace MeuApp;
class Program
{
    static void Main(string[] args)
    {
        MeuMetodo();

        string nome = RetornaNome("Leonardo", "Dacosta");
        Console.WriteLine(nome);
    }

    static void MeuMetodo()
    {
        Console.WriteLine("C# é legal");
    }

    static string RetornaNome(
        string nome,
        string sobrenome,
        int idade = 37, // uma forma de tornar o parâmetro idade como opcional é atribuir um valor diretamente na definição do método
        bool teste = false,
        double novo = 33.42
    )
    {
        return nome + " " + sobrenome + " tem " + idade.ToString();
    }
}