using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Czechitas7_Obdelnik
{
    public abstract class GrafickyObjekt
    {

        public virtual void Vykresli()
        {
            Console.WriteLine("X");
        }
    }

    public class Obdelnik : GrafickyObjekt
    {
        public int Sirka;
        public int Vyska;

        public Obdelnik(int sirka, int vyska)
        {
            Sirka = sirka;
            Vyska = vyska;
        }

        public override void Vykresli()
        {
            string strana = new string('#', Sirka);
            
            Console.WriteLine("Kreslim obdelnik, ktery je na sirku: " + Sirka + " a na vysku: " + Vyska);
            for (int i = 0; i < Vyska; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(strana);
            }
            Console.WriteLine("Druhy zpusob");
            string vnitrni = "";
            for (int i = 0; i < Sirka; i++)
            {
                if (i == 0)
                {
                    vnitrni += "#";
                }
                else if (i == Sirka - 1)
                {
                    vnitrni += "#";
                }
                else
                {
                    vnitrni += " ";
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(strana);
            for (int i = 1; i < Vyska - 1; i++)
            {
                Console.WriteLine(vnitrni);
            }
            Console.WriteLine(strana);
        }
    }

    public class Trojuhelnik : GrafickyObjekt
    {
        public int Sirka;
        public int Vyska;

        public Trojuhelnik(int sirka, int vyska)
        {
            Sirka = sirka;
            Vyska = vyska;
        }
        public override void Vykresli()
        {
            string patro = "";
            Console.WriteLine("Kreslim trojuhelnik, ktery je na sirku: " + Sirka + " a na vysku: " + Vyska);
            for (int i = 0; i < Vyska; i++)
            {
                patro += "#";
                Console.WriteLine(patro);
            }
        }
    }

    
    public class Text : GrafickyObjekt
    {
        public string InputText;
        public Text(string text)
        {
            InputText = text;
        }
        public override void Vykresli()
        {
            Console.WriteLine(InputText);
        }
    }
    
}
