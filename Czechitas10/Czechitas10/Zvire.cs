using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Czechitas10
{
    internal abstract class Zvire : IVypisInfo
    {
        private string TajnaVlastnost { get; set; }
        public string Jmeno { get; set; }
        public int PocetKoncetin { get; set; }

        public void VypisInfo()
        {
            Console.WriteLine("Vrrrrrrrrr");
        }
    }

    internal class Savec : Zvire
    {
        public string BarvaSrsti { get; set; }
    }

    internal class Hmyz : Zvire
    {
        public string PocetOci { get; set; }
    }
}
