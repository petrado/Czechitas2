using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Czechitas4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // dictionary - <klic - int, string>...a to druhe je hodnota
            Dictionary<string, string> slovnikAj = new Dictionary<string, string>
            {
                { "ahoj", "hello" },
                { "auto", "car" },
                { "dum", "house" }
            };

            slovnikAj.Add("kvetina", "flower");
            Console.WriteLine($"kvetina je anglicky {slovnikAj["kvetina"]}");

            foreach (KeyValuePair<string, string> zaznam in slovnikAj) // always returns two values
            {
                Console.WriteLine($"Obsah slovniku {zaznam.Key} : {zaznam.Value}");
            }

            foreach (var zaznam in slovnikAj) // can be written also like this
            {
                Console.WriteLine($"Obsah slovniku {zaznam.Key} : {zaznam.Value}");
            }

            var nazdar = "nazdar"; // doesn't have to be declared - C# hada datovy typ

            //slovnikAj.Add("auto", "car"); //cannot add - key have to be unique

            if (!slovnikAj.ContainsKey("auto")) // ContainsValue - vraci bool
            {
                slovnikAj.Add("auto", "car");
            }
            else
            {
                Console.WriteLine("already there");
            }

            // TryGetValue

            string anglickyPreklad;

            if (slovnikAj.TryGetValue("ahoj", out anglickyPreklad))
            {
                Console.Write($"anglicky preklad je {anglickyPreklad}");
            }












            Knight bonifac = new Knight("Bonifac", 2);
            Knight artush = new Knight("Artush", 3);
            Knight geralt = new Knight("Geralt", 1);

            Knight[] knightField = new Knight[3]{ bonifac, artush, geralt };

            for (int i = 0; i < knightField.Length; i++)
            {
                knightField[i].WriteNameAndLifes();
            }
            Knight maxmilian = new Knight("Maxmilian", 2);
            Console.WriteLine();

            // collection - List
            List<Knight> knightList = new List<Knight>() { bonifac, artush, geralt };

            knightList.Add(maxmilian);
            // knightList.AddRange(knightField) - add whole new collection

            for (int i = 0; i < knightList.Count; i++)
            {
                knightList[i].WriteNameAndLifes();
            }
            Console.WriteLine();

            foreach (Knight knight in knightList)
            {
                knight.WriteNameAndLifes();
            }

            Knight phillip = new Knight("Phillip", 1);

            knightList.Insert(0, phillip);

            Console.WriteLine();
            foreach (Knight knight in knightList)
            {
                knight.WriteNameAndLifes();
            }

            knightList.Remove(phillip);

            Console.WriteLine();
            foreach (Knight knight in knightList)
            {
                knight.WriteNameAndLifes();
            }

            int knightPosition = knightList.IndexOf(geralt);
            Console.WriteLine($"Knight Geralt is on the {knightPosition} position");

            bool isOnList = knightList.Contains(geralt);
            if (isOnList)
            {
                Console.WriteLine("Is there");
            }
            else 
            {
                Console.WriteLine("Noup");
            }

            string toBeDeleted = "Bonifac";
            Knight foundOne = knightList.Find(kn => kn.Name == toBeDeleted);
            knightList.Remove(foundOne);
            Console.WriteLine();
            foreach (Knight knight in knightList)
            {
                knight.WriteNameAndLifes();
            }

            // Sort - I can create a method that will compare
            knightList.Sort(CompareKnights);

            Console.WriteLine();
            foreach (Knight knight in knightList)
            {
                knight.WriteNameAndLifes();
            }


            knightList.Clear(); // clear all list


            List<double> cisla = new List<double>
        {
            0.046939913,
            0.295866297,
            0.852489925,
            0.84994766,
            0.96925183,
            0.946275497,
            0.688903175,
            0.553463564,
            0.59628254,
            0.645816929
        };

            // Vypis vsechna cisla na konzoli (nachystej si pro to funkci)
            Vypis(cisla);
            Console.WriteLine();

            // Vypis na konzoli pocet cisel v seznamu

            Console.WriteLine($"List contains {VypisPocet(cisla)} elements");
            Console.WriteLine();

            // Pridej cislo 0.5 do seznamu
            double addNumber = 0.5;
            cisla.Add( addNumber );
            Vypis(cisla);
            Console.WriteLine();

            // vypis prvni cislo ze seznamu, ktere je vetsi nez 0.8
            double threshold = 0.8;
            double firstBigger = 0;
            foreach (double current in cisla)
            {
                if (current > threshold)
                {
                    firstBigger = current;
                    break;
                }
            }
            Console.WriteLine($"The first number bigger than {threshold} is {firstBigger}");
            Console.WriteLine();

            // najdi nejvetsi cislo v seznamu, vypis, ktere to je, a odstran ho ze seznamu
            double maxValueInList = FindMaxNumbers(cisla);
            Console.WriteLine($"Max number in the list is {maxValueInList}...");
            cisla.Remove(maxValueInList);
            Console.WriteLine("...and now it's gone...");


            // vypis opet vsechna cisla a jejich pocet
            Console.WriteLine();
            Console.WriteLine($"Currently there is {cisla.Count} numbers in the list and the list looks like that: ");
            Vypis(cisla);


        }
        private static int CompareKnights(Knight first, Knight second)
        {
            return string.Compare(first.Name, second.Name, true);
        }

        private static void Vypis(List<double> input)
        {
            foreach (double current in input)
            {
                Console.WriteLine($"Current number is {current}");
            }
        }

        private static int VypisPocet(List<double> input)
        {
            return input.Count;
        }

        private static double FindMaxNumbers(List<double> input)
        {
            double maxValue = input.Max();
            return maxValue;
        }
    }
}
