using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Czechitas8_BR
{
    class Vila : KouzelnaBytost
    {
        public override void Caruj()
        {
            Console.WriteLine("Jsem Vila a caruju");
        }

        public override void NapisJakTravisVolnyCas()
        {
            Console.WriteLine("Trham lucni kviti");
        }

        public override void SusBylinky()
        {
            Console.WriteLine("Jsem vila a susim bylinky");
        }
    }
}
