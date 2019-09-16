using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ElainLuokat;

namespace teht3
{
    class Program
    {
        static void Main(string[] args)
        {
            Kissa katti = new Kissa();

            Console.Write("Anna kissalle nimi: ");
            katti.SetName(Console.ReadLine());

            Console.Write("Aseta kissalle ikä: ");
            katti.SetAge(int.Parse(Console.ReadLine()));

            Console.WriteLine("Onko kissa lihansyöjä? true/false");
            katti.SetCarnivore(bool.Parse(Console.ReadLine()));

            Console.Clear();
            Console.WriteLine(katti.ReturnName());
            Console.WriteLine(katti.ReturnAge());
            Console.WriteLine(katti.ReturnCarnivore());

            Console.ReadKey();
        }
    }
}
