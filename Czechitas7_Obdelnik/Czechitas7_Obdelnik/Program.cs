using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Czechitas7_Obdelnik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vytvorte program, ktery bude umet vykreslit na konzoli graficke objekty.
            //Vytvorte tridu GrafickjyObjekt, ktery bude mit virtualni metodu Vykresli bez parametru. Metoda po zavolani vypise "X",
            //protoze se netyka konkretniho tvaru.
            //Vytvorte tridy Obdelnik, Trojuhelnik a Text ktere budou z GrafickehoObjektu dedit. 
            //Obdelnik vykresli na konzoli obdelnik z #
            //Trojuhelnik vykresli na konzoli trojuhelnik z #
            //Text vypise text, zadany do vlastnosti Text
            //Vytvorte program, ktery bude mit seznam grafickych objektu. Vlozte jednotlive objekty do seznamu a potom ho z cyklu vykreslete
            //Mohlo by to vypadat nasledovne:
            //###
            //###

            //#
            //###

            //Ahoj

            //Rozsireni:
            //Pro obdelnik definuj vlastnosti Sirka a Vyska a zkus nastavit, kolik symbolu na vysku a sirku mi vykresli. Pro trojuhelnik zkuste podobne,
            //kolik ma mit pater ve vlastnosti Vyska
            //Zkuste tridu Grafickyobjekt rozsirit o vlastnost Barva, kterou pak muzete nastavit na konzoli a vykreslit objekty ruznou barvou.
            //Provedete to nasledovne:

            //Console.ForegroundColor = ConsoleColor.red;
            //Console.WriteLine(###);
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.WriteLine("Bila");

            Obdelnik obdelnik = new Obdelnik();
            Trojuhelnik trojuhelnik = new Trojuhelnik();
            Text text = new Text();

            List<GrafickyObjekt> objekty = new List<GrafickyObjekt>();
            objekty.Add(obdelnik);
            objekty.Add(trojuhelnik);
            objekty.Add(text);

            foreach (var objekt in objekty)
            {
                objekt.Vykresli();
            }
        }
    }
}
