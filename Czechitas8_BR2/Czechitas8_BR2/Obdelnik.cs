using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Czechitas8_BR2
{
    class Obdelnik : IUmiPocitatObsah, IUmiPocitatObvod
    {
        public int Sirka { get; set; }
        public int Vyska { get; set; }

        public Obdelnik(int sirka, int vyska)
        {
            Sirka = sirka;
            Vyska = vyska;
        }
        public void VypoctiObsah()
        {
            Console.WriteLine("Obsah obdelnika je: " + Sirka * Vyska);
        }

        public void VypoctiObvod()
        {
            Console.WriteLine("Obvod obdelnika je: " + 2 * (Sirka + Vyska));
        }
    }
}
