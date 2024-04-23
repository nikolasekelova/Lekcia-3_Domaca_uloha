namespace Lekcia_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Lekcia C#2");
            //Rytier albert = new Rytier("Albert", 3);
            //albert.VypisJmenoAZivoty();
          
/*
Napište program, který se zeptá na dvě čísla a zobrazí jejich součet.
Napište program, který se zeptá na počet hvězdiček a potom je v cyklu zobrazí na konzoli.
Vytvořte třídu Lucistnik, ktera bude mit vlastnost PocetSipu a metodu Vystrel. PocetSipu muze byt nastaven treba na 10.
Pokud bude mit dost sipu, napise metoda Vystrel na konzoli text: Vzdy se strefim primo do prostred!
Metoda Vystrel uvnitr s kazdym vystrelem snizi pocet sipu.
Pokud bude pocet 0, metoda Vystrel vypise "Nemam sipy".
Napiste program, ktery vytvori lucistnika a vystreli vsechny sipy.
Napište program, který umožní hádat číslo. Zeptá se, jaké číslo si myslím. Podle toho, jaké číslo se zadá, napíše, jestli je číslo větší nebo menší a umožní hádat tak dlouho, dokud se uživatel netrefí:
       Např.
       Hádej číslo: 10
       Číslo je menší, hádej znovu: 5
       Číslo je větší, hádej znovu: 7
       To je správně!

Řešení odevzdejte pushnutím do svého repozitáře v GIT.
*/

            
                Console.WriteLine("Zadaj Prve cislo");
                string vstup1 = Console.ReadLine();
                double cislo1 = Double.Parse(vstup1);

                Console.WriteLine("Zadaj druhe cislo");
                string vstup2 = Console.ReadLine();
                double cislo2 = Double.Parse(vstup2);

                double sucet = cislo1 + cislo2;
                Console.WriteLine($"Sucet cisel {cislo1} a {cislo2} je {sucet}.");
                Console.WriteLine("");
                //.....................................................................
                Console.WriteLine("Zadaj pocet hviezdiciek v rozmedzi 1-10");
                string pocetHviezdiciekText = Console.ReadLine();
                int pocetHviezdiciekCislo = int.Parse(pocetHviezdiciekText);

                if (pocetHviezdiciekCislo > 0 && pocetHviezdiciekCislo < 10)
                {
                    for (int i = 1; i <= pocetHviezdiciekCislo; i++)
                    {
                        Console.WriteLine("*");
                    }
                }

                else
                {

                    Console.WriteLine("Nezadal si cislo v rozmadzi 1-10");


                }



            }
        }
    }

