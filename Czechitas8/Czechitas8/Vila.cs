using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Czechitas8
{
    class Vila : PohadkovaBytost, ITancujiciBytost, IKouzelnaBytost
    {
        public override void PredstavSe()
        {
            Console.WriteLine("Ja jsem vila");
        }

        void IKouzelnaBytost.BudNeviditelny()
        {
            Console.WriteLine("Vilu je videt");
        }

        void IKouzelnaBytost.BudViditelny()
        {
            Console.WriteLine("Vilu neni videt");
        }

        void ITancujiciBytost.PrestanTancovat()
        {
            Console.WriteLine("Vila prestala tancovat");
        }

        void ITancujiciBytost.ZacniTancovat()
        {
            Console.WriteLine("Vila zacala tancovat");
        }
    }
}
