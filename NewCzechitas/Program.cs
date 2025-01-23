using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCzechitas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // trida Rytir, 2 vlastnosti, 1 metoda
            // jmeno, pocetZivotu
            // metoda - vypis jmeno a zivoty
            Knight Albert = new Knight("Albert", 3);
            Albert.WriteOut();
            Albert.dateBirth = DateTime.Now; // real time in the PC
            Albert.dateBirth = new DateTime(1958, 3, 9);

            TimeSpan age = DateTime.Now - Albert.dateBirth; // calculate actual time - his date of birth, I need to convert it to Days, e.g.

            DateTime newTime = new DateTime(1980, 6, 1, 18, 20, 25); // completely unrelated to the Knight, I can subtract this from the age
            TimeSpan hoursCountdown = newTime - Albert.dateBirth; // represents time interval

            Console.WriteLine($"I was born {Albert.dateBirth}");
            Console.WriteLine($"I was born {Albert.dateBirth.Day}.{Albert.dateBirth.Month}.{Albert.dateBirth.Year}");
            Console.WriteLine($"I am {age.Days} days old... or {age.Days / 365} years old");
            Console.WriteLine($"I am {hoursCountdown.TotalDays / 365}");


            DateTime dateNow = DateTime.Now;
            DateTime dateStart = new DateTime(2025, 5, 16);
            DateTime dateEnd = new DateTime(2025, 5, 28);
            Vacation Japon = new Vacation(dateStart, dateEnd, dateNow);


            Console.ReadLine();
        }
    }
}
