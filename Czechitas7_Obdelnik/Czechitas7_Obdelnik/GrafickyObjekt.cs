using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Czechitas7_Obdelnik
{
    public abstract class GrafickyObjekt
    {
        public int Vyska { get; set; }
        public int Sirka { get; set; }
        public virtual void Vykresli()
        {
            Console.WriteLine("X");
        }
    }

    public class Obdelnik : GrafickyObjekt
    {
        public override void Vykresli()
        {
            Console.WriteLine("Kreslim obdelnik");
            Console.WriteLine("###");
            Console.WriteLine("###");
        }
    }

    public class Trojuhelnik : GrafickyObjekt
    {
        public override void Vykresli()
        {
            Console.WriteLine("Kreslim trojuhelnik");
            Console.WriteLine("#");
            Console.WriteLine("##");
            Console.WriteLine("###");
        }
    }

    public class Text : GrafickyObjekt
    {
        public override void Vykresli()
        {
            Console.WriteLine("Text");
        }
    }

}
