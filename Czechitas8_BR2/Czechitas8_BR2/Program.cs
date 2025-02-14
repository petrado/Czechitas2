using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Czechitas8_BR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //napiste dva ruzne interfacy: IUmiPocitatObsah, IUmiPocitatObvod
            //implementujte tridy obdelnik a kruh, ktere oba interfacy pouzivaji
            //vlozte jejich instance do seznamu a zavolejte na nich prislusne metody na vypocet obsahu a obvodu

            List<IUmiPocitatObsah> seznamObsah = new List<IUmiPocitatObsah>();
            List<IUmiPocitatObvod> seznamObvod = new List<IUmiPocitatObvod>();

            Obdelnik obdelnik = new Obdelnik(2, 5);
            Kruh kruh = new Kruh(7);

            seznamObsah.Add(kruh);
            seznamObsah.Add(obdelnik);

            seznamObvod.Add(kruh);
            seznamObvod.Add(obdelnik);

            Console.WriteLine("Vypocet obsahu: ");
            foreach (var item in seznamObsah)
            {
                item.VypoctiObsah();
            }

            Console.WriteLine("Vypocet obvodu: ");
            foreach (var item in seznamObvod)
            {
                item.VypoctiObvod();
            }

            Console.ReadLine();
        }
    }
}
