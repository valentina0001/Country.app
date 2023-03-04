using System.Linq;
using System;

namespace Country.App
{
    class Country
    {
        public string Name { get; set; }
        public int Population { get; set; }

        public Country(string name, int population)

        {
            this.Name = name;
            this.Population = population;
        }

    }
    public class Program
    {
        public static void Main()

        {
            Country[] countryCollection = {
                new Country("Afganistan", 34656032),
                new Country("Austria", 8857960),
                new Country("Brazil", 210147125),
                new Country("Denmark", 5789957),
                new Country("Russia", 144526636),
                new Country("China", 1403500365),
                new Country("Turkey", 80810525),
                new Country("Serbia", 7001444),
                new Country("Iraq", 37202572),
                new Country("San Marino", 33344)
            };

            Console.WriteLine("Countries sorted by descending population numbers:\n");

            var countryInfo = from country in countryCollection
                              orderby country.Population descending, country.Name
                              select country;

            foreach (Country Country in countryInfo)
            {
                Console.WriteLine(String.Format("Country: {0}, Population: {1}", Country.Name, String.Format("{0:#,###,###.##}", Country.Population)));
            }


        }
    }
}


