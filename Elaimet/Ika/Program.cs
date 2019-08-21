using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElainLuokat;

namespace Ika
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Kissa> Kissat = new List<Kissa>();
            List<Koira> Koirat = new List<Koira>();
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                Kissa kissa  = new Kissa();
                kissa.SetAge(rnd.Next(0, 10));
                Kissat.Add(kissa);


                Koira koira = new Koira();
                koira.SetAge(rnd.Next(1, 15));
                Koirat.Add(koira);
            }
            
            for(int i = 0; i < 10; i++)
            {
                Console.Write("Kissa on: {0}, ",Kissat[i].ReturnAge());
                Console.Write("Koira on: " + Koirat[i].ReturnAge());
                Console.Write("\n");

                if (Kissat[i].ReturnAge() < Koirat[i].ReturnAge())
                {
                    Console.WriteLine("Koira on vanhempi.");
                }
                else if(Koirat[i].ReturnAge() < Kissat[i].ReturnAge())
                {
                    Console.WriteLine("Kissa on vanhempi.");
                }
                else if (Koirat[i].ReturnAge() == Kissat[i].ReturnAge())
                {
                    Console.WriteLine("Kissa ja koira ovat samanikäisiä.");
                }
                Console.Write("\n");
            }
            
            Console.ReadKey();
        }
    }
}
