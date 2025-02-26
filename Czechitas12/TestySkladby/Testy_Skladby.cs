using Czechitas12;

namespace TestySkladby
{
    public class Testy_Skladby
    {
        [Fact] // tento atribut tu musi byt
        public void Konstruktor_Skladby_Nastavuje_Jmeno()
        {
            string nazev = "testovaci nazev skladby";
            Skladba s = new Skladba(nazev);
            Assert.Equal(nazev, s.Nazev);
        }

        [Fact]
        public void Konstruktor_Skladby_Vyhodi_NullReference()
        {
            Assert.Throws<NullReferenceException>(() =>
            {
                Skladba s = new Skladba(null);
            });
        }

        [Fact]
        public void Konstruktor_Skladby_Vyhodi_ArgumentException()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Skladba s = new Skladba("");
            });
        }

        [Fact]
        public void Skladba_Publikovana_Na_Spotify()
        {
            Skladba s = new Skladba("Test nazev pisne");
            s.PublikujNaSpotify();

            Assert.True(s.JeNaSpotify);
        }

    }
}