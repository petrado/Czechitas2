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
            // TimeWorking(); // select some text, right click - quick actions and refactoring - create method and keep everything in this method

            // int firstNumber;
            // TryCatch(out firstNumber);
            

            double num1 = 10; // dopuble gives infinity
            double num2 = 0;
            Console.WriteLine($"Divvision result: {num1 / num2}");
            SafeDivision divide = new SafeDivision();
            try
            {
                divide.DivideNumbers(num1, num2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadLine();
            }
            







            Console.ReadLine();
        }

        private static void TryCatch(out int firstNumber)
        {
            firstNumber = 0;

            // user writes two integeres and want to divide
            Console.WriteLine("Insert first number");
            try
            {
                firstNumber = Int32.Parse(Console.ReadLine());
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            catch (Exception e)
            {
                Console.WriteLine("Incorrect input");
                Console.WriteLine(e.Message);
                return;
            }

            Console.WriteLine("Insert second number");
            int secondNumber = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"Result after division is {firstNumber / secondNumber}");
        }


        private static void TimeWorking()
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
        }
    }
}
