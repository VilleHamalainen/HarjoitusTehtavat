using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElainLuokat;

namespace Tehtävä_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Koira musti = new Koira();
            Papukaija kaija = new Papukaija();


            Console.Write("Anna eläimelle nimi: ");
            musti.SetName(Console.ReadLine());
            Console.Clear();

            Console.Write("Anna eläimelle ikä: ");
            musti.SetAge(int.Parse(Console.ReadLine()));
            Console.Clear();
            
            Console.Write("Hampaiden määrä: ");
            musti.SetTeeth(int.Parse(Console.ReadLine()));
            Console.Clear();


            //Papukaija
            Console.Write("Anna eläimelle nimi: ");
            kaija.SetName(Console.ReadLine());
            Console.Clear();

            Console.Write("Anna eläimelle ikä: ");
            kaija.SetAge(int.Parse(Console.ReadLine()));
            Console.Clear();

            Console.Write("Höyhenkerroksen paksuus (cm): ");
            kaija.SetFeathers(int.Parse(Console.ReadLine()));
            Console.Clear();

            Console.WriteLine(musti.ReturnName());
            Console.WriteLine(musti.ReturnAge());
            Console.WriteLine(musti.ReturnTeeth());
            Console.WriteLine();
            Console.WriteLine(kaija.ReturnName());
            Console.WriteLine(kaija.ReturnAge());
            Console.WriteLine(kaija.ReturnFeathers());
            Console.ReadKey();
        }
    }
}
