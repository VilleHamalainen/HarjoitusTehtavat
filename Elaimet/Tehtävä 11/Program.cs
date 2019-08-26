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
            for (int i = 0; i < 10; i++)
            {
                if(indexHorse == 3)
                {
                    Hevonen hevonen = new Hevonen("Hepo", 3, 20, true);
                    elaimet.Add(hevonen);
                    indexHorse = 0;
                    indexOthers++;
                    if(indexOthers == 4)
                    {
                        indexOthers = 1;
                    }
                }
                else if (indexOthers == 1)
                {
                    Kissa kissa = new Kissa("Milo", 5, 26, true);
                    kissa.SetAge(rnd.Next(0, 10));
                    elaimet.Add(kissa);
                    
                }
                else if(indexOthers == 2)
                {
                    Koira koira = new Koira("Musti", 7, 24,true);
                    koira.SetAge(rnd.Next(1, 15));
                    elaimet.Add(koira);
                }
                else
                {
                    Papukaija papukaija = new Papukaija("Arnold", 1, 8, 2);
                    elaimet.Add(papukaija);
                    indexOthers = 1;
                    indexHorse++;
                }
                indexHorse++;
                indexOthers++;
            }
        }
    }
}
