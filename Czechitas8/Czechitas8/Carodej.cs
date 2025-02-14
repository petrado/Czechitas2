using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Czechitas8
{
    class Carodej : PohadkovaBytost, IKouzelnaBytost
    {
        public void BudNeviditelny()
        {
            Console.WriteLine("Neni me videt");
        }

        public void BudViditelny()
        {
            Console.WriteLine("Je me videt");
        }

        public override void PredstavSe()
        {
            Console.WriteLine("ja jsem carodej");
        }
    }
}
