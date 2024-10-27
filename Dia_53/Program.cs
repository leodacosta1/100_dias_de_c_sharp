using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o valor principal: ");
        float valorPrincipal = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite a taxa de juros anual (%): ");
        float taxaDeJuros = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite a quantidade de anos: ");
        int quantidadeDeAnos = int.Parse(Console.ReadLine());

        float montante = CalculaJurosCompostos(valorPrincipal, taxaDeJuros, quantidadeDeAnos);

        Console.WriteLine($"O montante após {quantidadeDeAnos} anos será: {montante:F2}");
    }
    static float CalculaJurosCompostos(float valorPrincipal, float taxaDeJuros, int quantidadeDeAnos)
    {
        float montante = valorPrincipal * (float)Math.Pow(1 + (taxaDeJuros / 100), quantidadeDeAnos);
        return montante;
    }
}