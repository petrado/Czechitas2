using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Czechitas10
{
    internal class Titul
    {
        public string Autor { get; set; }
        public string Nazev { get; set; }

        public Titul(string autor, string nazev)
        {
            Autor = autor;
            Nazev = nazev;
        }
    }
}
