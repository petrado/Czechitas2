using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Czechitas11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // fieldy a property
            Osoba novak = new Osoba("Pepa", "Novak", 25);

            // soubory, serializace
            // string adresar = @"D:\Pokusy";
            // string cestaKSouboru1 = Path.Combine(adresar, "Soubor1.txt");

            // problem vicenasobne enumerace
            // enumerator umoznuje pristup k prvkum kolekce jeden po druhem

            /*
            IEnumerable<Osoba> enumDospeli = seznamOsob.Where(o => o.Vek > 18);
            Console.WriteLine("Vypisu starsi 18 let);
            foreach (var o in enumDospeli)
            {
                Console.WriteLine(o.Jmeno);
            }

            List<Osoba> seznamStarsich = enumDospeli.ToList(); // prevadim enumerator zpet do listu
            foreach (var o in seznamStarsich)
            {
                Console.WriteLine(o.Jmeno);
            }


            */

            Skladba s = new Skladba("Juliana");

        }
    }

    public class Skladba
    {
        public string Nazev { get; private set; }
        public Skladba(string nazev)
        {
            Nazev = nazev;

            if (nazev == null)
            {
                throw new NullReferenceException();
            }
        }
    }

    public class Osoba
    {
        private DateTime ZaznamVytvoren; // field - zamyslim pouzit pouze uvnitr tridy, v tomto pripade
        
        // property
        public string Jmeno { get; private set; }
        public string Prijmeni { get; private set; }
        public int Vek { get; private set; }

        public Osoba(string jmeno, string prijmeni, int vek)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Vek = vek;
            ZaznamVytvoren = DateTime.Now;
        }

        public void VypisStariZaznamu()
        {
            Console.WriteLine("Zaznam vytvoren: " + ZaznamVytvoren.ToString());
            Console.WriteLine("Tato osoba byla pridana pred " + (DateTime.Now - ZaznamVytvoren).TotalDays.ToString());
        }
    }
}
