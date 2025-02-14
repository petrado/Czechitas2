using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Czechitas8
{
    class Princ : PohadkovaBytost, ITancujiciBytost
    {
        public override void PredstavSe()
        {
            Console.WriteLine("ja jsem princ");
        }

        public void PrestanTancovat()
        {
            // kdyz pouzivam z Interface abstraktni metody, tak uz nemusim davat override
            Console.WriteLine("Princ prestal tancovat");
        }

        public void ZacniTancovat()
        {
            Console.WriteLine("Princ zacal tancovat");
        }
    }
}
