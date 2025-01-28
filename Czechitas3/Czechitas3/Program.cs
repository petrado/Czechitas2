using System;
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
            //Console.WriteLine("--------");
            //string hyphen = new string('-', 20);
            //Console.WriteLine(hyphen);

            //char letterA = 'a';
            //char letterBigA = 'A';
            //int numberValueOfA = (int)letterA;
            //int numberValueOfBigA = (int)letterBigA;
            //Console.WriteLine($"letter {letterA} has value {numberValueOfA}");
            //Console.WriteLine($"letter {letterBigA} has value {numberValueOfBigA}");
            //Console.WriteLine(letterA - letterBigA);

            ///*
            //for (int i = 0; i < 127; i++)
            //{
            //    Console.WriteLine(i);
            //    Console.Write(" ");
            //    Console.WriteLine((char)i);
            //}
            //*/

            //int defaultInt = default(int); // what's default value for string
            //string defaultString = default(string);
            //Console.WriteLine(defaultInt == null); // object type
            //Console.WriteLine(defaultString == null); // reference type

            ////Console.WriteLine("input name");
            ////string input = Console.ReadLine();
            ////while (string.IsNullOrWhiteSpace(input)) // user cannot insert space and tab e.g
            ////{
            ////    Console.WriteLine("Incorrect input, retry");
            ////    input = Console.ReadLine();
            ////}

            //Console.WriteLine(string.Concat("hi", " ", "there"));
            //// Equals - same as logical operator
            //// StringComparision

            //string userName = "Petra";
            //string pword = "password";

            ////Console.WriteLine("Insert name");
            ////string inputName = Console.ReadLine();
            ////if (string.Equals(userName, inputName, StringComparison.OrdinalIgnoreCase)) // ignore lower and upper case 
            ////{
            ////    Console.WriteLine("Insert password");
            ////    string inputPword = Console.ReadLine();
            ////    if (pword == inputPword) 
            ////    {
            ////        Console.WriteLine("Welcome");
            ////    }
            ////}

            //// Compare - compare alfhabetical 
            ////string firstString = "ab";
            ////string secondString = "ac";
            ////string thirdString = "ba";
            ////int result = string.Compare(firstString, secondString, StringComparison.OrdinalIgnoreCase);
            ////Console.WriteLine(result);

            //// ukol - obratte poradi stringu
            //string palindrom = "Kuna nese nanuk";
            //string reversed = TurnStringOver(palindrom);
            //Console.WriteLine(reversed);

            ////ukol - funkce umi detekovat, zda se jedna o palindrom, vypis jen palindromy
            //string[] words = new string[] { "kajak", "program", "rotor", "Czechitas", "madam", "Jarda", "radar", "nepotopen" };

            //List<string> resultPalindroms = new List<string>();
            //resultPalindroms = GetPalindrom(words);
            //foreach (string word in resultPalindroms)
            //{
            //    Console.WriteLine(word);
            //}

            ////ukol - oprav v textu zapnuty Capslock
            //string capsLock = "jAK lZE pOZNAT zAPNUTY cAPSLOCK";
            //string result = IsCapsLockTurnedOn(capsLock);

            ////ukol - rozsifruj tuto zpravu - kazde pismeno je posunute o jedno doprava a -> b
            //string cipher = "Wzcpsob!qsbdf!.!hsbuvmkj!b!ktfn!ob!Ufcf!qztoz";
            //string resultCipher = CaesarCipher(cipher);

            //string longText = "Hi Josef, how are you?";
            //bool containsJosef = longText.Contains("Josef");
            //int indexJosef = longText.IndexOf("Josef");
            //Console.WriteLine($"Text contains word Josef {containsJosef} on the position number {indexJosef}");
            //string firtsTenChar = longText.Substring(startIndex: 0, length: 12);
            //Console.WriteLine(firtsTenChar);

            //string otherName = longText.Replace("Josef", "Michal");
            //Console.Write(otherName);

            //Console.WriteLine("Insert name");
            //string inputName = Console.ReadLine();
            //string inputTrimmed = inputName.Trim(); //TrimStart, TrimEnd, Trim(' ', '-')
            //Console.WriteLine($"Name inserted [{inputName}] and name after Trim [{inputTrimmed}]");

            //string[] jidla = { "rizek", "kedlubna", "caj"};
            //string food = "rizek,kedlubna,   caj,   brambory";
            //string[] foodDivided = food.Split(new string[] { ",", " " }, StringSplitOptions.RemoveEmptyEntries);

            //for (int i = 0; i < jidla.Length; i++)
            //{
            //    Console.WriteLine(jidla[i].PadRight(20, '.'));
            //    Console.WriteLine(foodDivided[i].PadRight(20, '.'));
            //}

            //string foodsWithStr = string.Join(';', foodDivided);

            using System;


