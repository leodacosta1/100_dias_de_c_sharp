// Programa que analisa um texto fornecido pelo usuário, contando o número
// de palavras, frases e caracteres.

using System;
using System.Text.RegularExpressions;

Console.WriteLine("Digite o texto que deseja analisar:");
string texto = Console.ReadLine();

int numeroDeCaracteres = texto.Length;

// Dividindo o texto por espaços em branco para contar palavras
string[] palavras = texto.Split(new char[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);
int numeroDePalavras = palavras.Length;

// Usando regex para contar frases (considera '.' , '!' e '?' como fim de frase)
int numeroDeFrases = Regex.Matches(texto, @"[.!?]").Count;

Console.WriteLine("Análise do texto:");
Console.WriteLine($"Número de caracteres: {numeroDeCaracteres}");
Console.WriteLine($"Número de palavras: {numeroDePalavras}");
Console.WriteLine($"Número de frases: {numeroDeFrases}");