using Czechitas11;

namespace Lekce12.Testy
{
    public class TestySkladby
    {
        [Fact] // musi byt pro test
        public void Konstruktor_skladby_nastavuje_jmeno()
        {
            string nazev = "testovaci nazev skladby";
            Skladba s = new Skladba(nazev);
            Assert.Equal(nazev, s.Nazev);
        }

        [Fact]
        public void Konstruktor_skladby_vyhodi_null_reference_kdyz_je_null()
        {
            Assert.Throws<NullReferenceException>(() =>
            {
                Skladba s = new Skladba(null);
            });
        }
    }
}