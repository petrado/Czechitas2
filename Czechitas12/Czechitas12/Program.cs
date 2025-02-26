using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Czechitas12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Skladba s = new Skladba("Kde domov muj");
        }
    }

    public class Skladba
    {
        public string Nazev { get; private set; }
        public bool JeNaSpotify { get; private set; } = false;
        public Skladba(string nazev)
        {
            Nazev = nazev;

            if (nazev == null)
            {
                throw new NullReferenceException();
            }
            else if (string.IsNullOrWhiteSpace(nazev))
            {
                throw new ArgumentException();
            }
        }

        public void PublikujNaSpotify()
        {
            JeNaSpotify = true;
        }

    }

}
