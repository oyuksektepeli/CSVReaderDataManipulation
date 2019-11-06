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
            

            //foreach(Country country in countries)
            for (int i =0; i<countries.Count; i++)
            {
                Country country = countries[i];
                Console.WriteLine($"{Formatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
            }
            Console.WriteLine($"{countries.Count} countries");
        }
    }
}
