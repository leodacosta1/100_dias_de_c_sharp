// Enunciado: encontre a média de salário entre os funcionários de TI

using System;
using System.Collections.Generic;
using System.Linq; // Needed for the 'Where' clause

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

        // Filter for employees in the "TI" department
        foreach (var counter in employees)
        {
            if (counter.Departamento == "TI")
            {
                Console.WriteLine($"{counter.Salario}");
            }
        }         
    }
}


