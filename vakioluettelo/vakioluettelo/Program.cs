using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vakioluettelo
{
    class Program
    {
        enum Valikko { lisaaNimi = 1, lisaaAika, naytaNimi, naytaAika, poistu }
        static void Main(string[] args)
        {
            DateTime Now = DateTime.Now;
            string nimi = "";
            DateTime syntyma = DateTime.ParseExact("1.1.1900", "d.M.yyyy", System.Globalization.CultureInfo.InvariantCulture);
            menu:
            Console.Clear();
            Console.WriteLine("1. Syötä Nimesi.");
            Console.WriteLine("2. Syötä Ikäsi.");
            Console.WriteLine("3. Näytä Nimesi.");
            Console.WriteLine("4. Näytä Ikäsi.");
            Console.WriteLine("5. Poistu.");

            Valikko valinta = (Valikko)int.Parse(Console.ReadLine());
            switch (valinta)
            {
                case Valikko.lisaaNimi:
                    Console.Clear();
                    Console.Write("Kirjoita nimesi: ");
                    nimi = Console.ReadLine();
                    goto menu;
                case Valikko.lisaaAika:
                    Console.Write("Kirjoita syntymäaikasi (dd.mm.yyyy): ");
                    Console.Clear();
                    syntyma = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", System.Globalization.CultureInfo.InvariantCulture);
                    Console.ReadKey();
                    goto menu;
                case Valikko.naytaNimi:
                    Console.Clear();
                    Console.Write("Nimesi on: ");
                    Console.WriteLine(nimi);
                    Console.ReadKey();
                    goto menu;
                case Valikko.naytaAika:
                    Console.Clear();
                    Console.Write("Ikäsi on: ");
                    Console.Write((DateTime.Today - syntyma).Days/365);
                    Console.ReadKey();
                    goto menu;
                case Valikko.poistu:

                    Environment.Exit(0);
                    break;
                    
            }
            Console.ReadKey();
        }
    }
}
