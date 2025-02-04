using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Czechitas4
{
    internal class TelefonniSeznam
    {

        private Dictionary<string, int> telephoneDirectory; 

        public TelefonniSeznam()
        {
            telephoneDirectory = new Dictionary<string, int>();
        }

        public void PridejVstup(string jmeno, int cislo)
        {
            telephoneDirectory[jmeno] = cislo;
        }

    }
}
