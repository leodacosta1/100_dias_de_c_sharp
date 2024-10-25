
        Console.Write("Digite uma frase: ");
        string frase = Console.ReadLine();

        
        int numCaracteres = frase.Length;
        Console.WriteLine($"Número de caracteres: {numCaracteres}");

        
        string fraseInvertida = "";
        foreach (char c in frase)
        {
            fraseInvertida = c + fraseInvertida;
        }
        Console.WriteLine($"Frase invertida: {fraseInvertida}");


        string[] palavras = frase.Split(' ');
        Console.WriteLine("Palavras em linhas separadas:");
        foreach (string palavra in palavras)
        {
            Console.WriteLine(palavra);
        }