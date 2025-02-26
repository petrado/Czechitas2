using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Czechitas9_BR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Vytvorte slozku TelefonniSeznam v adresari Appdata pro konkretniho uzivatele
            //2. Do souboru telefonniSeznam.csv ulozte obsah seznamu telefonniSeznam tak,
            // ze kazdy zaznam bude na jednom radku a oddelene budou carkami
            //3. Napiste cyklus, ktery soubor precte a zpatky ho ulozi do noveho seznamu

            List<Clovek> telefonniSeznam = new List<Clovek>
            {
            new Clovek("Jarda", "Kadlec", 777123456),
            new Clovek("Honza", "Kratochvila", 777987654),
            new Clovek("Petr", "Novak", 778111222)
            };

            string appDataSlozkaCesta = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var celaCesta = Path.Combine(appDataSlozkaCesta, "TentoFolder");
            Console.WriteLine(appDataSlozkaCesta);
            Directory.CreateDirectory(celaCesta);

            var cestaKSouboru = Path.Combine(celaCesta, "TelefonniSeznam.csv");
            File.WriteAllText(cestaKSouboru, "Name, Surname, Phone Number");
            File.AppendAllText(cestaKSouboru, Environment.NewLine);
      
            
            StreamWriter writer = new StreamWriter(cestaKSouboru, append: true);
            foreach (var clovek in telefonniSeznam)
            {
                writer.WriteLine($"{clovek.Jmeno}, {clovek.Prijmeni}, {clovek.TelCislo}");
            }
            writer.Flush();
            writer.Close();

            string[] seznam = File.ReadAllLines(cestaKSouboru);
            int i = 0;
            foreach (var clovek in seznam)
            {
                if (i != 0)
                {
                    Console.WriteLine(clovek);
                }
                i++;
            }

            // varianta od kouce
            //var adresar = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "TelefonniSeznam.csv");
            //if (!Directory.Exists(adresar))
            //{
            //    Directory.CreateDirectory(adresar);
            //}

            //string soubor = Path.Combine(celaCesta, "TelefonniSeznam.csv");
            //File.WriteAllText(soubor, "Jmeno; Prijmeni; TelCislo" + Environment.NewLine);
            //var radky = telefonniSeznam.Select(clovek => $"{clovek.Jmeno}; {clovek.Prijmeni}; {clovek.TelCislo}");
            //File.AppendAllLines(soubor, radky);

            //if (File.Exists(soubor))
            //{
            //    var nactenoZeSouboru = File.ReadAllLines(soubor);
            //    foreach (var radek in nactenoZeSouboru)
            //    {
            //        Console.WriteLine(radek);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Soubor nenalezen");
            //}



            


        }
    }
}
