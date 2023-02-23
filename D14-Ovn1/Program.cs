using System;

internal class Program
{
    class Country
    {
        public string country;
        public string rule;
        public string capital;
        public int population;

        public void print()
        {
            System.Console.WriteLine($"Country: {country}");
            System.Console.WriteLine($"Rule: {rule}");
            System.Console.WriteLine($"capital: {capital}");
            System.Console.WriteLine($"Population: {population} \n");
        }
    }
    private static void Main(string[] args)
    {
        Country sweden = new Country() { country = "Sweden" , rule="Monarch", capital = "Stockholm", population= 10512820 };
        Country germany = new Country() { country = "Germany", rule = "Republic", capital = "Berlin", population = 83783902 };
        Country sanMarino = new Country() { country = "San Marino", rule = "Republic", capital = "San Marino", population = 33600 };
    }
}