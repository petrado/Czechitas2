using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Czechitas7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hrdina pavel = new Hrdina(11);
            pavel.Jmeno = "Pavel";
            pavel.JakSeJmenuju();
            // pavel.Zivoty = 11;
            // PohadkovaBytost bytostObecna = new PohadkovaBytost();
            // bytostObecna.Jmeno = "Bytost Obecna";
            Carodejnice bilaPani = new Carodejnice() { Jmeno = "Bila Pani"};
            List<PohadkovaBytost> pohadkoveBytosti = new List<PohadkovaBytost>();
            pohadkoveBytosti.Add(pavel);
            // pohadkoveBytosti.Add(bytostObecna);
            pohadkoveBytosti.Add(bilaPani);

            foreach (var bytost in pohadkoveBytosti)
            {
                bytost.JakSeJmenuju();
            }

            pohadkoveBytosti.ForEach(bytost => bytost.Zautocim());

            SuperHrdina superman = new SuperHrdina(500, "Supi") { Jmeno = "Clark Kent"};
            pohadkoveBytosti.Add(superman);
            superman.PouzijSuperschopnost();

            int pocitadlo = 0;

            foreach (var bytost in pohadkoveBytosti)
            {
                if (bytost is SuperHrdina)
                {
                    Console.WriteLine("Ja jsem superhrdina " + bytost.Jmeno);
                    bytost.Zautocim();
                    pocitadlo++;
                    SuperHrdina druhySuperman = (SuperHrdina)bytost;
                    druhySuperman.PouzijSuperschopnost();
                    druhySuperman.ToString();
                }
                object temp = bytost;
                Console.WriteLine(temp.ToString());
            }
            
            Console.WriteLine("Pocitadlo superhrdinu: " + pocitadlo);

            // navrhnete vhodnou strukturu trid, ktera umozni v programu (v mainu) vytvorit seznam zviratek v zoo koutku (list)
            // ktery pak muzeme jednoduse projit cyklem (foreach) a zadat kazdemu z nich prikaz VydavejZvuk
            // pritom kazde zviratko bude vydavat jiny zvuk (vypise na konzoli haf, haf, mnau...)
            // v ramci cyklu nechci resit, jake konkretni zviratko to je
            // vytvorte alespon 3 ruzna zviratka
            // hint: budete potrebovat vhodnou bazovou tridu a virtual / abstract a override
            Console.WriteLine();
            Pes pes = new Pes();
            Kocka kocka = new Kocka(); 
            Kun kun = new Kun();

            pes.Jmeno = "Alik";
            kocka.Jmeno = "Micka";
            kun.Jmeno = "Ilci";
            List<Zvire> zvirata= new List<Zvire>();
            zvirata.Add(pes);
            zvirata.Add(kocka);
            zvirata.Add(kun);

            foreach (var zvire in zvirata)
            {
                zvire.JmenujuSe();
                zvire.VydavejZvuj();
            }

        }
    }


    // polymorfismus - kazdy potomek abstraktni tridy musi implementovat jeji abstraktni metody - kazdy potomek ma jine metody
    // virtual - necham v originalnim stavu

    public abstract class Zvire
    {
        public string Jmeno { get; set; }

        public virtual void VydavejZvuj()
        {
            Console.WriteLine("Vydavam zvuk");
        }

        public virtual void JmenujuSe()
        {
            Console.WriteLine("Jmenuju se " + Jmeno);
        }
    }

    public class Pes : Zvire 
    {
        public override void VydavejZvuj()
        {
            base.VydavejZvuj();
            Console.WriteLine("Haf haf");
        }
    }

    public class Kocka : Zvire
    {
        public override void VydavejZvuj()
        {
            base.VydavejZvuj();
            Console.WriteLine("Mnau mnau");
        }
    }

    public class Kun : Zvire
    {
        public override void VydavejZvuj()
        {
            base.VydavejZvuj();
            Console.WriteLine("Ihaaa");
        }
    }




    public abstract class PohadkovaBytost : BaseTrida
    {
        public string Jmeno { get; set; }

        public virtual void JakSeJmenuju()
        {
            Console.WriteLine($"Jmenuju se {Jmeno}");
        }

        public abstract void Zautocim();
    }

    public abstract class BaseTrida
    {
        public Guid Guid { get; set; } = new Guid();
    }

    public class Hrdina : PohadkovaBytost
    {
        public int Zivoty { get; set; } = 10;
        public override void Zautocim()
        {
            Console.WriteLine(Jmeno + " svihl mecem");
        }

        public Hrdina(int zivoty)
        {
            Zivoty = zivoty;
        }
    }

    public class SuperHrdina : Hrdina
    {
        public string Prezdivka { get; set; }
        
        public void PouzijSuperschopnost()
        {
            base.Zautocim(); // z odvozene tridy muzu zavolat hlavni tridy
            Console.WriteLine(Jmeno + " pouzije laserove oci");
        }

        public override void JakSeJmenuju()
        {
            base.JakSeJmenuju();
            Console.WriteLine("Wuaaa");
        }

        public SuperHrdina(int zivoty, string prezdivka) : base (zivoty)
        {
            Prezdivka = prezdivka;
        }

        public override string ToString()
        {
            return "Ja jsem superhrdina "+ Jmeno + " " + Prezdivka;
        }
    }

    public class Carodejnice : PohadkovaBytost
    {
        public override void Zautocim()
        {
            Console.WriteLine(Jmeno + " vykouzlila ohnivou kouli");
        }

        public override void JakSeJmenuju()
        {
            base.JakSeJmenuju();
            Console.WriteLine("huuuuuuuuuuuu");
        }
    }

}
