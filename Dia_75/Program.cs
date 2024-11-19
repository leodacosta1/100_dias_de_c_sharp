using System;
using System.Collections.Generic;
using System.Linq;

namespace Dia_75
{
    class Program
    {
        // Definição da classe Town
        public class Town
        {
            public int City_Id { get; set; }
            public required string City_Name { get; set; }
            public bool IsSelected {get; set; }
        }

        // Definindo a lista com as cidades
        private static List<Town> cities = new List<Town>
        {
            new Town { City_Id = 1, City_Name = "São Paulo", IsSelected = false },
            new Town { City_Id = 2, City_Name = "Rio de Janeiro", IsSelected = false },
            new Town { City_Id = 3, City_Name = "Juiz de Fora", IsSelected = false },
        };

        static void Main(string[] args)
        {
            var filteredCities = cities.Where(town => town.City_Id > 1);
            foreach(var counter in filteredCities)
            {
                Console.WriteLine(counter.City_Name);
            }
        }
        
    }
}