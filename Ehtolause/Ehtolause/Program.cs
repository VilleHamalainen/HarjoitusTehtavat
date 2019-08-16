using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ehtolause
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ikäsi: ");
            int ikä = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write("Sukupuolesi(m/n): ");
            string sukupuoli = Console.ReadLine();
            Console.Clear();
            if(ikä < 13)
            {
                if (sukupuoli == "n")
                {
                    Console.Clear();
                    Console.WriteLine("Hei tyttö");
                }
                else if (sukupuoli == "m")
                {
                    Console.Clear();
                    Console.WriteLine("Hei poika");
                }
            }
            if (ikä > 14 && ikä < 25)
            {
                if (sukupuoli == "n")
                {
                    Console.Clear();
                    Console.WriteLine("mitä nuorinainen");
                }
                else if (sukupuoli == "m")
                {
                    Console.Clear();
                    Console.WriteLine("mitä nuorimies");
                }
            }
            if (ikä > 26 && ikä < 56)
            {
                if (sukupuoli == "n")
                {
                    Console.Clear();
                    Console.WriteLine("olet nainen parhaassa iässä");
                }
                else if (sukupuoli == "m")
                {
                    Console.Clear();
                    Console.WriteLine("Olet mies parhaassa iässä");
                }
            }
            if (ikä > 56)
            {
                if (sukupuoli == "n")
                {
                    Console.Clear();
                    Console.WriteLine("Hei vanhanainen");
                }
                else if (sukupuoli == "m")
                {
                    Console.Clear();
                    Console.WriteLine("Hei vanhamies");
                }
            }
            Console.ReadKey();
        }
    }
}