public class Program
        {
            public static void Main()
            {
                // Tento ukol se opravuje sam. Kazdy priklad obsahuje kontrolni vypisy, ktere overi, ze jsi dosla k spravnemu vysledku.
                // Vsechny priklady take obsahuji nejakou predpripravenou promennou, kam ulozis vysledek svoji prace.

                int padding = 45;
                string text = @"""Hurry up, boy!"" shouted Uncle Vernon from the kitchen. ""What are you
doing, checking for letter bombs?"" He chuckled at his own joke.

Harry went back to the kitchen, still staring at his letter. He handed
Uncle Vernon the bill and the postcard, sat down, and slowly began to
open the yellow envelope.

Uncle Vernon ripped open the bill, snorted in disgust, and flipped over
the postcard.

""Marge's ill,"" he informed Aunt Petunia. ""Ate a funny whelk. --.""

""Dad!"" said Dudley suddenly. ""Dad, Harry's got something!""

Harry was on the point of unfolding his letter, which was written on the
same heavy parchment as the envelope, when it was jerked sharply out of
his hand by Uncle Vernon.

""That's mine!"" said Harry, trying to snatch it back.

""Who'd be writing to you?"" sneered Uncle Vernon, shaking the letter open
with one hand and glancing at it. His face went from red to green faster
than a set of traffic lights. And it didn't stop there. Within seconds
it was the grayish white of old porridge.";

                // Nez zacnes volat nejake stringove funkce na nejake stringove promenne, nezapomen overit, ze obsahuje smysluplnou hodnotu. Vysledek uloz do promenne 'textMaSmysl'.
                bool textMaSmysl = false;
                Console.WriteLine("Text dava smysl - ".PadRight(padding) + (textMaSmysl == true));

                // Do promenne 'delkaTextu' uloz celkovou delku uryvku z knizky.

                int delkaTextu = 0;
                Console.WriteLine("Delka text je spravna - ".PadRight(padding) + (delkaTextu == 1001));

                // Do promenne 'oddelovac' vloz text, ktery se sklada pouze z pomlcek a jeho delka je presne 20. Pouzij k tomu konstruktor typu string.

                string oddelovac = null;
                Console.WriteLine("Oddelovac ma 20 pomlcek - ".PadRight(padding) + (oddelovac == "--------------------"));

                // Pozmen nasledujici porovnani textu tak, aby se do konzole vypisovalo True, aniz bys menila hodnoty promennych

                string jmeno1 = "Katka";
                string jmeno2 = "katka";
                bool jeStejne = false;
                Console.WriteLine("Obe promenne obsahuji stejne jmeno - ".PadRight(padding) + jeStejne);

                // Zjisti, jestli je v textu zminka o obtloustle "tete" Harryho. Jmenuje se Marge. Vysledek uloz do promenne 'piseSeOMarge';

                bool piseSeOMarge = false;
                Console.WriteLine("V textu se zminuje Harryho 'teticka' - ".PadRight(padding) + (piseSeOMarge == true));

                // Zjisti, jestli je text spravne ukonceny interpunkci. Vysledek uloz do promenne 'jeSpravneUkoncen'.

                bool jeSpravneUkoncen = false;
                Console.WriteLine("Text je spravne ukoncen interpunkci - ".PadRight(padding) + (jeSpravneUkoncen == true));

                // Pomoci abecedniho porovnavani zjisti, ktery z nasledujicich textu je podle abecedy prvni a jeho hodnotu prirad do promenne 'prvni'.

                string blabol1 = "abbc";
                string blabol2 = "acbc";
                string blabol3 = "abbb";
                string prvni = null;

                Console.WriteLine("Prvni v abecede je blabol3 - ".PadRight(padding) + (prvni == blabol3));

                // Najdi prvni rozkazovaci vetu v textu a uloz ji do promenne 'veta' bez vykricniku a uvozovek.

                string veta = null;
                Console.WriteLine("Prvni rozkazovaci veta je 'Hurry up, boy' - ".PadRight(padding) + (veta == "Hurry up, boy"));

                // Zjisti, kolikrat se v textu vyskytuje slovo "and" bez ohledu na velikosti prvniho pismenka a vysledek uloz do promenne 'pocetAnd'.
                // Abych vam to zjednodusil, muzete se spolehnout, ze tato anglicka spojka bude v textu vzdy obklopena mezerou na kazde strane.
                // Tim se snadno vylouci jakekoliv vyskyty "and" v ramci jinych slov.

                int pocetAnd = 0;

                Console.WriteLine("Text obsahuje slovo 'and' celkem 5x' - ".PadRight(padding) + (pocetAnd == 5));
            }
        }




























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
