// Fundamentos do C#, aula do curso grátis em balta.io
// Structs e Enums

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
            Product mouse = new Product(1, "Mouse gamer", 299.97, EProductType.Product);
            var manutencaoEletrica = new Product(2, "Manutenção Elétrica Residencial", 500, EProductType.Service);

            // Para sobrescrever o valor de uma propriedade, basta escrevermos o nome do objeto, ponto e a propriedade:
            mouse.Id = 55;

            Console.WriteLine(mouse.Id);
            Console.WriteLine(mouse.Name);
            Console.WriteLine(mouse.Price);
            Console.WriteLine((int)mouse.Type); // fazendo conversão explícita
        }
    }

    // Um struct não pode ser criado dentro do método principal e nem dentro de uma classe.
    // Um struct é composto de propriedades e métodos
    
    struct Product 
    {
        // Criando método construtor
        // a gente recebeu como parâmetros os itens id, name e price e recebeu nas propriedades
        public Product(int id, string name, double price, EProductType type) 
        {
            Id = id; // Proprieade Id recebe o parâmetro id
            Name = name; // Propriedade Name recebe o parâmetro name
            Price = price;
            Type = type;
        }

        public int Id;
        public string Name;
        public double Price;
        public EProductType Type;

        public double PriceInDollar(double dollar)
        {
            return Price * dollar;
            // Com P maiúsculo, sabemos que Price é uma propriedade, como definido em public double Price;
            // com d minúsculo, dollar é um parâmetro, como definido em parênteses, na definição do método
        }
    }

    // Enumeradores são usados para fornecer uma melhor visualização do código
    // são definidos fora de uma classe e fora de um struct
    // Substituem o uso de inteiros
    // Para o exemplo de definição de estado civil, não podemos usar bool pois há ~6 estados diferentes. E ao usar um int, não fica intuitivo, pois não sabemos de antemão qual valor foi atribuído ao estado de solteiro, de casado etc.
    // Como boa prática, sempre começamos o nome de um Enum com um E maiúsculo

    // Exemplo:
    /*
    enum EEstadoCivil
    {
        Solteiro = 1,
        Casado = 2,
        Divorcidado = 3
    }

    struct Cliente
    {
        public string Nome;
        public EEstadoCivil EstadoCivil;
    }

    // ao instanciar um cliente, podemos usar um Enumerador ao invés de um inteiro

    var cliente = new Cliente("João Silva", EEstadoCivil.Casado);
    */

    enum EProductType
    {
        Product = 1,
        Service = 2
    }
}