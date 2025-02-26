using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Czechitas10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var harryPotter = new Titul("J.K. Rowling", "Harry Potter");
            var vytisk1 = new Vytisk("hp1", 2002, harryPotter);
            var vytisk2 = new Vytisk("hp2", 2003, harryPotter);
            var vytisk3 = new Vytisk("hp3", 2006, harryPotter);

            
            
            var panPrstenu = new Kniha 
            { 
                Autor = "JRRT", 
                Nazev = "Pan prstenu", 
                Identifikator = "pp1", 
                RokVydani = 2009 
            };

            var panPrstenu2 = new Kniha
            {
                Autor = "JRRT",
                Nazev = "Pan prstenu 2",
                Identifikator = "pp2",
                RokVydani = 2010
            };

            var panPrstenu3 = new Kniha
            {
                Autor = "JRRT",
                Nazev = "Pan prstenu 3",
                Identifikator = "pp3",
                RokVydani = 2011
            };


        }
    }
}
