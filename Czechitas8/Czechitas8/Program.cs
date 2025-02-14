using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Czechitas8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // bazova trida - PohadkoveBytosti
            // princ, princezna, carodej
            PohadkovaBytost krasomila = new Princezna(); //Princezna krasomila = new princezna();
            PohadkovaBytost miroslav = new Princ();
            PohadkovaBytost cernokneznik = new Carodej();
            PohadkovaBytost amalka = new Vila();
            List<PohadkovaBytost> bytosti = new List<PohadkovaBytost>() { krasomila, miroslav, cernokneznik, amalka};

            foreach (var bytost in bytosti)
            {
                bytost.PredstavSe();
            }

            // tancujici pohadkova bytost

            // vydavam prikaz k zacatku a konci tancovani

            /*
            foreach (TancujiciPohadkovaBytost tpb in bytosti) // koukam se jen do tancujicich pohadkovych bytosti
            {
                tpb.ZacniTancovat();
                tpb.PrestanTancovat();
            }
            */

            foreach (ITancujiciBytost tpb in bytosti.OfType<ITancujiciBytost>()) // z kolekce bytosti bere uz jen ty, ktere umi tancovat
            {
                tpb.ZacniTancovat();
                tpb.PrestanTancovat();
            }

            // cernokneznik.BudNeviditelny(); // toto nejde, protoze je ted vedeny jako Pohadkovabytost - a ta zna pouze metodu PredstavSe
            // predelam tak, ze se k nemu budu chovat jako k carodeji
            // -> muzu pretypovat
            
            // prvni varianta pretypovani
            ((Carodej)cernokneznik).BudNeviditelny();
            ((Carodej)cernokneznik).BudViditelny();

            // druha varianta pretypovani
            (cernokneznik as Carodej).BudNeviditelny();
            (cernokneznik as Carodej).BudViditelny();

            // (cernokneznik as Princ).ZacniTancovat(); // bije se TancujiciPohadkovaBytost vuci KouzelnePohadkoveBytosti - chovam se k carodejovi natvrdo jako k tancujici
            
            // muzu otestovat v podmince

            if (cernokneznik is Carodej)
            {
                (cernokneznik as Carodej).BudNeviditelny();
            }

            // nebo vytvorim promennou v if 
            if (cernokneznik is Carodej carodej)
            {
                carodej.BudNeviditelny();
            }

            // nebo jednoradkove 
            (cernokneznik as Carodej)?.BudNeviditelny();

            // lze zuzit chovani daneho objektu jen na dany interface - z ITancujiciBytosti nezavolam PredstavSe
            ITancujiciBytost princeznaII = new Princezna();


            Console.ReadLine();
        }
    }
}
