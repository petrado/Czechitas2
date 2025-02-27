﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Czechitas3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------");
            string hyphen = new string('-', 20);
            Console.WriteLine(hyphen);

            char letterA = 'a';
            char letterBigA = 'A';
            int numberValueOfA = (int)letterA;
            int numberValueOfBigA = (int)letterBigA;
            Console.WriteLine($"letter {letterA} has value {numberValueOfA}");
            Console.WriteLine($"letter {letterBigA} has value {numberValueOfBigA}");
            Console.WriteLine(letterA - letterBigA);

            /*
            for (int i = 0; i < 127; i++)
            {
                Console.WriteLine(i);
                Console.Write(" ");
                Console.WriteLine((char)i);
            }
            */

            int defaultInt = default(int); // what's default value for string
            string defaultString = default(string);
            Console.WriteLine(defaultInt == null); // object type
            Console.WriteLine(defaultString == null); // reference type

            //Console.WriteLine("input name");
            //string input = Console.ReadLine();
            //while (string.IsNullOrWhiteSpace(input)) // user cannot insert space and tab e.g
            //{
            //    Console.WriteLine("Incorrect input, retry");
            //    input = Console.ReadLine();
            //}

            Console.WriteLine(string.Concat("hi", " ", "there"));
            // Equals - same as logical operator
            // StringComparision

            string userName = "Petra";
            string pword = "password";

            //Console.WriteLine("Insert name");
            //string inputName = Console.ReadLine();
            //if (string.Equals(userName, inputName, StringComparison.OrdinalIgnoreCase)) // ignore lower and upper case 
            //{
            //    Console.WriteLine("Insert password");
            //    string inputPword = Console.ReadLine();
            //    if (pword == inputPword) 
            //    {
            //        Console.WriteLine("Welcome");
            //    }
            //}

            // Compare - compare alfhabetical 
            //string firstString = "ab";
            //string secondString = "ac";
            //string thirdString = "ba";
            //int result = string.Compare(firstString, secondString, StringComparison.OrdinalIgnoreCase);
            //Console.WriteLine(result);

            // ukol - obratte poradi stringu
            string palindrom = "Kuna nese nanuk";
            string reversed = TurnStringOver(palindrom);
            Console.WriteLine(reversed);

            //ukol - funkce umi detekovat, zda se jedna o palindrom, vypis jen palindromy
            string[] words = new string[] { "kajak", "program", "rotor", "Czechitas", "madam", "Jarda", "radar", "nepotopen" };

            List<string> resultPalindroms = new List<string>();
            resultPalindroms = GetPalindrom(words);
            foreach (string word in resultPalindroms)
            {
                Console.WriteLine(word);
            }

            //ukol - oprav v textu zapnuty Capslock
            string capsLock = "jAK lZE pOZNAT zAPNUTY cAPSLOCK";
            string result = IsCapsLockTurnedOn(capsLock);

            //ukol - rozsifruj tuto zpravu - kazde pismeno je posunute o jedno doprava a -> b
            string cipher = "Wzcpsob!qsbdf!.!hsbuvmkj!b!ktfn!ob!Ufcf!qztoz";
            string resultCipher = CaesarCipher(cipher);

            string longText = "Hi Josef, how are you?";
            bool containsJosef = longText.Contains("Josef");
            int indexJosef = longText.IndexOf("Josef");
            Console.WriteLine($"Text contains word Josef {containsJosef} on the position number {indexJosef}");
            string firtsTenChar = longText.Substring(startIndex: 0, length: 12);
            Console.WriteLine(firtsTenChar);

            string otherName = longText.Replace("Josef", "Michal");
            Console.Write(otherName);

            Console.WriteLine("Insert name");
            string inputName = Console.ReadLine();
            string inputTrimmed = inputName.Trim(); //TrimStart, TrimEnd, Trim(' ', '-')
            Console.WriteLine($"Name inserted [{inputName}] and name after Trim [{inputTrimmed}]");

            string[] jidla = { "rizek", "kedlubna", "caj"};
            string food = "rizek,kedlubna,   caj,   brambory";
            string[] foodDivided = food.Split(new string[] { ",", " " }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < jidla.Length; i++)
            {
                Console.WriteLine(jidla[i].PadRight(20, '.'));
                Console.WriteLine(foodDivided[i].PadRight(20, '.'));
            }

            //string foodsWithStr = string.Join(';', foodDivided);

            // String builder - lepsi, vypocetne neni tak narocny
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 100; i++)
            {
                sb.Append(i);
            }
            Console.WriteLine(sb.ToString());

            string souhrn ="";
            for (int i = 0; i < 100; i++)
            {
                souhrn += i;
            }
            Console.WriteLine(sb.ToString());


            Console.ReadLine();
        }


        public static string TurnStringOver(string input)
        {
            string output = "";
            for (int i = input.Length-1; i >= 0; i--)
            {
                    output = string.Concat(output, input[i]);
            }
            return output;
        }

        public static List<string> GetPalindrom(string[] input)
        {
            int lengthInput = input.Length;
            string currentWord = "";
            string currentReversed = "";
            List<string> result = new List<string>();

            for (int i = 0; i < lengthInput; i++)
            {
                currentWord = input[i];
                for (int j = currentWord.Length - 1; j >= 0; j--)
                {
                    currentReversed = string.Concat(currentReversed, currentWord[j]);
                }
                //Console.WriteLine(slovo);
                //Console.WriteLine(obracene);
                if (string.Equals(currentWord, currentReversed, StringComparison.OrdinalIgnoreCase))
                {
                    result.Add(currentWord);
                }

                currentWord = "";
                currentReversed = "";
            }

            return result;
        }

        public static string IsCapsLockTurnedOn(string text) 
        {
            bool isCapsLock = false;
            isCapsLock = text.Skip(1).Any(char.IsLower) && text.Skip(1).Any(char.IsUpper);

            if (isCapsLock)
            {
                text = char.ToUpper(text[0]) + text.Substring(1).ToLower();
            }
            Console.WriteLine(text);
            return text;
        }
        public static string CaesarCipher(string text)
        {
            int charValue;
            char finalChar;
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                charValue = (int)text[i];
                charValue -= 1;
                finalChar = (char)charValue;
                stringBuilder.Append(finalChar);
            }
            Console.WriteLine(stringBuilder.ToString());
            return stringBuilder.ToString();
        }
    }
    
}
