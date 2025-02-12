using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Czechitas6
{
    internal class Obdelnik
    {
        public double Sirka;
        public double Vyska;

        public Obdelnik(double sirka, double vyska) 
        {
            Sirka = sirka;
            Vyska = vyska;
        }

        public Obdelnik(double strana) : this(strana, strana)
        {
            
        }

        public void VypisInformace()
        {
            Console.WriteLine($"Sirka obdelniku je: {Sirka} a vyska obdelniku je {Vyska}. ");
        }
    }
}
