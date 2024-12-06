// Fundamentos do C#, aula do curso grátis em balta.io
// Structs

using System;

namespace MeuApp
{
    class Program

    {
        static void Main(string[] args)
        {
            // Para instanciar uma estrutura, podemos usar var ou o nome do tipo
            // Podemos também criar passando parâmetro ou sem passar nenhum parâmetro (parametereless)
            // Se for parameterless, ele não passa pelo método public Product e portanto os valores nesse exemplo serão 0, vazio e 0.
            //Product(ou var) mouse = new Product();
            Product mouse = new Product(1, "Mouse gamer", 299.97);

            // Para sobrescrever o valor de uma propriedade, basta escrevermos o nome do objeto, ponto e a propriedade:
            mouse.Id = 55;

            Console.WriteLine(mouse.Id);
            Console.WriteLine(mouse.Name);
            Console.WriteLine(mouse.Price);
        }
    }

    // Um struct não pode ser criado dentro do método principal e nem dentro de uma classe.
    // Um struct é composto de propriedades e métodos
    
    struct Product 
    {
        // Criando método construtor
        // a gente recebeu como parâmetros os itens id, name e price e recebeu nas propriedades
        public Product(int id, string name, double price) 
        {
            Id = id; // Proprieade Id recebe o parâmetro id
            Name = name; // Propriedade Name recebe o parâmetro name
            Price = price;
        }

        public int Id;
        public string Name;
        public double Price;

        public double PriceInDollar(double dollar)
        {
            return Price * dollar;
            // Com P maiúsculo, sabemos que Price é uma propriedade, como definido em public double Price;
            // com d minúsculo, dollar é um parâmetro, como definido em parênteses, na definição do método
        }
    }
}