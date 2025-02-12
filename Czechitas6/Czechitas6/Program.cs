using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Czechitas6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rytir borivoj = new Rytir("Borivoj", 10, 100);

            /* borivoj.Jmeno = "Borivoj";
            borivoj.Sila = 10;
            borivoj.Zdravi = 100;
            */

            Rytir bonifac = new Rytir("Bonifac");
            Rytir geralt = new Rytir("Geralt", 200);

            Console.WriteLine($"Pocet rytiru je: {Rytir.pocetRytiru}");
            /*
            int silaRytire = borivoj.Sila;
            int zdraviRytire = bonifac.Zdravi;
            zdraviRytire -= silaRytire;
            */


            Console.WriteLine($"Bonifacovo zdravi je {bonifac.Zdravi}");
            bonifac.UtocNaRytire(geralt);
            Console.WriteLine($"Bonifacovo zdravi je {bonifac.Zdravi}");

            // bonifac.Zdravi += 50; // toto nechci udelat


            /*
            MatematickaFunkce fce = new MatematickaFunkce();
            fce.VratSoucet(5, 4);
            */
            MatematickaFunkce.VratSoucet(5, 4);

            RocniObdobi obdobi = RocniObdobi.Jaro;
            RocniObdobi jineObdobi = RocniObdobi.Podzim;

            if (obdobi == RocniObdobi.Jaro)
            {
                Console.WriteLine("Je jaro");
            }

            switch (obdobi)
            {
                case RocniObdobi.Jaro:
                    break;
                case RocniObdobi.Leto:
                    break;
                case RocniObdobi.Podzim:
                    break;
                case RocniObdobi.Zima:
                    break;
                default:
                    break;
            }



            // BREAKOUT ROOM 1
            //  Vytvoř třídu Obdelnik (tak, aby byla v samostatnem souboru Obdelnik.cs), která bude mít dva fieldy: Sirka a Vyska.
            //  Vytvoř konstruktor třídy Obdelnik s parametry sirka a vyska.
            //  Přidej do třídy ještě jeden typ konstruktoru pro speciální případ obdelníku(čtverec) s jedním parametrem, který bude volat první konstruktor.
            //  Obdelniku vytvorte funkci Vypis informace, ktery vypise vysku a sirku.
            //  Vytvoř několik instancí třídy Obdelnik (například 2) a vypiš jejich vlastnosti pomoci metody VypisParameteryObdelniku.

            Obdelnik obdelnik = new Obdelnik(10, 15);
            obdelnik.VypisInformace();

            Obdelnik ctverec = new Obdelnik(5);
            ctverec.VypisInformace();

            Console.ReadLine();
        }
    }

    public class Rytir
    {
        public string Jmeno { get; private set; }
        public int Sila { get; private set; }
        //public int Zdravi { get; private set; }

        public static int pocetRytiru;

        private int zdravi; // pomocna promenna
        public int Zdravi
        {
            get
            {
                return zdravi;           
            }
            private set 
            {
                if (value < 0)
                {
                    zdravi = 0;
                }
                else 
                {
                    zdravi = value;
                }
            }
            // zdravi = ValueTuple < 0 ? 0 : value; // ternarni zapis
        }

        public bool JeZivy
        {
            get 
            {
                return Zdravi > 0;
            }
        }

        public Rytir(string Jmeno, int sila, int zdravi)
        {
            this.Jmeno = Jmeno; // ukazuje na konkretni objekt - koukam se na field ve tride, ne v ctoru
            Sila = sila;
            Zdravi = zdravi;
            Console.WriteLine("Toto je plny ctor");
        }

        public Rytir(string jmeno)
        {
            Jmeno = jmeno;
            Sila = 20;
            Zdravi = 100;
            pocetRytiru++;
        }

        public Rytir(string jmeno, int sila) : this(jmeno, sila, 250)
        {
            Console.WriteLine("toto je zuzeny ctor");
        }

        /*public Rytir(string jmeno, int sila = 30)
        {
            Jmeno = jmeno;
        }*/

        private int VratiSiluUderu()
        {
            return Sila;
        }

        private int VratZbyvajiciZdravi(int silaUtoku)
        {
            return silaUtoku;
        }

        public void UtocNaRytire(Rytir protivnik)
        {
            /*
            int zdravi = Zdravi - protivnik.VratiSiluUderu();
            Zdravi = zdravi;
            */
            Zdravi -= protivnik.VratiSiluUderu();
        }
    }

    public class MatematickaFunkce
    {
        public static void VratSoucet(int a, int b)
        {
            Console.WriteLine($"Vysledek je {a + b}");
        }
    }

    enum RocniObdobi
    {
        Jaro,
        Leto,
        Podzim,
        Zima
    }

}
