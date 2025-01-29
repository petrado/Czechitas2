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

        }
        private static int CompareKnights(Knight first, Knight second)
        {
            return string.Compare(first.Name, second.Name, true);
        }


    }
}
