using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Czechitas10
{
    internal class Vytisk
    {
        public string Identifikator { get; set; }
        public int RokVydani { get; set; }
        public Titul Titul { get; }

        public Vytisk(string identifikator, int rokVydani, Titul titul)
        {
            Identifikator = identifikator;
            RokVydani = rokVydani;
            Titul = titul;
        }
    }
}
