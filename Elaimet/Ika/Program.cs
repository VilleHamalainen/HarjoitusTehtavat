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
                kissa.SetCatAge(rnd.Next(0, 15));
                Kissat.Add(kissa);


                Koira koira = new Koira();
                koira.SetDogAge(rnd.Next(1, 10));
                Koirat.Add(koira);
            }
            
            for(int i = 0; i < 10; i++)
            {
                Console.Write("Kissa on: {0}, ",Kissat[i].ReturnCatAge());
                Console.Write("Koira on: " + Koirat[i].ReturnDogAge());


                if (Kissat[i].ReturnCatAge() < Koirat[i].ReturnDogAge())
                {
                    Console.WriteLine("Koira on vanhempi");
                }
                else
                {
                    Console.WriteLine("Kissa on vanhempi");
                }
            }
            
            Console.ReadKey();
        }
    }
}
