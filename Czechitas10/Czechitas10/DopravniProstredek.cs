using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Czechitas10
{
    internal abstract class DopravniProstredek
    {
        public string Jmeno { get; set; }
        public string Kapacita { get; set; }
    }

    internal class Auto : DopravniProstredek
    {
        public int PocetDveri { get; set; }
    }

    internal class Kolo : DopravniProstredek
    {
        public int PocetPrevodu { get; set; }
    }


}
