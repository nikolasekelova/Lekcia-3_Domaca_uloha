namespace Lekcia_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lekcia C#2");
            Rytier albert = new Rytier("Albert", 3);
            albert.VypisJmenoAZivoty();
            albert.datumNarozeni = DateTime.Now; // okamzity cas v PC
            albert.datumNarozeni = new DateTime(1993, 11, 11);
          //  albert.datumNarozeni = albert.datumNarozeni.AddHours(12).AddDays(3);
            Console.WriteLine($"Narodil som sa { albert.datumNarozeni.Date}.{albert.datumNarozeni.Month}.{albert.datumNarozeni.Year}.");

            TimeSpan vek = DateTime.Now - albert.datumNarozeni;
            DateTime novyCas = new DateTime(1993, 11, 11, 18, 20, 0);
            TimeSpan odpocetHodinMinut = novyCas - albert.datumNarozeni;

            Console.WriteLine($"Moj vek je {albert.datumNarozeni}.");

            Console.WriteLine($"Moj vek je {odpocetHodinMinut.TotalDays / 365}.");
            Console.WriteLine($"Moj vek je {vek.Days/365}.");
        }

       
    }
}