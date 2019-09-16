using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElainLuokat;

namespace Periytyminen
{
    class Program
    {
        static void Main(string[] args)
        {
            Koira musti = new Koira();

            Console.Write("Anna kissalle nimi: ");
            musti.SetName(Console.ReadLine());

            Console.Write("Aseta kissalle ikä: ");
            musti.SetAge(int.Parse(Console.ReadLine()));

            Console.WriteLine("Onko kissa lihansyöjä? true/false");
            musti.SetCarnivore(bool.Parse(Console.ReadLine()));

            Console.WriteLine(musti.ReturnName());
            Console.WriteLine(musti.ReturnAge());
            Console.WriteLine(musti.ReturnCarnivore());

            Console.ReadKey();
        }
    }
}
