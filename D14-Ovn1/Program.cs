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

        Country[] countries = new Country[7];
        countries[0] = sweden;
        countries[1] = germany;
        countries[2] = sanMarino;

        countries[3] = new Country() { country = "Denmark", rule = "Monarch", capital = "Stockholm", population = 5928364 };
        countries[3] = new Country() { country = "Italy", rule = "Republic", capital = "Rom", population = 58853482 };
        countries[3] = new Country() { country = "Czech", rule = "Republic", capital = "Prague", population = 10551219 };
        countries[3] = new Country() { country = "Romania", rule = "Republic", capital = "Bukarest", population = 19760314 };
    }
}