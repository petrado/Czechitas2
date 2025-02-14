using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Czechitas8
{
    class Princezna : PohadkovaBytost, ITancujiciBytost
    {
        public override void PredstavSe()
        {
            Console.WriteLine("ja jsem princezna");
        }

        public void PrestanTancovat()
        {
            Console.WriteLine("Princezna prestala tancovat");
        }

        public void ZacniTancovat()
        {
            Console.WriteLine("Princezna zacala tancovat");
        }
    }
}
