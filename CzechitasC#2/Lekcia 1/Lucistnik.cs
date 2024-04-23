namespace Lekcia_1
{
    internal class Lucistnik
    {
        public string Jmeno { get; set; }
        public int PocetZivotu { get; set; }
        public DateTime datumNarozeni;

        public Lucistnik(string jmeno, int pocetZivotu)
        {
            Jmeno = jmeno;
            PocetZivotu = pocetZivotu;
        }

        public void VypisJmenoAZivoty()
        {
            Console.WriteLine($"Jmenuji se {Jmeno} a mam pocet zivotu {PocetZivotu}");
        }
    }
}
