using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Czechitas8_BR2
{
    class Kruh : IUmiPocitatObsah, IUmiPocitatObvod
    {
        public int Polomer { get; set; }

        public Kruh(int polomer)
        {
            Polomer = polomer;
        }
        
        public void VypoctiObsah()
        {
            Console.WriteLine("Obsah kruhu je: " + Math.PI * Polomer * Polomer);
        }

        public void VypoctiObvod()
        {
            Console.WriteLine("Obvod kruhu je: " + 2 * Math.PI * Polomer);
        }
    }
}
