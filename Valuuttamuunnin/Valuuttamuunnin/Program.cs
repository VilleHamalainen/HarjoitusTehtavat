using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valuuttamuunnin
{
    class Program
    {
        static void Main(string[] args)
        { 
            double eur, usd, gbp;
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Euromäärä: ");
            eur = double.Parse(Console.ReadLine());
            usd = eur * 1.132155;
            gbp = eur * 0.877762013;

            Console.Clear();
        start:
            Console.Clear();
            Console.WriteLine("Haluatko verrata euroa puntaan vai dollariin (p/d)");
            string result = Console.ReadLine();
            if(result == "d")
            {
                Console.Clear();
                Console.WriteLine("{0} Euroa on {1} Dollaria", eur, usd);
                goto end;
            }
            else if(result == "p")
            {
                Console.Clear();
                Console.WriteLine("{0} euroa on {1} puntaa", eur, gbp);
                goto end;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("kirjoita joko p tai d");
                goto start;
            }
        end:
            Console.ReadKey();
        }
    }
}
