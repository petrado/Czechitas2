using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Czechitas8_BR
{
    class Carodej : KouzelnaBytost
    {
        public override void Caruj()
        {
            Console.WriteLine("Jsem carodej a caruju");
        }

        public override void NapisJakTravisVolnyCas()
        {
            Console.WriteLine("Zdokonaluju lektvary");
        }

        public override void SusBylinky()
        {
            Console.WriteLine("Susim bylinky na lektvary");
        }
    }
}
