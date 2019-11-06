using System;
using System.Collections.Generic;

namespace CSVReaderDataManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"D:\Repos\CSVReaderDataManipulation\CountryPopulations.csv";

            Reader csvreader = new Reader(filepath);

            List<Country> countries = csvreader.ReadAllCountries();

            Console.WriteLine("Enter no. of countries to display> ");
            bool inputIsInt = int.TryParse(Console.ReadLine(), out int userInput);
            if (!inputIsInt || userInput <= 0)
            {
                Console.WriteLine("You must type in a +ve integer. Exiting");
                return;
            }

            int maxToDisplay = Math.Min(userInput, countries.Count);

            //foreach(Country country in countries)
            for (int i =0; i<maxToDisplay; i++)
            {
                Country country = countries[i];
                Console.WriteLine($"{Formatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
            }
            Console.WriteLine($"{countries.Count} countries");
        }
    }
}
