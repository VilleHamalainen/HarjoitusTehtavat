using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pituusmuunnin
{
    class Program
    {
        static void Main(string[] args)
        {
            double inc;
            double m;
            double mile;
            double jaardi;
            Console.Write("Pituutesi (cm): ");
            double cm = Convert.ToDouble(Console.ReadLine());
            inc = cm * 0.39370;
            m = cm * 0.01;
            mile = cm / 160934.4;
            jaardi = cm * 0.010936133;
            Console.WriteLine("{0} Senttiä : {1} metriä", cm, m);
            Console.WriteLine("{0} Senttiä : {1} tuumaa", cm, inc);
            Console.WriteLine("{0} Senttiä : {1} mailia", cm, mile);
            Console.WriteLine("{0} Senttiä : {1} jaardia", cm, jaardi);
            Console.ReadKey();

        }
    }
}
