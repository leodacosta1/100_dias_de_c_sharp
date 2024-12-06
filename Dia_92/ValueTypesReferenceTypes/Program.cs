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

            var arr = new string[2];
            arr[0] = "Item 1";

            var arr2 = arr;
            Console.WriteLine(arr[0]);
            Console.WriteLine(arr2[0]);

            arr[0] = "Item 2";
            Console.WriteLine(arr[0]);
            Console.WriteLine(arr2[0]);

            // Aqui a situação é diferente e o exemplo do pôster já não funciona, porque arrays são Reference Types, ao invés de Value Types. Significa que quando atribuímos o valor do segundo array ao primeiro array, não criamos uma cópia, mas criamos uma referência. 
        }
    }
}

