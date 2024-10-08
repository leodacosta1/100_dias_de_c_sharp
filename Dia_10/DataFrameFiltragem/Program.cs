﻿// Enunciado: encontre a média de salário entre os funcionários de TI

using System;
using System.Collections.Generic;

class Employee
{
    public string Nome { get; set; }
    public string Departamento { get; set; }
    public int Salario { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // Initialize list inside the Main method
        List<Employee> employees = new List<Employee>
        {
            new Employee { Nome = "Ana", Departamento = "TI", Salario = 5000 },
            new Employee { Nome = "João", Departamento = "RH", Salario = 4500 },
            new Employee { Nome = "Maria", Departamento = "TI", Salario = 5200 },
            new Employee { Nome = "Pedro", Departamento = "Financeiro", Salario = 6000 },
            new Employee { Nome = "Lucas", Departamento = "TI", Salario = 4800 },
            new Employee { Nome = "Carla", Departamento = "RH", Salario = 4700 }
        };

        int somaSalarial = 0; // iniciando variável para armazenar a soma dos valores encontrados na variável int Salario dos objetos da lista Employee.
        int funcionariosTI = 0; // aqui essa variável é usada para incrementar no foreach loop a fim de poder contar o número de objetos com o valor TI na string Departamento.

        // Filter for employees in the "TI" department
        foreach (var counter in employees)
        {
            if (counter.Departamento == "TI")
            {
                somaSalarial = somaSalarial + counter.Salario;
                funcionariosTI++;          
            }
        }
        if (funcionariosTI > 0)
        {
            int mediaSalarial = somaSalarial / funcionariosTI;
            Console.WriteLine($"Existem {funcionariosTI} funcionários de TI recebendo um total de {somaSalarial} com uma média salarial de {mediaSalarial}.");
        }
        else
        {
            Console.WriteLine("Não há funcionários na área de TI");
        }
    }
}


