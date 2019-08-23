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
            List<Kissa> Kissat = new List<Kissa>();
            List<Koira> Koirat = new List<Koira>();
            List<Papukaija> Papukaijat = new List<Papukaija>();
            List<Hevonen> Hevoset = new List<Hevonen>();

            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {

                if(i % 4 == 0)
                {
                    Hevonen hevonen = new Hevonen();
                }
                Kissa kissa = new Kissa();
                kissa.SetAge(rnd.Next(0, 10));
                Kissat.Add(kissa);


                Koira koira = new Koira();
                koira.SetAge(rnd.Next(1, 15));
                Koirat.Add(koira);
            }
        }
    }
}
