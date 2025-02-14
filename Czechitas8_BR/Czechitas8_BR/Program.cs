using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Czechitas8_BR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Vytvořte abstraktní třídu PohadkovaBytost a v ní abstraktní metodu NapisJakTravisVolnyCas
            // Vytvorte tridy Princezna, Rytir, Carodenice, ktere dedi PohadkovouBytost
            // Naimplementujte metodu NapisJakTravisVolnyCas - vypsanemu textu na konzoli se meze nekladou
            // Vytvorte instance od kazde tridy a vypiste informace o trávení volného času.
            // Ulozte do kolekce

            PohadkovaBytost princezna = new Princezna();
            PohadkovaBytost princ = new Princ();
            PohadkovaBytost vila = new Vila();
            PohadkovaBytost carodej = new Carodej();
            List<PohadkovaBytost> bytosti = new List<PohadkovaBytost>() { princezna, princ, vila, carodej};

            foreach (var bytost in bytosti)
            {
                bytost.NapisJakTravisVolnyCas();
            }

            ((Carodej)carodej).Caruj();
            ((Vila)vila).SusBylinky();

            Console.ReadLine();
        }
    }
}
