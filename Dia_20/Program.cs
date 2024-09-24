// Microsoft C# Training Module
// Write your first code using C# (Get started with C#, Part 1) 
// Guided project - Calculate and print student grades
// Unit 5 of 7


decimal currentAssignments = 5m;

int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;

int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;

int zahirah1 = 84;
int zahirah2 = 96;
int zahirah3 = 73;
int zahirah4 = 85;
int zahirah5 = 79;

int jeong1 = 90;
int jeong2 = 92;
int jeong3 = 98;
int jeong4 = 100;
int jeong5 = 97;


// storing the sum for each student
int sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
int nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
int zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
int jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;

// opcional: usar (decimal) antes de alguma das variáveis do lado direito do operador de atribuição de resultado pra converter int pra decimal,
// possibilitando o resultado com vírgula
decimal sophiaScore = sophiaSum / currentAssignments;
decimal nicolasScore = nicolasSum / currentAssignments;
decimal zahirahScore = zahirahSum / currentAssignments;
decimal jeongScore = jeongSum / currentAssignments;

// Referência de valores pra usar no switch statement
// 97 - 100    A+
// 93 - 96     A
// 90 - 92     A-
// 87 - 89     B+
// 83 - 86     B


// Criando switch loop pra atribuir grade pras notas
// E iniciando a variável sophiaScoreGrade com o valor vazio, pra incrementar com a string da grade pro programa não tentar converter string pra decimal, o que causa erro.


string sophiaScoreGrade = "";
switch (sophiaScore)
{
    case decimal n when n >= 97.0m: // a variável sophiaScore, usada como parâmetro é então armazenado e o primeiro "n" é uma declaração de variável que atua como placeholder
        sophiaScoreGrade += "\tA+";
        break;
    case decimal n when n >= 93.0m && n <= 96.0m:
        sophiaScoreGrade += "\tA";
        break;
    case decimal n when n >= 90.0m && n <= 92.0m:
        sophiaScoreGrade += "\tA-";
        break;
    case decimal n when n >= 87.0m && n <= 89.0m:
        sophiaScoreGrade += "\tB+";
        break;
    case decimal n when n >= 83.0m && n <= 96.0m:
        sophiaScoreGrade += "\tB";
        break;
    
}


Console.WriteLine("Student Grade \n");
Console.WriteLine("Sophia:\t\t" + sophiaScore + sophiaScoreGrade);
Console.WriteLine("Nicolas:\t" + nicolasScore + "\tB");
Console.WriteLine("Zahirah:\t" + zahirahScore + "\tB");
Console.WriteLine("Jeong:\t\t" + jeongScore + "\tA");

