// Seguindo aula " Estrutura condicional: Switch" em balta.io
// Fundamentos do C#

using System;

namespace MeyuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // podemos pensar em um uso pro switch comparar valores de uma variável booleana
            // utilizando o nullable type. Se usarmos apenas bool valor = true;
            // o uso do default seria redundante, pois um valor booleano pode ser apenas true ou false
            // mas a partir do momento em que definimos a variável valor como um nullable type, a variável
            // pode receber 3 tipos diferentes de valor: true, false ou null.
            //
            // [
            // penso que isso pode ser útil para casos em que vamos comparar com um
            // Console.ReadLine() por exemplo, em que o valor é essencialmente nulo até o momento
            // em que recebemos o input do usuário.
            // ] 
            bool? valor = null;
            
            switch (valor)
            {
                case true: Console.WriteLine("verdadeiro");
                break;
                
                case false: Console.WriteLine("falso");
                break;

                default: Console.WriteLine("Nulo");
            }
        }
    }
}