using System;

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 25;
            int y = x;
            Console.WriteLine(x);
            Console.WriteLine(y);

            x = 32;
            Console.WriteLine(x);
            Console.WriteLine(y);

            // O Motivo de x ter ficado com o valor de 32 e y ter mantido 25 é que quando fazemos uma atribuição, como em "int y = x", nós criamos uma cópia desse valor em memória. A relação entre as duas variáveis não é permanente; ela existe apenas no momento do cálculo da atribuição para que a cópia seja feita.

            // Um exemplo seria um pôster impresso. Imprimimos um pôster. Para criarmos um segundo pôster, podemos apenas copiar a partir do primeiro. Em seguida, modificamos, à mão, o design do primeiro pôster. O segundo poster, portanto, teria uma aparência diferente do primeiro.
        }
    }
}

