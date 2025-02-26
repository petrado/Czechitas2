using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Czechitas9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // pouzivani souboru
            // System.IO - input / output
            // cesta k souboru ma nekolik variant:
            // string cesta1 = "C:/test/text.txt";
            // string cesta2 = "C:\\test\\text.txt";
            // string cesta3 = @"C:\test\text.txt";
            // jestli existuje: 
            // bool souborExistuje = File.Exists(cesta2);
            // ReadAllText - nacte vsechen text ze souboru (string text = File.ReadAllText(cesta2))
            // ReadAllLines - jednotlive radky jako prvky pole (string[] radky = File.ReadAllLines(cesta2))
            // WriteAllText - text ze stringu do souboru
            // WriteAllLines - text ze souboru do radku
            // AppendAllTex / AppendAllLines

            string cestaKSouboru = "D:\\Pokusy\\Czechitas2\\Czechitas2\\Czechitas9\\Czechitas9\\bin\\Debug\\druhySoubor";
            File.WriteAllText("prvniSoubor", "Text zapsany do souboru");
            File.WriteAllText(cestaKSouboru, "Text zapsany do souboru");
            Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)); // specialni cesta, ktera se "meni" podle uzivatele, behu souboru
            string mojeDokumenty = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var tretiCesta = Path.Combine(mojeDokumenty, "tretiSoubor.txt"); // spojeni, aby nebyl problem - kombinace cesty a souboru
            
            File.WriteAllText(mojeDokumenty + "\\tretiSoubor.txt", "Dalsi text zapsany do souboru");
            File.AppendAllText(tretiCesta, Environment.NewLine);
            File.AppendAllText(tretiCesta, "Dodatek");

            string[] nactenoTreti = File.ReadAllLines(tretiCesta);
            foreach (string radek in nactenoTreti)
            {
                Console.WriteLine(radek);
            }

            // vytvoreni adresare
            string cestaKNoveSlozce = Path.Combine(mojeDokumenty, "NovaSlozka");
            Directory.CreateDirectory(cestaKNoveSlozce); // vytvori slozky podle zadane cesty
            string cestaKSouboruVeSlozce = Path.Combine(cestaKNoveSlozce, "DalsiFolder.txt");
            File.WriteAllText(cestaKSouboruVeSlozce, "Neco, neco, neco, neco");

            if (File.Exists(cestaKSouboruVeSlozce)) // stejne tak lze i s adresarema - Directory.Exist
            {
                Console.WriteLine("Jup, je tam");
            }
            else
            {
                Console.WriteLine("Noup");
            }

            //var ctvrtySoubor = Path.Combine(mojeDokumenty, "ctvrtySoubor.txt");
            //StreamWriter writer = new StreamWriter(ctvrtySoubor, append: false); // append - doplnuju, nebo prepisuju pri znovu spusteni (append false - prepise, append true - pridava donekonecna)
            //writer.WriteLine("Toto, je prvni radek");
            //writer.WriteLine("Toto, je druhy radek");
            //writer.WriteLine("Toto, je treti radek");
            //writer.WriteLine("Dodatek");
            //writer.Flush(); // az ted se vse zapise do souboru
            //writer.WriteLine("Jeste neco navic");
            //writer.Close(); // timto ten stream uzavru - nutno tam dat


            // Stream jednodusseji - nemusim davat Close
            var sestySoubor = Path.Combine(mojeDokumenty, "sestySoubor.txt");
            using (StreamWriter writer = new StreamWriter(sestySoubor))
            {
                writer.WriteLine("Jeden radek z using");
                writer.WriteLine("Druhy radek z using");
            }

            // using je ekvivalent k tomuto
            StreamWriter writer2 = new StreamWriter(sestySoubor, append: true);
            try
            {
                writer2.WriteLine("Prvni Radek z TryCatch");
                // throw new Exception();
                writer2.WriteLine("Druhy radek z TryCatch");
            }
            finally
            {
                writer2.Dispose();
            }

            List<Clovek> telefonniSeznam = new List<Clovek>
            {
            new Clovek("Jarda", "Kadlec", 777123456),
            new Clovek("Honza", "Kratochvila", 777987654),
            new Clovek("Petr", "Novak", 778111222)
            };

            var sedmySoubor = Path.Combine(mojeDokumenty, "sedmySoubor.txt");
            // serializace do XML
            // prevod z formatu ve kterem je to ulozeno do xml formatu
            XmlSerializer serializerClovek = new XmlSerializer(typeof(Clovek)); // potrebuje bezparametricky konstruktor, klidne private
            using (StreamWriter writer = new StreamWriter(sedmySoubor))
            {
                serializerClovek.Serialize(writer, telefonniSeznam[0]);
            }

            var osmySoubor = Path.Combine(mojeDokumenty, "osmySoubor.txt");
            XmlSerializer serializerSeznam = new XmlSerializer(typeof(List<Clovek>));
            using (StreamWriter writer = new StreamWriter(osmySoubor))
            {
                serializerSeznam.Serialize(writer, telefonniSeznam);
            }

            // deserializace XML
            using (StreamReader reader = new StreamReader(sedmySoubor))
            {
                Clovek prvniClovek = serializerClovek.Deserialize(reader) as Clovek;
                Console.WriteLine($"Nacetl jsem: {prvniClovek.Jmeno}; {prvniClovek.Prijmeni}; {prvniClovek.TelCislo}");
            }

            // nacitani touto cestou je ruchlejsi, nez ReadAllText - postupne jen ctu radek po radku a v mezicase s nim pracuju 
            // postupne nacitani ze streamu
            List<int> delkyRadku = new List<int>();
            using (StreamReader reader = new StreamReader(osmySoubor))
            {
                string radek = reader.ReadLine();
                delkyRadku.Add(radek.Length);
                Console.WriteLine(radek);
            }
            Console.WriteLine($"Nejdelsi radek je dlouhy {delkyRadku.Max()}");
        }
    }
}
