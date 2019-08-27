using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElainLuokat;

namespace Tehtävä_11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Elain> elaimet = new List<Elain>();

            Random rnd = new Random();
            int indexHorse = 0;
            int indexOthers = 1;
            for (int i = 1; i <= 12; i++)
            {
                if (indexHorse == 3)
                {
                    Hevonen hevonen = new Hevonen();
                    hevonen.SetName("Hepo");
                    hevonen.SetAge(rnd.Next(0, 20));
                    hevonen.SetCarnivore(false);
                    hevonen.SetTeeth(rnd.Next(36, 40));
                    elaimet.Add(hevonen);
                    Console.WriteLine("Horse created.");
                    indexHorse = 0;
                    indexOthers++;
                    if (indexOthers == 4)
                    {
                        indexOthers = 1;
                    }
                    continue;
                }
                else if (indexOthers == 2)
                {
                    Kissa kissa = new Kissa();
                    kissa.SetName("Milo");
                    kissa.SetAge(rnd.Next(0, 10));
                    kissa.SetCarnivore(true);
                    kissa.SetTeeth(rnd.Next(26,32));
                    elaimet.Add(kissa);
                    Console.WriteLine("Cat created.");

                }
                else if (indexOthers == 1)
                {
                    Koira koira = new Koira("Musti", 7, 24, true);
                    koira.SetAge(rnd.Next(1, 15));
                    koira.SetName("Musti");
                    koira.SetCarnivore(true);
                    koira.SetTeeth(rnd.Next(28,42));
                    elaimet.Add(koira);
                    Console.WriteLine("Dog created.");
                }
                else
                {
                    Papukaija papukaija = new Papukaija("Arnold", 1, true, 2);
                    papukaija.SetName("Arnold");
                    papukaija.SetAge(rnd.Next(0, 7));
                    papukaija.SetCarnivore(false);
                    papukaija.SetFeathers(2);
                    elaimet.Add(papukaija);
                    Console.WriteLine("Parrot created");
                    indexOthers = 1;
                    indexHorse++;
                    continue;
                }
                indexHorse++;
                indexOthers++;
            }

            foreach (Nisakkaat elain in elaimet.OfType<Nisakkaat>())
            {
                Console.WriteLine("Nimi: {0}\nIkä: {1}\nLihansyöjä: {2}\nHampaiden määrä: {3}\n\n", elain.ReturnName(), elain.ReturnAge(), elain.ReturnCarnivore(), elain.ReturnTeeth());
            }

            foreach (Linnut elain in elaimet.OfType<Linnut>())
            {
                Console.WriteLine("Nimi: {0}\nIkä: {1}\nLihansyöjä: {2}\nHöyhenpeitteen paksuus (cm): {3}", elain.ReturnName(), elain.ReturnAge(), elain.ReturnCarnivore(), elain.ReturnFeathers());
            }
            Console.ReadKey();
        }
    }
}
