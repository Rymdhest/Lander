using System;

internal class Program
{
    class Person
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
    
    }
}