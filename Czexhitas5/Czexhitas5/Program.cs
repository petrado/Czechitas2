using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Czexhitas5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // ==========================================
            // 1. Nalezněte slova začínající písmenem 'M'
            List<string> ovoce = new List<string>() { "Merunka", "Jablko", "Pomeranc", "Meloun", "Malina", "Limetka" };

            // 1. Řešení
            List<string> mOvoce = ovoce.Where(m => m.StartsWith("M", StringComparison.OrdinalIgnoreCase)).ToList();
            // List<string> mOvoce = ovoce.Where(m => m.Equals("M", StringComparison.OrdinalIgnoreCase)).ToList();
            // equals, startswith

            foreach (string o in mOvoce)
            {
                Console.WriteLine(o);
            }


            // ==========================================		
            // 2. Která z následujících čísel jsou násobky 4 nebo 6
            List<int> ruznaCisla = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            // 2. Řešení

            bool isThereAny = ruznaCisla.Any(num => num % 4 == 0 || num % 6 == 0);
            List<int> nasobky4a6 = ruznaCisla.Where(num => num % 4 == 0 || num % 6 == 0).ToList();

            foreach (int cislo in nasobky4a6)
            {
                Console.WriteLine(cislo);
            }

            // 3. Kolik je v seznamu ruznaCisla čísel?
            Console.WriteLine($"The count of the numbers is: {nasobky4a6.Count()}");


            // ==========================================
            // 5. Kolik je celkový součet?
            List<double> utrata = new List<double>()
        {
            2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
        };

            // 5. Řešení
            Console.WriteLine($"The sum of the numbers is: {utrata.Sum()}");

            // ==========================================		
            // 6. Jaké je největší cena?
            List<double> cena = new List<double>()
        {
            879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
        };

            // 6. Řešení
            Console.WriteLine($"The sum of the numbers is: {cena.Max()}");

            // ==========================================
            // 4. Seřaďte jména vzestupně
            List<string> jmena = new List<string>()
        {
            "Hana", "Jaroslav", "Xenie", "Michaela", "Borivoj", "Nela",
            "Katerina", "Sofie", "Adam", "David", "Zuzana", "Barbara",
            "Tereza", "Lenka", "Svetlana", "Cecilie", "Renata",
            "Evzen", "Pavel", "Eliska", "Viktor", "Antonin",
            "Frantisek", "Radek"
        };

            // 4. Řešení
            List<string> vzestupne = jmena.OrderBy(j => j).ToList();

            foreach (string text in vzestupne)
            {
                Console.WriteLine(text);
            }



            // LINQ
            Knight borivoj = new Knight() { Name = "Borivoj", Health = 100, CountryCode = "CZ" };
            Knight hynek = new Knight() { Name = "Hynek", Health = 10, CountryCode = "CZ" };
            Knight vaclav = new Knight() { Name = "Vaclav", Health = 15, CountryCode = "CZ" };
            Knight jachym = new Knight() { Name = "Jachym", Health = 80, CountryCode = "SK" };
            Knight vojtech = new Knight() { Name = "Vojtech", Health = 40 , CountryCode = "CZ" };
            Knight matej = new Knight() { Name = "Matej", Health = 30, CountryCode = "CZ" };
            Knight istvan = new Knight() { Name = "Istvan", Health = 30, CountryCode = "HU" };

            List<Knight> knights = new List<Knight>() { borivoj, hynek, vaclav, jachym, vojtech, matej, istvan };

            List<Country> country = new List<Country>()
            {
                new Country() { Code = "CZ", Name = "Czechia"},
                new Country() { Code = "SK", Name = "Slovakia"},
                new Country() { Code = "HU", Name = "Hungary"}
            };

            var knightHealthy = knights.Where(isHealthy);
            var knightHealthy2 = knights.Where(r => r.Health > 80); // gives me collection of knights
            // r - input 
            // r.Health - output

            foreach (Knight knight in knightHealthy)
            {
                Console.WriteLine(knight.Name);
            }

            Console.WriteLine($"Number of weak knights: {knights.Count(r => r.Health < 20)}");
            Console.WriteLine($"The first knight is: {knights.First().Name}");
            Console.WriteLine($"The last knight is: {knights.Last().Name}");

            var notExisting = knights.Where(r => r.Health > 200);
            Console.WriteLine($"The first knight is: {notExisting.FirstOrDefault()}");
            // if there is, it will return, othervise returns null
            if (notExisting != null)
            {
                Console.WriteLine($"The first not existing knight is: {knights.Where(r => r.Health > 200)}");
            }
            else 
            {
                Console.WriteLine("He really does not exist");
            }


            Console.WriteLine($"Number of weak knights: {knights.Count(r => r.Health < 25)}");
            Console.WriteLine($"Mean health of the knights is: {knights.Average(r => r.Health)}");
            Console.WriteLine($"Is there a knight stronger than 100? {knights.Any(r => r.Health > 100)}");
            Console.WriteLine($"Are all knights stronger than 5? {knights.All(r => r.Health > 5)}");


            var knightsByName = knights.OrderBy(r => r.Name).ToList();
            foreach (Knight knight in knightsByName)
            {
                Console.WriteLine(knight.Name);
            }

            int i = 1;

            var knightsByNation = knights.GroupBy(r => r.CountryCode);
            foreach (var groupKnights in knightsByNation)
            {
                if (i == 0)
                {
                    Console.WriteLine(groupKnights.Key);// spolecny pro jednu skupinu
                    foreach (Knight knight in groupKnights)
                    {
                        Console.WriteLine(knight.Name);
                    }
                }
                else 
                {
                    Console.WriteLine(country.Find(z => z.Code == groupKnights.Key));
                    foreach (Knight knight in groupKnights)
                    {
                        Console.WriteLine(knight.Name);
                    }
                }

            }

            // Distinct - od kazdeho unikatniho prvku prave jeden vystup
            // Reverse - otoci prvky v kolekci
            // Skip a Take - skip preskoci na dany index, take vyjme urcity pocet prvku, pocinaje zadanym indexem
            // SelectMany -  

        }
        private static bool isHealthy(Knight knight)
        {
            return knight.Health > 80;
        }
    }

    class Knight
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public string CountryCode { get; set; }
    }
    class Country
    {
        public string Name { get; set; }
        public string Code { get; set; }
    }
}
